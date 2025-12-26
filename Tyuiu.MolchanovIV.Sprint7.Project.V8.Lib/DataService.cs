namespace Tyuiu.MolchanovIV.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public string[,] getInputCarInto(string path)
        {
            bool isThisLine = true;

            var rows = new List<string[]>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (!isThisLine)
                        continue;

                    if (line == "Водители:")
                    {
                        isThisLine = false;

                        continue;
                    }

                    if (line.EndsWith(":"))
                        continue;

                    string[] parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < parts.Length; i++)
                    {
                        int idx = parts[i].IndexOf(':');
                        if (idx == -1)
                            continue;

                        parts[i] = parts[i].Substring(idx + 1).Trim();
                    }

                    rows.Add(parts);

                }
            }

            string[,] output = new string[rows.Count, rows[0].Length];
            for (int i = 0; i < rows.Count; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    output[i, j] = rows[i][j];

            return output;
        }


        public string[,] getInputDriverInto(string path)
        {
            bool isThisLine = false;

            var rows = new List<string[]>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "Водители:")
                    {
                        isThisLine = true;

                        continue;
                    }

                    if (line == "Транспортная карта:")
                    {
                        isThisLine = false;

                        continue;
                    }

                    if (!isThisLine)
                        continue;

                    if (line.EndsWith(":"))
                        continue;

                    string[] parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < parts.Length; i++)
                    {
                        int idx = parts[i].IndexOf(':');
                        if (idx == -1)
                            continue;

                        parts[i] = parts[i].Substring(idx + 1).Trim();
                    }

                    rows.Add(parts);

                }
            }

            string[,] output = new string[rows.Count, rows[0].Length];
            for (int i = 0; i < rows.Count; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    output[i, j] = rows[i][j];

            return output;
        }

        public string[,] getInputPointInto(string path)
        {
            bool isThisLine = false;

            var rows = new List<string[]>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == "Транспортная карта:")
                    {
                        isThisLine = true;

                        continue;
                    }

                    if (!isThisLine)
                        continue;

                    if (line.EndsWith(":"))
                        continue;

                    string[] parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < parts.Length; i++)
                    {
                        int idx = parts[i].IndexOf(':');
                        if (idx == -1)
                            continue;

                        parts[i] = parts[i].Substring(idx + 1).Trim();
                    }

                    rows.Add(parts);

                }
            }

            string[,] output = new string[rows.Count, rows[0].Length];
            for (int i = 0; i < rows.Count; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    output[i, j] = rows[i][j];

            return output;
        }
    }
}
