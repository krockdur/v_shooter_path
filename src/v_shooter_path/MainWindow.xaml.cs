﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        private int nb_case_along_x;

        Point rectangle_positon;

        Datas datas;

        public MainWindow()
        {
            InitializeComponent();

            
            


            

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
            tb_world_grid_x.Text = nb_case_along_x.ToString();



            //binding datagrid
            Dg_Attributes.DataContext = null;

        }

        private void create_empty_lvl()
        {
            datas = new Datas();

            
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

        }



        private void btn_update_grid_Click(object sender, RoutedEventArgs e)
        {
            nb_case_along_x = int.Parse(tb_world_grid_x.Text);
            int nb_case_along_y = int.Parse(tb_world_grid_y.Text);

            mouse_rectangle.Width = canvas_width / nb_case_along_x;
            mouse_rectangle.Height = mouse_rectangle.Width;

            canvas_board.Height = nb_case_along_y * mouse_rectangle.Height;
        }

        private void canvas_board_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point mouse_position = e.GetPosition(canvas_board);


            int case_en_x = (int)(mouse_position.X / mouse_rectangle.Width);
            int case_en_y = (int)(mouse_position.Y / mouse_rectangle.Height);


            datas.Entities.Add(new Entity(case_en_x, case_en_y, Brushes.Red));

            UpdateCanvas();

        }

        private void UpdateCanvas()
        {
            foreach (Entity entity in datas.Entities)
            { 
                Rectangle tmp_rect = new Rectangle();

                tmp_rect.Width = mouse_rectangle.Width;
                tmp_rect.Height = mouse_rectangle.Height;
                tmp_rect.Fill = entity.RectColor;


                Canvas.SetLeft(tmp_rect, entity.CaseX * tmp_rect.Width);
                Canvas.SetTop(tmp_rect, entity.CaseY * tmp_rect.Height);
                canvas_board.Children.Add(tmp_rect);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            char letter = ((TextBlock)((StackPanel)((ComboBoxItem)Cb_entities.SelectedItem).Content).Children[1]).Text.ToCharArray()[0];

            foreach(Entity e_t in datas.Entities)
            {
                if (e_t.Letter == letter)
                {
                    List<Attribute> tmp_list_attributes;
                    if (e_t.Attributes.Count == 0)
                    {
                        tmp_list_attributes = new List<Attribute>();
                    }
                    else
                    {
                        tmp_list_attributes = e_t.Attributes;
                    }
                    Dg_Attributes.ItemsSource = tmp_list_attributes;
                }
            }
        }
    }
}