using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour NewLvlWindow.xaml
    /// </summary>
    public partial class NewLvlWindow : Window
    {

        private int nb_entity_x;
        private int nb_entity_y;
        private bool status;

        public NewLvlWindow()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {

            bool success_x = int.TryParse(tb_world_grid_x.Text, out nb_entity_x);
            bool success_y = int.TryParse(tb_world_grid_y.Text, out nb_entity_y);

            if (success_x && success_y)
            {
                status = true;
                this.Close();
            }
            else
            {
                status = false;
                MessageBox.Show("bad entries");
            }
        }

        public bool OkToCreate { get { return status; } }
        public int WorldX { get { return nb_entity_x; } }
        public int WorldY { get { return nb_entity_y; } }


    }
}
