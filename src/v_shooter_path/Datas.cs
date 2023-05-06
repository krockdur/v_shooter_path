using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Newtonsoft.Json;

namespace v_shooter_path
{
    internal class Datas
    {
        public List<TypeEntity> ListTypeEntities { get; set; }

        public Datas()
        {
            ListTypeEntities = new List<TypeEntity>();
            create_empty_dataset();
        }

        private void create_empty_dataset()
        {
            ListTypeEntities.Add(new TypeEntity('A', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f2f0e5"))));
            ListTypeEntities.Add(new TypeEntity('B', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b8b5b9"))));
            ListTypeEntities.Add(new TypeEntity('C', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#868188"))));
            ListTypeEntities.Add(new TypeEntity('D', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#646365"))));
            ListTypeEntities.Add(new TypeEntity('E', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#45444f"))));
            ListTypeEntities.Add(new TypeEntity('F', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3a3858"))));
            ListTypeEntities.Add(new TypeEntity('G', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#212123"))));
            ListTypeEntities.Add(new TypeEntity('H', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#352b42"))));
            ListTypeEntities.Add(new TypeEntity('I', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#43436a"))));
            ListTypeEntities.Add(new TypeEntity('J', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4b80ca"))));
            ListTypeEntities.Add(new TypeEntity('K', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#68c2d3"))));
            ListTypeEntities.Add(new TypeEntity('L', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a2dcc7"))));
            ListTypeEntities.Add(new TypeEntity('M', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ede19e"))));
            ListTypeEntities.Add(new TypeEntity('N', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#d3a068"))));
            ListTypeEntities.Add(new TypeEntity('O', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b45252"))));
            ListTypeEntities.Add(new TypeEntity('P', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6a536e"))));
            ListTypeEntities.Add(new TypeEntity('Q', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4b4158"))));
            ListTypeEntities.Add(new TypeEntity('R', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#80493a"))));
            ListTypeEntities.Add(new TypeEntity('S', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a77b5b"))));
            ListTypeEntities.Add(new TypeEntity('T', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e5ceb4"))));
            ListTypeEntities.Add(new TypeEntity('U', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#c2d368"))));
            ListTypeEntities.Add(new TypeEntity('V', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8ab060"))));
            ListTypeEntities.Add(new TypeEntity('W', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#567b79"))));
            ListTypeEntities.Add(new TypeEntity('X', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4e584a"))));
            ListTypeEntities.Add(new TypeEntity('Y', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7b7243"))));
            ListTypeEntities.Add(new TypeEntity('Z', new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b2b47e"))));
        }

        public Brush GetBrushFromLetter(char letter)
        {
            Brush brush_to_ret = Brushes.White;
            foreach (TypeEntity tp in ListTypeEntities)
            {
                if(tp.Letter == letter)
                {
                    brush_to_ret = tp.Color;
                    break;
                }
            }
            return brush_to_ret;
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
