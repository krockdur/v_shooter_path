﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace v_shooter_path
{
    internal class Datas
    {
        public List<TypeEntity>? ListTypeEntities { get; set; }

        public Datas()
        {
            ListTypeEntities = new List<TypeEntity>();
        }

        /**
         * Load Data object from file
         */
        public static Datas LoadFromFile(string file)
        {
            string dataLoaded = String.Empty;
            using (StreamReader sr = new StreamReader(file))
            {
                dataLoaded = sr.ReadToEnd();

            }

            Datas? tmpDatas = JsonConvert.DeserializeObject<Datas>(dataLoaded);


            return tmpDatas;
        }

        /**
         * Save Datas to file.json
         */
        public static void SaveToFile(Datas datas, string file)
        {
            string savedJson = JsonConvert.SerializeObject(datas);
            //backup config.json
            if (File.Exists(file))
                File.Copy(file, file + ".bak", true);
            //Sauvegarde new config
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.Write(savedJson);
            }
        }
    }
}
