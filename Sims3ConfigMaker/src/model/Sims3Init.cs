using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sims3ConfigMaker.src.model
{
    public class Sims3Init : ISims3Options
    {
        private string binPath;
        private string filename;
        public string fileContent;

        public Sims3Init()
        {
            binPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Sims 3\\Game\\Bin\\";
            filename = "Sims3.ini";
            fileContent = ReadOptions();
        }

        public string ReadOptions()
        {
            StringBuilder fileContent = new StringBuilder();

            using (FileStream fs = new FileStream(binPath + filename, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    fileContent.Append(temp.GetString(b));
                }

            }

            return fileContent.ToString();
        }

        
        public string ReadProperty(string propertyName)
        {
            string propertyValue = "";

            string[] lines = fileContent.Split(
                    new string[] { Environment.NewLine },
                    StringSplitOptions.None
                );

            foreach (string line in lines)
            {
                string[] property = line.Split('=');

                if (property[0].Trim() == propertyName)
                {
                    propertyValue = property[1].Trim();
                }
            }

            return propertyValue;
        }

        public void Backup()
        {
            string filenameBackup = "Sims3_BACKUP.ini";


            using (FileStream fs = File.Create(binPath + filenameBackup))
            {
                UTF8Encoding temp = new UTF8Encoding(true);

                fs.Write(temp.GetBytes(fileContent), 0, temp.GetByteCount(fileContent));

                fs.Close();
            }
        }
    }
}
