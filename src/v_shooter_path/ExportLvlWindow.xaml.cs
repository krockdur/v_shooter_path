using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace v_shooter_path
{
    /// <summary>
    /// Logique d'interaction pour ExportLvlWindow.xaml
    /// </summary>
    public partial class ExportLvlWindow : Window
    {
        private Level _level;
        private string _format = "json";
        private string _lvl_name = "default";
        public ExportLvlWindow(Level level)
        {
            _level = level;

            InitializeComponent();


            _level.Filename = _lvl_name;

        }

        private void Rb_Json_Checked(object sender, RoutedEventArgs e)
        {
            _format = "json";
        }

        private void Rb_Ascii_Checked(object sender, RoutedEventArgs e)
        {
            _format = "ascii";
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
                
            if (_format == "json")
            {
                saveFileDialog.Filter = "JSON file |*.json";
                saveFileDialog.FileName = _lvl_name + ".json";

                if (saveFileDialog.ShowDialog() == true)
                {
                    string savedJson = JsonConvert.SerializeObject(_level);

                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(savedJson);
                    }
                }

            }

            if (_format == "ascii")
            {
                saveFileDialog.Filter = "TXT file |*.txt";
            }
        }

        private void Tb_LvlName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tb_LvlName.Text != "")
            {
                _lvl_name = Tb_LvlName.Text;
            }
            else
            {
                _lvl_name = "default";
            }

            _level.Filename = _lvl_name;
        }
    }
}
