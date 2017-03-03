using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace Prototype.Parser
{
    public class TomitaParser
    {
        public static List<string> GetFacts(string script, List<string> keyWords, string text)
        {
            string entity = "";
            List<string> listFacts = new List<string>();
            foreach (string synonym in keyWords)
            {
                entity += "'" + synonym.ToLower() + "'" + " | ";
            }
            script = script.Replace("[ENTITY]", entity.Remove(entity.Length - 3));
            File.WriteAllText(@"Script.cxx", script);
            File.WriteAllText(@"Input.txt", text);
            if (script != "")
            {
                Process Parsing = new Process();
                Parsing.StartInfo.FileName = @"tomitaparser.exe";
                Parsing.StartInfo.Arguments = @"Config.proto";
                Parsing.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Parsing.Start();
                Parsing.WaitForExit();
                if (File.Exists("PrettyOutput.html"))
                {
                    string factsHTML = File.ReadAllText("PrettyOutput.html");
                    foreach (string fact in factsHTML.Substrings("<a href=", "</a>").ToList())
                        listFacts.Add(fact.Remove(0, fact.IndexOf(">") + 1));
                }
                File.Delete("PrettyOutput.html");
                File.Delete("Input.txt");
                return listFacts;
            }
            File.Delete("PrettyOutput.html");
            File.Delete("Input.txt");
            return null;
        }        
    }
}
