using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public class Server
    {
        private static uint MemoryFloor = 64;
        public static List<Server> Servers = new List<Server>();

        public static Server GetServer(int id)
        {
            foreach (Server s in Servers)
                if (s.ID == id)
                    return s;
            return null;
        }

        public static int CreateNewServer(string name, uint memory, ServerType type)
        {
            Server server = new Server(name, memory, type);
            Servers.Add(server);
            Console.WriteLine("Server has been created with ID: " + server.ID);
            server.SaveConfiguration();
            return server.ID;
        }

        public static void LoadAllServers()
        {
            string rootPath = Directory.GetCurrentDirectory() + "\\servers";
            foreach (string dir in Directory.GetDirectories(rootPath))
            {
                if (!File.Exists(dir + "\\settings.dat"))
                    continue;
                string folderName = Path.GetFileName(Path.GetDirectoryName(dir + "\\settings.dat"));
                int id = -1;
                int.TryParse(folderName.Split(new string[] { "server" }, StringSplitOptions.None)[1], out id);

                if (id == -1)
                    continue;

                StreamReader reader = new StreamReader(dir + "\\settings.dat");

                string name = reader.ReadLine();
                int memory = 1024;
                int.TryParse(reader.ReadLine(), out memory);
                ServerType type = (ServerType) Enum.Parse(typeof(ServerType), reader.ReadLine());

                Servers.Add(new Server(name, (uint) memory, type));
            }
        }

        public Process Process;
        public int ID;
        private ServerType type;
        private uint memory;
        private ServerCP controlPanel;

        private List<string> Players;

        public ServerType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get;set;
        }
        public uint Memory
        {
            get { return memory; }
            set
            {
                if (value < MemoryFloor)
                    memory = MemoryFloor;
                else
                    memory = value;
            }
        }
        public ServerCP ControlPanel
        {
            get { return controlPanel; }
            set { controlPanel = value; }
        }
        public bool IsRunning
        {
            get
            {
                return Process != null;
            }
        }

        private Server(string name, uint memory, ServerType type)
        {
            ID = Servers.Count;
            Process = null;
            Name = name;
            Memory = memory;
            Type = type;
            Players = new List<string>();
        }

        public string GetWorkingDirectory()
        {
            return Directory.GetCurrentDirectory() + "\\servers\\server" + ID;
        }

        private void SaveConfiguration()
        {
            string path = GetWorkingDirectory() + "\\settings.dat";
            if (File.Exists(path))
                File.Delete(path);
            StreamWriter writer = File.CreateText(path);
            writer.WriteLine(Name);
            writer.WriteLine(Memory);
            writer.WriteLine(Type.ToString());
            writer.Close();
        }

        public void Run()
        {
            if (IsRunning)
            {
                KillServer();
                return;
            }

            if (!Directory.Exists(GetWorkingDirectory()))
                Directory.CreateDirectory(GetWorkingDirectory());

            string pathToJar = Directory.GetCurrentDirectory() + "\\jars\\" + type.ToString().ToLower() + ".jar";
            Console.WriteLine("Searching for jar in: " + pathToJar);
            if (!File.Exists(pathToJar))
            {
                Console.WriteLine("Could not find jar file.");
                return;
            }
            
            Process = new Process();
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.CreateNoWindow = true;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardError = true;
            Process.EnableRaisingEvents = true;
            Process.StartInfo.FileName = "java.exe";
            Process.StartInfo.Arguments = "-Xmx" + Memory + "M -jar " + "\"" + pathToJar + "\" -nojline";
            Process.StartInfo.WorkingDirectory = GetWorkingDirectory();

            Process.OutputDataReceived += Process_OutputDataReceived;
            Process.ErrorDataReceived += Process_OutputDataReceived;

            Process.Start();

            Process.BeginOutputReadLine();
            Process.BeginErrorReadLine();
        }

        public void KillServer()
        {
            Process.StandardInput.WriteLine("stop");
            Process.WaitForExit(5000);
            Process.Close();
            Process = null;
            Console.WriteLine("Server closed.");
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try { ProcessReceived(e.Data); }
            catch { }
            if (ControlPanel != null)
            {
                object[] data = new object[2];
                data[0] = ControlPanel;
                data[1] = e.Data;
                ControlPanel.BeginInvoke(new MyDelegate(DelegateMethod), data);
            }
        }

        private delegate void MyDelegate(ServerCP controlPanel, string output);
        public void DelegateMethod(ServerCP controlPanel, string output)
        {
            controlPanel.TextBoxConsoleOutput.AppendText(output + Environment.NewLine);
        }

        private delegate void PlayerJoinDelegate(string player);
        private delegate void PlayerQuitDelegate(string player);
        public void PlayerJoin(string player)
        {
            ControlPanel.listBox_Players.Items.Add(player);
        }
        public void PlayerQuit(string player)
        {
            ControlPanel.listBox_Players.Items.Remove(player);
        }

        public void ProcessReceived(string data) 
        {
            if (data == null)
                return;

            ServerMessage sm = new ServerMessage(data);

            if (sm.GetType() == ServerMessageType.JOIN)
            {
                Console.WriteLine("Join: " + sm.GetPlayer());
                Players.Add(sm.GetPlayer());
                if (ControlPanel != null)
                {
                    object[] capsule = new object[1];
                    capsule[0] = sm.GetPlayer();
                    ControlPanel.BeginInvoke(new PlayerJoinDelegate(PlayerJoin), capsule);
                }
            }
            else if (sm.GetType() == ServerMessageType.QUIT)
            {
                Console.WriteLine("Quit: " + sm.GetPlayer());
                Players.Remove(sm.GetPlayer());
                if (ControlPanel != null)
                {
                    object[] capsule = new object[1];
                    capsule[0] = sm.GetPlayer();
                    ControlPanel.BeginInvoke(new PlayerQuitDelegate(PlayerQuit), capsule);
                }
            }
        }
    }

    class ServerMessage
    {
        private string Raw;
        private string Message;
        private ServerMessageType Type;
        private string Player;

        public ServerMessage(string raw)
        {
            Raw = raw;
            Message = Raw.Substring(17);
            Type = CalculateType();
            Player = GeneratePlayer();
        }

        private string GetMessage()
        {
            return Message;
        }

        public new ServerMessageType GetType()
        {
            return Type;
        }

        public string GetPlayer()
        {
            return Player;
        }

        private ServerMessageType CalculateType()
        {
            int firstSpace = Message.IndexOf(' ') + 1;
            string proceedingMessage = Message.Substring(firstSpace);

            if (proceedingMessage.StartsWith("logged in with entity id"))
                return ServerMessageType.JOIN;
            else if (proceedingMessage.StartsWith("lost connection:"))
                return ServerMessageType.QUIT;

            return ServerMessageType.NONE;
        }

        private string GeneratePlayer()
        {
            if (Type == ServerMessageType.JOIN)
                return Message.Split(new String[1] { " " }, StringSplitOptions.None)[0].Substring(0, Message.IndexOf('['));
            else if (Type == ServerMessageType.QUIT)
                return Message.Split(new String[1] { " " }, StringSplitOptions.None)[0];

            return "null";
        }
    }

    enum ServerMessageType
    {
        NONE, JOIN, QUIT
    }
}
