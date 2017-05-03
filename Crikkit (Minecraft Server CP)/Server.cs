using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Crikkit__Minecraft_Server_CP_
{
    public class Server
    {
        public static List<Server> Servers = new List<Server>();

        public static Server GetServer(int id)
        {
            foreach (Server s in Servers)
                if (s.ID == id)
                    return s;
            return null;
        }

        public static int CreateNewServer(string name, uint memory)
        {
            Server server = new Server(name, memory);
            Servers.Add(server);
            Console.WriteLine("Server has been created with ID: " + server.ID);
            return server.ID;
        }

        private static uint MemoryFloor = 64;

        private Process Process;
        public int ID;
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

        public List<string> consoleOutput = new List<string>();

        private Server(string name, uint memory)
        {
            ID = Servers.Count;
            Process = null;
            Name = name;
            Memory = memory;
        }

        public string GetWorkingDirectory()
        {
            return Directory.GetCurrentDirectory() + "\\servers\\server" + ID;
        }

        public void Run()
        {
            if (Process != null)
                return;

            if (!Directory.Exists(GetWorkingDirectory()))
                Directory.CreateDirectory(GetWorkingDirectory());

            string pathToJar = "\"" + Directory.GetCurrentDirectory() + "\\jars\\spigot.jar\"";
            Console.WriteLine("Searching for jar in: " + pathToJar);
            //if (!File.Exists(pathToJar))
            //{
            //    Console.WriteLine("Could not find jar file.");
            //    return;
            //}

            Process = new Process();
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.CreateNoWindow = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.RedirectStandardError = true;
            Process.EnableRaisingEvents = false;
            Process.StartInfo.FileName = "java.exe";
            Process.StartInfo.Arguments = "-Xmx" + Memory + "M -jar " + pathToJar;
            Process.StartInfo.WorkingDirectory = GetWorkingDirectory();

            Process.OutputDataReceived += Process_OutputDataReceived;
            Process.ErrorDataReceived += Process_OutputDataReceived;

            Process.Start();

            Process.BeginOutputReadLine();
            Process.BeginErrorReadLine();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data != "")
            {
                consoleOutput.Add(e.Data);
                Console.WriteLine("output: " + e.Data);
            }
        }
    }
}
