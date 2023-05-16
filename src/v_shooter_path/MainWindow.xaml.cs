using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace v_shooter_path
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle mouse_rectangle;
        private const int canvas_width = 900;
        private const int canvas_heigth = 600;

        private char letter_selected;

        private int nb_case_along_x;

        Point rectangle_positon;

        Datas datas;

        Level lvl;

        public MainWindow()
        {
            InitializeComponent();

            
            // create empty data configuration
            datas = new Datas();
            

            mouse_rectangle = new Rectangle();
            mouse_rectangle.Width = 50;
            mouse_rectangle.Height = 50;
            mouse_rectangle.Fill = Brushes.Red;

            canvas_board.Children.Add(mouse_rectangle);

            rectangle_positon = new Point(0, 0);

            //set up
            nb_case_along_x = 10;
            mouse_rectangle.Width = canvas_width / nb_case_along_x;
            mouse_rectangle.Height = mouse_rectangle.Width;




            //
            Cb_entities_selection.SelectedIndex = 0;

            // create empty lvl
            initialize_new_level(10, 50);
            

        }

        private void initialize_new_level(int nb_entities_x, int nb_entities_y)
        {
            canvas_board.Children.Clear();
            canvas_board.Children.Add(mouse_rectangle);

            lvl = new Level();
            lvl.NbEntitiesInX = nb_entities_x;
            lvl.NbEntitiesInY = nb_entities_y;
            lvl.ListEntities = new List<Entity>();

            mouse_rectangle.Width = canvas_width / nb_entities_x;
            mouse_rectangle.Height = mouse_rectangle.Width;

            canvas_board.Height = nb_entities_y * mouse_rectangle.Height;

            UpdateCanvas();

            TbInfoLvlWidth.Text = nb_entities_x.ToString();
            TbInfoLvlHeight.Text = nb_entities_y.ToString();

        }


        private void canvas_board_MouseMove(object sender, MouseEventArgs e)
        {

            Point mouse_position = e.GetPosition(canvas_board);


            int case_en_x = (int)(mouse_position.X / mouse_rectangle.Width);
            int case_en_y = (int)(mouse_position.Y / mouse_rectangle.Height);

            double coord_x = case_en_x * mouse_rectangle.Width;
            double coord_y = case_en_y * mouse_rectangle.Height;

            Canvas.SetLeft(mouse_rectangle, coord_x);
            Canvas.SetTop(mouse_rectangle, coord_y);

            TbInfoMousePositionX.Text = coord_x.ToString();
            TbInfoMousePositionY.Text = coord_y.ToString();

        }


        private void canvas_board_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point mouse_position = e.GetPosition(canvas_board);


            int case_en_x = (int)(mouse_position.X / mouse_rectangle.Width);
            int case_en_y = (int)(mouse_position.Y / mouse_rectangle.Height);

            bool case_already_affect = false;
            foreach (Entity ent in lvl.ListEntities)
            {
                if (ent.CaseX == case_en_x && ent.CaseY == case_en_y)
                {
                    // position already added - just replace letter
                    ent.Letter = letter_selected;
                    case_already_affect = true;
                    break;
                }
            }

            // if position doesn't exist
            if (!case_already_affect)
            {
                Entity tmp_entity = new Entity { CaseX = case_en_x, CaseY = case_en_y, Letter = letter_selected };
                lvl.ListEntities.Add(tmp_entity);
            }


            UpdateCanvas();

        }
        private void UpdateCanvas()
        {
            
            foreach (Entity entity in lvl.ListEntities)
            { 

                Rectangle tmp_rect = new Rectangle();

                tmp_rect.Width = mouse_rectangle.Width;
                tmp_rect.Height = mouse_rectangle.Height;
                tmp_rect.Fill = datas.GetBrushFromLetter(entity.Letter);


                Canvas.SetLeft(tmp_rect, entity.CaseX * tmp_rect.Width);
                Canvas.SetTop(tmp_rect, entity.CaseY * tmp_rect.Height);
                canvas_board.Children.Add(tmp_rect);
            }
            


        }

        private void Cb_entities_config_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dg_Attributes.ItemsSource = null;

            char letter = ((TextBlock)((StackPanel)((ComboBoxItem)Cb_entities_config.SelectedItem).Content).Children[1]).Text.ToCharArray()[0];

            foreach(TypeEntity typeEntity in datas.ListTypeEntities)
            {
                if (typeEntity.Letter == letter)
                {
                    Dg_Attributes.ItemsSource = typeEntity.ListAttributes;
                }
            }
        }

        private void Cb_entities_selection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            letter_selected = ((TextBlock)((StackPanel)((ComboBoxItem)Cb_entities_selection.SelectedItem).Content).Children[1]).Text.ToCharArray()[0];
            Rectangle rect = ((Rectangle)((StackPanel)((ComboBoxItem)Cb_entities_selection.SelectedItem).Content).Children[0]);
            SolidColorBrush rectBrush = (SolidColorBrush)rect.Fill;
            mouse_rectangle.Fill = rectBrush;

        }

        private void Btn_NewSet_Click(object sender, RoutedEventArgs e)
        {
            datas.ListTypeEntities = null;
            datas = new Datas();

            Cb_entities_config.SelectedIndex = 0;
        }

        private void Btn_OpenSet_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON file |*.json";

            if (openFileDialog.ShowDialog() == true)
            {
                datas = Datas.LoadFromFile(openFileDialog.FileName);
                Cb_entities_config.SelectedIndex = 0;
            }           
                
        }
        private void Btn_SaveSet_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON file |*.json";


            if (saveFileDialog.ShowDialog() == true)
            {
                Datas.SaveToFile(datas, saveFileDialog.FileName);
            }
        }

        private void Btn_NewLvl_Click(object sender, RoutedEventArgs e)
        {
            NewLvlWindow newLvlWindow = new NewLvlWindow();
            newLvlWindow.Owner = this;
            newLvlWindow.Closed += NewLvlWindow_Closed;
            newLvlWindow.ShowDialog();
        }

        private void NewLvlWindow_Closed(object? sender, EventArgs e)
        {
            NewLvlWindow newLvlWindow = (NewLvlWindow)sender;
            if (newLvlWindow.OkToCreate)
            {
                initialize_new_level(newLvlWindow.WorldX, newLvlWindow.WorldY);
            }
        }

        private void Btn_OpenLvl_Click(object sender, RoutedEventArgs e)
        {

        }



        private void Btn_SaveLvl_Click(object sender, RoutedEventArgs e)
        {
            ExportLvlWindow exportLvlWindow = new ExportLvlWindow(lvl, datas);
            exportLvlWindow.Owner = this;
            exportLvlWindow.ShowDialog();
        }
    }
}
