using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public ServerType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get;set;
        }
        private uint memory;
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

        private ServerCP controlPanel;
        public ServerCP ControlPanel
        {
            get { return controlPanel; }
            set { controlPanel = value; }
        }

        private Server(string name, uint memory, ServerType type)
        {
            ID = Servers.Count;
            Process = null;
            Name = name;
            Memory = memory;
            Type = type;
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
            if (Process != null)
            {
                Process.Close();
                Process = null;
                return;
            }

            if (!Directory.Exists(GetWorkingDirectory()))
                Directory.CreateDirectory(GetWorkingDirectory());

            string pathToJar = "" + Directory.GetCurrentDirectory() + "\\jars\\" + type.ToString().ToLower() + ".jar";
            Console.WriteLine("Searching for jar in: " + pathToJar);
            if (!File.Exists(pathToJar))
            {
                Console.WriteLine("Could not find jar file.");
                return;
            }

            Process = new Process();
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.CreateNoWindow = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.RedirectStandardError = true;
            Process.EnableRaisingEvents = false;
            Process.StartInfo.FileName = "java.exe";
            Process.StartInfo.Arguments = "-Xmx" + Memory + "M -jar " + "\"" + pathToJar + "\"";
            Process.StartInfo.WorkingDirectory = GetWorkingDirectory();

            Process.OutputDataReceived += Process_OutputDataReceived;
            Process.ErrorDataReceived += Process_OutputDataReceived;

            Process.Start();

            Process.BeginOutputReadLine();
            Process.BeginErrorReadLine();

            Process.WaitForExit();
            Console.WriteLine("Closed process");
            Process.Close();
            Process = null;
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (ControlPanel != null)
            {
                object[] data = new object[2];
                data[0] = ControlPanel.TextBoxConsoleOutput;
                data[1] = e.Data;
                ControlPanel.BeginInvoke(new MyDelegate(DelegateMethod), data);
            }
        }

        private delegate void MyDelegate(TextBox textBox, string output);
        public void DelegateMethod(TextBox textBox, string output)
        {
            textBox.Text += output + Environment.NewLine;
        }
    }
}
