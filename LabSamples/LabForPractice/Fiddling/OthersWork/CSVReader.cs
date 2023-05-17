using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling.OthersWork
{
    public static class CSVReader
    {
        const string splitData = @"\n"; // enter
        public static List<Dictionary<string, string>> ReadData(string[] dataLines, int dataCount)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            List<Dictionary<string, string>> m_dicList = new List<Dictionary<string, string>>();

            for (int i = 0; i < dataCount; i++)
                m_dicList.Add(new Dictionary<string, string>());

            foreach (var line in dataLines)
            {
                string[] strValues = CsvParser.Split(line);

                if (strValues.Length != dataCount)
                {
                    Console.WriteLine("[ReadData] Exist Null Data!! key : " + strValues[0]);
                }
                    //Debug.LogError("[ReadData] Exist Null Data!! key : " + strValues[0]);
                else
                {
                    for (int i = 0; i < dataCount - 1; i++)
                    {
                        if (!m_dicList[i].ContainsKey(strValues[0]))
                            m_dicList[i].Add(strValues[0].TrimStart(' ', '"'), strValues[i + 1].TrimStart(' ', '"').TrimEnd(' ', '"').Replace("\n", "").Replace("\r", ""));
                        else
                        {
                            Console.WriteLine($"[ReadData] Exist Same Key. key Name : {strValues[i]} / num : {i}");
                        }
                            // Debug.LogError($"[ReadData] Exist Same Key. key Name : {strValues[i]} / num : {i}");
                    }
                }
            }
            Console.WriteLine($"[ReadData] Text Count : {m_dicList[0].Count}");
            // Debug.Log($"[ReadData] Text Count : {m_dicList[0].Count}");
            return m_dicList;
        }

        public static void TempTest(string paramString)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            // string[] dataLines = Regex.Split(ZUC.Uni2ZG(csv.text), splitData);
            string[] dataLines = Regex.Split(paramString, splitData);
            int dataCount = CsvParser.Split(dataLines[0]).Length;

            List<Dictionary<string, string>> m_dicList = CSVReader.ReadData(dataLines, dataCount);
        }

        public static void GetStringFromFile()
        {
            // D:\Lab\Repo\LabSamples\LabForPractice_CSV_files
            var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\TempTestCSV.csv";
            var tempGetString = File.ReadAllLines(tempPath);

            //string savedString = string.Empty;
            //using (StreamReader file = new StreamReader(tempPath))
            //{
            //    int counter = 0;
            //    string ln;
                
            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        // ln += file.ReadLine();
            //        savedString += ln+"\n";
            //        // Console.WriteLine(ln);
            //        counter++;
            //    }
            //    file.Close();
            //    // Console.WriteLine($ "File has {counter} lines.");
            //}
        }

    }
}
