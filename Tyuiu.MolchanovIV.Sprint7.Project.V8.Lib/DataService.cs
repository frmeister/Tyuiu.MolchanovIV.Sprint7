namespace Tyuiu.MolchanovIV.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public static string[,] getInputCarInto(string path)
        {
            // Кол-во строк в блоке автомобилей
            int count = 0;
            string[,] output = new string[count, 7];

            using (StreamReader reader = new StreamReader(path))
            {
                string line, curFeature = "", curLine = "";
                int curColumn = 0;

                while(((line = reader.ReadLine()) != null) && ((line = reader.ReadLine()) != "Водители:"))
                {
                    curLine = line;
                    for (int i = 0; i < curLine.Length; i++)
                    {
                        if (curLine[i] == ':')
                        {
                            i++;
                            curFeature += curLine[i];
                        }
                        if (curLine[i] == ',')
                        {
                            output[count, curColumn] = curFeature;
                            curColumn++;
                            curFeature = "";
                        }
                    }
                    count++;
                }
            }

            return output;
        }

        public static string[,] getInputDriverInto(string path)
        {
            // Кол-во строк в блоке водителей
            int count = 0;
            string[,] output = new string[count, 7];

            using (StreamReader reader = new StreamReader(path))
            {
                string line, curLine = "", curFeature = "";
                bool isThisLine = false;
                int curColumn = 0;

                while (((line = reader.ReadLine()) != null) && ((line = reader.ReadLine()) != "Транспортная карта:"))
                {
                    curLine = line;

                    if(isThisLine)
                    {
                        for (int i = 0; i < curLine.Length; i++)
                        {
                            if (curLine[i] == ':')
                            {
                                i++;
                                curFeature += curLine[i];
                            }
                            if (curLine[i] == ',')
                            {
                                output[count, curColumn] = curFeature;
                                curColumn++;
                                curFeature = "";
                            }
                        }
                    }

                    if (line == "Водители:")
                    {
                        count = 0;
                        isThisLine = true;
                    }
                    count++;
                }
            }

            

            //

            return output;
        }

        public static string[,] getInputPointInto(string path)
        {
            // Кол-во строк в блоке транспортная карта
            int count = 0;
            string[,] output = new string[count, 7];

            using (StreamReader reader = new StreamReader(path))
            {
                string line, curLine = "", curFeature = "";
                bool isThisLine = false;
                int curColumn = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    curLine = line;

                    if (isThisLine)
                    {
                        for (int i = 0; i < curLine.Length; i++)
                        {
                            if (curLine[i] == ':')
                            {
                                i++;
                                curFeature += curLine[i];
                            }
                            if (curLine[i] == ',')
                            {
                                output[count, curColumn] = curFeature;
                                curColumn++;
                                curFeature = "";
                            }
                        }
                    }

                    if (line == "Транспортная карта:")
                    {
                        isThisLine = true;
                        count = 0;
                    }
                    count++;
                }
            }

            

            //

            return output;
        }
    }
}
