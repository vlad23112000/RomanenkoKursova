using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Air_condition : Clima_tech
    {
        public override string ImagePath { get; set; }

        protected string Type { get; set; }
        protected string Compressor_type { get; set; }

        public Air_condition(
                     string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home",
                     string type = "split system",
                     string compressor_type = "common",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg")
            : base(
                name_of_tech,
                price,
                count_of_product,
                width,
                height,
                depth,
                room_area,
                appointment)
        {
            Type = type;
            Compressor_type = compressor_type;
            ImagePath = imagePath;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                $"Type: {Type}\n" +
                $"Compressor_type: {Compressor_type}\n" +
                $"Air conditioners often use a fan to distribute\n" +
                $"the conditioned air to an enclosed space such as\n" +
                $"a building or a car to improve thermal comfort\n" +
                $"and indoor air quality. The cooling is typically\n" +
                $"achieved through a refrigeration cycle,\n" +
                $"but sometimes evaporation or free cooling is used.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
