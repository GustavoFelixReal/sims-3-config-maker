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
        private string filePath;
        public string fileContent;

        public Sims3Init()
        {
            filePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Sims 3\\Game\\Bin\\Sims3.ini";
            fileContent = ReadOptions();
        }

        public string ReadOptions()
        {
            StringBuilder fileContent = new StringBuilder();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
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

            for (int i = 0; i < lines.Length; i++)
            {
                string[] property = lines[i].Split('=');

                if (property[0].Trim() == propertyName)
                {
                    propertyValue = property[1].Trim();
                }
            }

            return propertyValue;
        }
    }
}
