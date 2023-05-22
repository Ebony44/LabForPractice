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
        public enum ELanguageSetting
        {
            ENGLISH = 0,
            KOREAN,
            MAX,
        }

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

        public static Dictionary<string, Dictionary<string, string>> ReadDataWithEnum(string[] dataLines, int dataCount)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            List<Dictionary<string, string>> m_dicList = new List<Dictionary<string, string>>();
            Dictionary<string, Dictionary<string, string>> m_dic = new Dictionary<string, Dictionary<string, string>>(dataCount);

            for (int i = 0; i < (int)ELanguageSetting.MAX; i++)
            {

                // m_dicList.Add(new Dictionary<string, string>());
                m_dic.Add(((ELanguageSetting)i).ToString().ToLower(), new Dictionary<string, string>(16));
            }

            // foreach (var line in dataLines)
            List<string> listOrder = new List<string>();
            for (int i = 0; i < dataLines.Length; i++)
            {
                string line = dataLines[i];
                string[] strValues = CsvParser.Split(line);
                if (i == 0)
                {
                    for (int k = 0; k < strValues.Length; k++)
                    {
                        var currentKey = strValues[k].ToLower();
                        if (m_dic.ContainsKey(currentKey))
                        {
                            listOrder.Add(currentKey);
                        }
                    }
                }

                if (strValues.Length != (int)ELanguageSetting.MAX)
                {

                }

                if (strValues.Length != dataCount)
                {
                    // CustomPlayerMod.log.LogInfo("[ReadData] Exist Null Data!! key : " + strValues[0]);
                    Console.WriteLine("[ReadData] Exist Null Data!! key : " + strValues[0]);
                }
                
                else
                {
                    // if(datal)
                    // for (int i = 0; i < dataCount - 1; i++)
                    for (int k = 0; k < (int)ELanguageSetting.MAX; k++)
                    {
                        m_dic[listOrder[k]].Add(
                            strValues[0].TrimStart(' ', '"'), strValues[k + 1].TrimStart(' ', '"').TrimEnd(' ', '"').Replace("\n", "").Replace("\r", "")
                            );
                        // if()

                        //if (!m_dicList[i].ContainsKey(strValues[0]))
                        //    m_dicList[i].Add(strValues[0].TrimStart(' ', '"'), strValues[i + 1].TrimStart(' ', '"').TrimEnd(' ', '"').Replace("\n", "").Replace("\r", ""));
                        //else
                        //{
                        //    CustomPlayerMod.log.LogInfo($"[ReadData] Exist Same Key. key Name : {strValues[i]} / num : {i}");
                        //    // Console.WriteLine($"[ReadData] Exist Same Key. key Name : {strValues[i]} / num : {i}");
                        //}

                    }
                }
            }
            // Console.WriteLine($"[ReadData] Text Count : {m_dic[0].Count}");
            // Debug.Log($"[ReadData] Text Count : {m_dicList[0].Count}");
            // return m_dicList;
            return m_dic;

        }



        public static void TempTest(string paramString)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            // string[] dataLines = Regex.Split(ZUC.Uni2ZG(csv.text), splitData);
            string[] dataLines = Regex.Split(paramString, splitData);
            int dataCount = CsvParser.Split(dataLines[0]).Length;

            List<Dictionary<string, string>> m_dicList = CSVReader.ReadData(dataLines, dataCount);

            var m_dic = CSVReader.ReadDataWithEnum(dataLines, dataCount);

        }

        public static void GetStringLinesFromFile()
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

        public static string GetStringFromFile(string filePath)
        {
            // var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\TempTestCSV.csv";
            // var tempPath = string.Empty;
            // var tempGetString = File.ReadAllLines(filePath);
            string readContents;
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return readContents;
        }


    }
}
