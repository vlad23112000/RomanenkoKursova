using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Air_cleaner : Clima_tech
    {
        public override string ImagePath { get; set; }

        protected string Type { get; set; }
        protected string Cleaner_type { get; set; }
        protected string Noise_level { get; set; }

        public Air_cleaner(
                     string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home",
                     string type = "floor",
                     string cleaner_type = "common",
                     string noise_level = "0db",
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
            Cleaner_type = cleaner_type;
            Noise_level = noise_level;
            ImagePath = imagePath;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                $"Type: {Type}\n" +
                $"Cleaner type: {Cleaner_type}\n" +
                $"Noise level: {Noise_level}\n" +
                $"An air purifier or air cleaner is a device which\n" +
                $"removes contaminants from the\n" +
                $"air in a room to improve indoor air quality.\n" +
                $"These devices are commonly marketed as\n" +
                $"being beneficial to allergy\n" +
                $"sufferers and asthmatics, and at reducing or\n" +
                $"eliminating second-hand tobacco smoke.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
