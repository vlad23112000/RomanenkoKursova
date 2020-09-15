using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TechManager
    {
        public List<string> Filters { get; set; }
        public string category = "all_techs";
        public string option = "None";
        public string Search_option_name { get; set; } = "None";
        public string Search_option_area { get; set; } = "None";

        public List<Clima_tech> Get_filtered_sorted_techs()
        {
            List<Clima_tech> techs = Get_all_techs_by_category(category);
            techs = Filter_techs(techs);
            techs = Order_by(techs);
            techs = Search_by_name(techs);
            techs = Search_by_area(techs);
            return techs;
        }

        private List<Clima_tech> Filter_techs(List<Clima_tech> techs)
        {
            foreach(string filter in Filters)
            {
                switch (filter)
                {
                    case "less than 2001":
                        techs = techs.Where(c => c.Price <= 2000).ToList();
                        break;
                    case "more than 2000":
                        techs = techs.Where(c => c.Price > 2000).ToList();
                        break;
                    case "avaible":
                        techs = techs.Where(c => c.Is_avaible() == true).ToList();
                        break;
                }
            }
            return techs;
        }

        private List<Clima_tech> Order_by(List<Clima_tech> techs)
        {
            switch (option)
            {
                case "ASC":
                    techs = techs.OrderBy(c=>c.Price).ToList();
                    break;
                case "DESC":
                    techs = techs.OrderByDescending(c => c.Price).ToList();
                    break;
            }
            return techs;
        }

        public List<Clima_tech> Get_all_techs_by_category(string category_name)
        {
           switch (category_name)
            {
                case "air_conditions":
                    return Extractor.Air_conditions_template("Air_conditions.csv");
                case "air_cleaners":
                    return Extractor.Air_cleaners_template("Air_cleaners.csv");
                case "heaters":
                    return Extractor.Heaters_template("Heaters.csv");
                case "fans":
                    return Extractor.Heaters_template("Fans.csv");
                case "humidifiers":
                    return Extractor.Heaters_template("Humidifiers.csv");
                case "all_techs":
                    List<Clima_tech> all_techs = new List<Clima_tech>();
                    all_techs.AddRange(Extractor.Air_conditions_template("Air_conditions.csv"));
                    all_techs.AddRange(Extractor.Heaters_template("Heaters.csv"));
                    all_techs.AddRange(Extractor.Air_cleaners_template("Air_cleaners.csv"));
                    all_techs.AddRange(Extractor.Fans_template("Fans.csv"));
                    all_techs.AddRange(Extractor.Humidifier_template("Humidifiers.csv"));
                    return all_techs;
            }
            return null;
        }

        private List<Clima_tech> Search_by_name(List<Clima_tech> techs)
        {
            if (Search_option_name != "None" && Search_option_name != "")
            {
                techs = techs.Where(c => c.Name_of_tech.ToLower().Contains(Search_option_name)).ToList();
                return techs;
            }
            else
            {
                return techs;
            }
        }

        private List<Clima_tech> Search_by_area(List<Clima_tech> techs)
        {
            if (Search_option_area != "None" && Search_option_area != "")
            {
                techs = techs.Where(c => c.Room_area.ToString().ToLower().Contains(Search_option_area)).ToList();
                return techs;
            }
            else
            {
                return techs;
            }
        }
    }
}   
