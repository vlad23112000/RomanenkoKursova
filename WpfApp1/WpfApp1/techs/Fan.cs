using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Fan : Clima_tech
    {
        public override string ImagePath { get; set; }

        protected string Type { get; set; }
        protected string Timer { get; set; }

        public Fan(
                     string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home",
                     string type = "floor",
                     string timer = "<1hour",
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
            Timer = timer;
            ImagePath = imagePath;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                $"Timer: {Timer}\n" +
                $"Type: {Type}\n" +
                $"A fan is a powered machine used to create flow\n" +
                $"within a fluid, typically a gas, such as air\n" +
                $"A fan consists of a rotating arrangement of\n" +
                $"vanes or blades, which act on the air. The rotating\n" +
                $"assembly of blades and hub is known as an impeller,\n" +
                $"rotor, or runner. Most fans are powered by electric\n" +
                $"motors.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
