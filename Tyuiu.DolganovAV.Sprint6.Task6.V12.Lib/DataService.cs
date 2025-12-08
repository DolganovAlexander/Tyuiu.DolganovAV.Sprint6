using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolganovAV.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains('w'))
                        {
                            if (res.Length > 0) res += " ";
                            res += word;
                        }
                    }    
                }
            }
            return res;
        }
    }
}
