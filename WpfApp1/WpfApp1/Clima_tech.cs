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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    public abstract class Clima_tech
    {
        public int Price { get; set; }
        protected int Count_of_product { get; set; }
        public string Name_of_tech { get; set; }
        protected double Width { get; set; }
        protected double Height { get; set; }
        protected double Depth { get; set; }
        public double Room_area { get; set; }
        protected string Appointment { get; set; }

        public abstract string ImagePath { get; set; }

        public Clima_tech(string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home")
        {
            Name_of_tech = name_of_tech;
            Price = price;
            Count_of_product = count_of_product;
            Width = width;
            Height = height;
            Depth = depth;
            Room_area = room_area;
            Appointment = appointment;
        }

        public void Buy_tech()
        {
            Count_of_product -= 1;
        }

        public bool Is_avaible()
        {
            if (Count_of_product > 0)
            {
                return true;
            }
            return false;
        }

        public string Is_unknown(double param)
        {
            if (param == 0)
            {
                return "unknown";
            }
            return Convert.ToString(param);
        }

        public virtual string RenderResponse()
        {
            return $"Count of product: {Count_of_product}\n" +
                $"\tProduct size:\n" +
                $"Width: {Is_unknown(Width)}\n" +
                $"Height: {Is_unknown(Height)}\n" +
                $"Depth: {Is_unknown(Depth)}\n" +
                $"Room area: {Room_area}\n" +
                $"Appointed for: {Appointment}";
        }

        protected virtual string Model_description()
        {
            return "Default model, nothing special";
        }
    }
}
