using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Models
{
    public class Serialize : ISerialize
    {
        public List<SchoolPerformance> Deserializable(string pathToFile)
        {
            JsonSerializer serializer = new JsonSerializer();
            List<SchoolPerformance> performances = new List<SchoolPerformance>();
            using (StreamReader sr = new StreamReader(pathToFile))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                performances = serializer.Deserialize<List<SchoolPerformance>>(reader);
            }

            return performances;
        }

        public void Serializable(List<SchoolPerformance> performances)
        {
            JsonSerializer serializer = new JsonSerializer();
            string nameFile = Guid.NewGuid().ToString();
            using (StreamWriter sw = new StreamWriter(".\\Export\\" + nameFile))
            {
                JsonWriter jsonWriter = new JsonTextWriter(sw);
                    serializer.Serialize(jsonWriter, performances);
            }

            if (MessageBox.Show($"Выгрузка в файл {nameFile} завершена.\nОткрыть папку выгрузки?", "Выгрузка завершена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(".\\Export\\");
            }
        }
    }
}
