using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling
{
    public enum EItemType
    {
        None = 0,
        Milk = 1,
        LoliMilk = 3,
        HumanMilk = 4,
        ElfMilk = 5,
        DwarfMilk = 6,
        FurryMilk = 7,
        SmallFurryMilk = 8,
        DragonianMilk = 9,
        BodyFluid = 10,
        VenerealDiseaseDna = 11,
        HumanPheromone = 17,
        ElfManaEngine = 19,
        DawrfHeart = 21,
        InuMammaryGlandDna = 22,
        NecoOvarianDna = 23,
        UsagiWombDna = 24,
        HitsujiHorn = 25,
        DragonTailMeat = 26,
        GoblinSemen = 45,
        OrcHeart = 48,
        WerewolfTail = 50,
        TattooRemovalInjection = 55,
        HealthRecoveryInjection = 56,
        MammaryGlandRecoveryInjection = 59,
        VenerealDiseaseRecoveryInjection = 60,
        OvumRecoveryInjection = 61,
        MinotaurSkin = 106,
        Item_Gold = 107,
        Item_AchievementPoint = 111,
        Item_HumanDna = 112,
        Item_ElfDna = 113,
        Item_DwarfDna = 114,
        Item_NekoDna = 115,
        Item_InuDna = 116,
        Item_UsagiDna = 117,
        Item_HitsujiDna = 118,
        Item_DragonianDna = 119,
        Item_GoblinDna = 120,
        Item_OrcDna = 121,
        Item_WerewolfDna = 122,
        Item_MinotaurDna = 123,
        Item_SalamanderDna = 124,
        Item_OriginDna = 125,
        Item_FertilityMedication = 126,
        Item_Aphrodisiac = 127,
        Item_ViOgra = 128,
        Item_Sensitivity3000x = 129,
        Item_Washer = 130,
        Item_SalamanderScalePiece = 131,
        Item_Condom = 132,
        Item_LoveGel = 133,
        Item_CosmeticPill = 134,
        Item_MonsterCosmeticPill = 135,
        Item_SlaveCosmeticPill = 136,
        Item_TraitUpgradePill = 137,
        Item_TentacleEgg = 138
    }
    public enum EItemTypeExtra
    {

        // None = EItemType.Item_TentacleEgg + 1,
        None = EItemType.Item_TentacleEgg + 2000,

        Nullifier_Demonic,
        Nullifier_Sacred,
        Nullifier_Elemental,
        Nullifier_Eternal,
        Nullifier_Magical,
        Nullifier_Feral,

        EItemTypeExtend_MAX,

    }

    public class SellingItemInfo
    {
        // key for item type, which
        // EItemType
        // EItemTypeExtend
        // public int itemType;
        public int itemType; // cant be duplicated
        public List<EPriceType> possibleSellType = new List<EPriceType>(4);
        public Dictionary<EPriceType, int> minPriceRangeDic = new Dictionary<EPriceType, int>(4);
        public Dictionary<EPriceType, int> maxPriceRangeDic = new Dictionary<EPriceType, int>(4);
        public Dictionary<EPriceType, int> minQuantityRangeDic = new Dictionary<EPriceType, int>(4);
        public Dictionary<EPriceType, int> maxQuantityRangeDic = new Dictionary<EPriceType, int>(4);

        public float priceModifier;
        public float quantityModifier;

    }
    public enum ESellingItemCSVOrder
    {
        NONE = 0,
        MinPriceRange,
        MaxPriceRange,
        MinQuantityRange,
        MaxQuantityRange,

    }
    public enum EPriceType
    {
        NONE = 0,
        GOLD,
        SOUL,
        MANA,
    }
    // use csv reader
    public static class TestItemSetupForModding
    {

        public static Dictionary<int, SellingItemInfo> sellingItemInfoDic = new Dictionary<int, SellingItemInfo>(64);
        const string splitData = @"\n"; // enter

        
        //public static string GetStringFromFile(string filePath)
        //{
        //    // var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\TempTestCSV.csv";
        //    // var tempPath = string.Empty;
        //    // var tempGetString = File.ReadAllLines(filePath);
        //    string readContents;
        //    using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
        //    {
        //        readContents = streamReader.ReadToEnd();
        //    }
        //    return readContents;
        //}

        public static void StringSplitAndInsertToCollections(string paramString)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            // string[] dataLines = Regex.Split(ZUC.Uni2ZG(csv.text), splitData);
            string[] dataLines = Regex.Split(paramString, splitData);
            for (int i = 0; i < dataLines.Length; i++)
            {
                dataLines[i] = dataLines[i].Replace("\r", string.Empty);
            }
            int dataCount = CsvParser.Split(dataLines[0]).Length;

            // List<Dictionary<string, string>> m_dicList = CSVReader.ReadData(dataLines, dataCount);

            // var m_dic = CSVReader.ReadDataWithEnum(dataLines, dataCount);
            ReadDataWithEnum(dataLines, dataCount);

        }
        public static void ReadDataWithEnum(string[] dataLines, int dataCount)
        {
            Regex CsvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            var currentDataCount = System.Enum.GetValues(typeof(ESellingItemCSVOrder)).Length;
            Dictionary<int, string> keyOrdersDic = new Dictionary<int, string>(8);
            for (int i = 0; i < dataLines.Length; i++)
            {
                

                string line = dataLines[i];
                // line = line.Replace("\r", string.Empty).Replace("\n", string.Empty);
                string[] strValues = CsvParser.Split(line);
                bool bHasEmptyInfoIncluded = false;
                
                for (int k = 0; k < strValues.Length; k++)
                {
                    if (i == 0)
                    {
                        // 0.1 key orders for ranges
                        var tempString = line;
                        var tempEnumType = GetEnumFromString<ESellingItemCSVOrder>(strValues[k]);
                        if ((int)tempEnumType != 0)
                        {
                            // keyOrdersDic.Add(tempEnumType.ToString().ToLower(), k);
                            keyOrdersDic.Add(k, tempEnumType.ToString().ToLower());
                        }

                    }
                    if (strValues[k].Equals(string.Empty))
                    {
                        bHasEmptyInfoIncluded = true;
                        continue;
                    }
                }
                if(bHasEmptyInfoIncluded == true)
                {
                    // 0.2 pass if any information is missing
                    continue;
                }
                else // all information are there
                {
                    // 1.1. check item type
                    // var startIndex = strValues[0].IndexOf('_');
                    var startIndex = 0;
                    var lengthOfKey = strValues[0].Length;
                    var endIndex = strValues[0].IndexOf('_');
                    if (startIndex == -1
                        || endIndex == -1)
                    {
                        // key value has no type separator
                        continue;
                    }
                    var currentItemTypeString = strValues[0].Substring(startIndex, endIndex);

                    int tempItemType = (int)GetEnumFromString<EItemTypeExtra>(currentItemTypeString);
                    if ((int)tempItemType == 0)
                    {
                        tempItemType = (int)(GetEnumFromString<EItemType>(currentItemTypeString));
                    }


                    // 1.2 check key for item selling type
                    // var currentType = strValues[0].IndexOf('_');
                    startIndex = strValues[0].IndexOf('_');
                    endIndex = strValues[0].IndexOf('_', startIndex);
                    var currentSellTypeString = strValues[0].Substring(startIndex, lengthOfKey - startIndex);
                    // if strValues[0] is OvumRecoveryInjection_GOLD
                    // currentString is _GOLD
                    currentSellTypeString = currentSellTypeString.Replace("_", string.Empty);
                    // foreach (var item in System.Enum.GetNames(typeof(EPriceType)))
                    //foreach (var item in System.Enum.GetValues(typeof(EPriceType)))
                    //{
                    //    var currentItemString = item.ToString();
                    //    var currentItemEnum = (EPriceType)item;
                    //    if(currentItemString.Equals(currentSellTypeString))
                    //    {
                    //        //var temp = System.Enum.GetValues(typeof(EPriceType));
                    //        // 2. new SellingItemInfo
                    //        SellingItemInfo currentSellInfo = new SellingItemInfo();

                    //    }
                    //}
                    // 2. new SellingItemInfo
                    var tempSellType = GetEnumFromString<EPriceType>(currentSellTypeString);
                    SellingItemInfo currentSellInfo = new SellingItemInfo();
                    currentSellInfo.itemType = tempItemType;
                    if (sellingItemInfoDic.ContainsKey(currentSellInfo.itemType))
                    {
                        sellingItemInfoDic[currentSellInfo.itemType].possibleSellType.Add(tempSellType);
                    }
                    else
                    {
                        currentSellInfo.possibleSellType.Add(tempSellType);
                    }

                    // 3. range of selling item
                    // currentSellInfo.minPriceRangeDic
                    for (int k = 0; k < strValues.Length; k++)
                    {
                        // var currentString = strValues[k].ToLower();
                        string currentString = string.Empty;
                        if (keyOrdersDic.ContainsKey(k))
                        {
                            currentString = keyOrdersDic[k].ToLower();
                            var currentEnum = GetEnumFromString<ESellingItemCSVOrder>(currentString, true);
                            Dictionary<EPriceType, int> currentDic = null;
                            if (sellingItemInfoDic.ContainsKey(currentSellInfo.itemType))
                            {
                                currentDic = GetSellingInfoDicWithEnum(currentEnum, sellingItemInfoDic[currentSellInfo.itemType]);
                            }
                            else
                            {
                                currentDic = GetSellingInfoDicWithEnum(currentEnum, currentSellInfo);
                            }
                            
                            
                            int currentIntValue = 0;
                            if (int.TryParse(strValues[k], out currentIntValue))
                            {
                                currentDic.Add(tempSellType, currentIntValue);
                            }
                            else
                            {
                                // show error log info
                            }

                        }
                    }

                    // 4. if it's done, add to member dic
                    if (sellingItemInfoDic.ContainsKey(currentSellInfo.itemType) == false)
                    {
                        sellingItemInfoDic.Add(currentSellInfo.itemType, currentSellInfo);
                    }



                }

            }


            var tempStoredDic = sellingItemInfoDic;
        }

        public static TEnumValue GetEnumFromString<TEnumValue>(string enumName, bool bIsToLower = false)
        {
            TEnumValue result = default(TEnumValue);
            foreach (var item in System.Enum.GetValues(typeof(TEnumValue)))
            {
                var currentItemString = item.ToString();
                if(bIsToLower)
                {
                    currentItemString = currentItemString.ToLower();
                }
                var currentItemEnum = (TEnumValue)item;
                if (currentItemString.Equals(enumName))
                {
                    result = currentItemEnum;
                }
            }
            return result;
        }

        public static Dictionary<EPriceType, int> GetSellingInfoDicWithEnum(ESellingItemCSVOrder paramEnum, SellingItemInfo paramInfo)
        {
            Dictionary<EPriceType, int> result = null;
            switch (paramEnum)
            {
                case ESellingItemCSVOrder.NONE:
                    break;
                case ESellingItemCSVOrder.MinPriceRange:
                    result = paramInfo.minPriceRangeDic;
                    break;
                case ESellingItemCSVOrder.MaxPriceRange:
                    result = paramInfo.maxPriceRangeDic;
                    break;
                case ESellingItemCSVOrder.MinQuantityRange:
                    result = paramInfo.minQuantityRangeDic;
                    break;
                case ESellingItemCSVOrder.MaxQuantityRange:
                    result = paramInfo.maxQuantityRangeDic;
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
