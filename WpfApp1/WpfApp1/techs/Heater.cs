using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Heater : Clima_tech
    {
        public override string ImagePath { get; set; }

        protected string Type { get; set; }
        protected string Type_of_heating_element { get; set; }

        public Heater(
                     string name_of_tech,
                     int price,
                     int count_of_product = 0,
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double room_area = 0.0,
                     string appointment = "home",
                     string type = "convector",
                     string type_of_heating_element = "closed",
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
            Type_of_heating_element = type_of_heating_element;
            ImagePath = imagePath;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                $"Type: {Type}\n" +
                $"Type of heating element: {Type_of_heating_element}\n" +
                $"Heaters are appliances whose purpose is to\n" +
                $"generate heat (i.e. warmth) for the building.\n" +
                $"This can be done via central heating. Such a\n" +
                $"system contains a boiler, furnace,\n" +
                $"or heat pump to heat water, steam, or air in\n" +
                $"a central location such as a furnace room in a home.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
