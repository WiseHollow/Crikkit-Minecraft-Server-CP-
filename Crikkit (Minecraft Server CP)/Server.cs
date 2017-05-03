using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crikkit__Minecraft_Server_CP_
{
    public class Server
    {
        public static List<Server> Servers = new List<Server>();

        public static int CreateNewServer(string name, uint memory)
        {
            Server server = new Server(name, memory);
            Servers.Add(server);
            Console.WriteLine("Server has been created with ID: " + server.ID);
            return server.ID;
        }

        private static uint MemoryFloor = 64;

        private Process Process;
        private int ID;
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

            string pathToJar = GetWorkingDirectory() + "\\spigot.jar";

            Process = new Process();
            Process.EnableRaisingEvents = false;
            Process.StartInfo.FileName = "java.exe";
            Process.StartInfo.Arguments = "-Xmx" + Memory + "M -jar " + Directory.GetCurrentDirectory() + "\\jars\\spigot.jar";
            Process.Start();
        }
    }
}
