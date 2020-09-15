using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Humidifier : Clima_tech
    {
        public override string ImagePath { get; set; }

        protected string Type { get; set; }
        protected string Capacity { get; set; }

        public Humidifier(
                     string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home",
                     string type = "steam",
                     string capacity = "0,5l",
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
            Capacity = capacity;
            ImagePath = imagePath;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                $"Capacity: {Capacity}\n" +
                $"Type: {Type}\n" +
                $"A humidifier is a device, primarily an electrical appliance,\n" +
                $"that increases humidity (moisture) in a single room or an\n" +
                $"entire building. In the home, point-of-use humidifiers are\n" +
                $"commonly used to humidify a single room, while whole-house\n" +
                $"or furnace humidifiers, which connect to a home's HVAC system,\n" +
                $"provide humidity to the entire house.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
