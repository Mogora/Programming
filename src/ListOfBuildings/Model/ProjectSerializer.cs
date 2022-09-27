using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using Newtonsoft.Json;
using ListOfBuildings.Model;
using System.IO;

namespace ListOfBuildings.Model
{
    public static class ProjectSerializer
    {
       static ProjectSerializer()
       {
            Path = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/BuildingssApp/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
       }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="buildings"> Список, который нужно сериализовать. </param>
        public static void Serialize (List<Building> buildings)
        {
            using (StreamWriter writer = new StreamWriter (Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(buildings));
            }
        }

        public static List<Building> Deserialize()
        {
            var buildings = new List<Building>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    buildings = JsonConvert.DeserializeObject<List<Building>>(reader.ReadToEnd());
                }

                if (buildings == null)
                {
                    buildings = new List<Building>();
                }
            }
            catch
            {
                return buildings;
            }
            return buildings;
        }

        /// <summary>
        /// Возвращает и задает путь, где будут сериализоваться данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файля.
        /// </summary>
        public static string FileName { get; set; }
    }
}
