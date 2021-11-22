using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17503_FILIP_TRAJKOVIC_1_ZADATAK
{
    class FSWatcher
    {
        private FileSystemWatcher watcher;
        private string watchedDirectory;
        private string outputDirectory;
        private bool isWatcherOn;
        private Random rnd;
        private string keyFile = @"./keys.txt";
        private A51Algorithm a51;
        public FSWatcher()
        {
            a51 = new A51Algorithm();
            watcher = new FileSystemWatcher();

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = false;
            isWatcherOn = false;
            watchedDirectory = "";
            outputDirectory = "";
            rnd = new Random();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);

            if (outputDirectory.Length != 0)
                this.EncodeTextFile(e.FullPath, this.outputDirectory);
            else
                Console.WriteLine("Output diretory isn't set!");
        }

        public bool SetWatchedDirectory(string directory)
        {
            if (!isWatcherOn)
                if (outputDirectory.Length == 0 || outputDirectory.CompareTo(directory) != 0)
                {
                    this.watchedDirectory = directory;
                    watcher.Path = directory;
                    return true;
                }
            return false;
        }

        /*  public void SetNewKey(int key)
          {
              rf.SetKey(key);
          }*/
        public bool SetOutputDirectory(string dir)
        {
            if (!isWatcherOn)
            {
                if (watchedDirectory.Length == 0 || watchedDirectory.CompareTo(dir) != 0)
                {
                    this.outputDirectory = dir;
                    return true;
                }
            }
            return false;
        }

        public bool IsWatcherSystemOn()
        {
            return this.isWatcherOn;
        }

        public string GetTargetDirectory()
        {
            return this.watchedDirectory;
        }
        public string GetDestinationDirectory()
        {
            return this.outputDirectory;
        }

        public void TurnOnFileSystemWatcher()
        {
            if (this.watchedDirectory == "" || this.outputDirectory == "")
                throw new Exception("You need to specify target and destination folders before turning on File Watcher System!");
            if (!isWatcherOn)
            {
                isWatcherOn = true;
                watcher.EnableRaisingEvents = true;
            }
        }

        public void TurnOffFileSystemWatcher()
        {
            if (isWatcherOn)
            {
                isWatcherOn = false;
                watcher.EnableRaisingEvents = false;
            }
        }

        //public void EncodeAllFilesFromDirectory(string path)
        //{
        //    if (this.outputDirectory.Length == 0)
        //        throw new Exception("Destination folder not set!");
        //    foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
        //        this.EncodeTextFile(txtFile, this.outputDirectory);
        //}

        private bool EncodeTextFile(string fullFileName, string outputDirectory)
        {
            string outputFileName = outputDirectory + @"\" + Path.GetFileName(fullFileName);
            string key = GenerateKey();
            a51.Key = key;

            char[] textForCoding = this.ReadTextFile(fullFileName);

            string encodedText = a51.Crypt(new string(textForCoding));
            this.WriteToTextFile(outputFileName, encodedText);
            this.WriteKeyToKeyFile(outputFileName, key);
            return true;



        }
        private void WriteKeyToKeyFile(string fileName, string key)
        {
            string entry = fileName + " " + key;
            using (StreamWriter sw = File.AppendText(this.keyFile))
            {
                sw.WriteLine(entry);
            }
        }

        public bool DecodeTextFile(string fullFileName, string targetFolder)
        {
            if (this.isWatcherOn) return false;
            string outputFileName = targetFolder + @"\" + Path.GetFileName(fullFileName);

            char[] codedText = this.ReadTextFile(fullFileName);
            int key = this.GetKey(fullFileName);
            if (key == -1) return false;
            //char[] decodedText = A51Algorithm.DecodeStream(codedText, key);
           // this.WriteToTextFile(outputFileName, decodedText);

            return true;

        }

        public int GetKey(string fileName)
        {
            int key = -1;
            using (StreamReader sr = File.OpenText(this.keyFile))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (s.StartsWith(fileName))
                    {
                        int index = fileName.Length + 1;
                        key = int.Parse(s.Substring(index));
                        return key;
                    }
                }
            }
            return key;
        }

        private string GenerateKey()
        {
            string key = "";
            for (int i = 0; i < 64; i++)
                key += rnd.Next(0, 2);
            return key;
        }

        /* public int GetKey(string path)
         {
             if (savedKeys.ContainsKey(path))
                 return savedKeys[path];
             return 0;
         }*/

        private char[] ReadTextFile(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd().ToCharArray();
            }


        }

        private void WriteToTextFile(string path, string content)
        {
            FileStream fajlZaUpis = null;
            try
            {
                byte[] tekstZaUpis = new byte[content.Length];
                tekstZaUpis = Encoding.UTF8.GetBytes(content);

                fajlZaUpis = new FileStream(path, FileMode.Create);
                fajlZaUpis.Write(tekstZaUpis, 0, tekstZaUpis.Length);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                fajlZaUpis.Close();
            }
            return;
        }
    }
}
