using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Extractor
    {
   
        public static List<Clima_tech> Air_conditions_template(string file)
        {
            List<Clima_tech> techs = new List<Clima_tech>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                  

                    techs.Add(new Air_condition(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    Convert.ToDouble(values[3], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    values[7],
                    values[8],
                    values[9],
                    values[10]
                    ));
                }
            }
            return techs;
        }

        public static List<Clima_tech> Humidifier_template(string file)
        {
            List<Clima_tech> techs = new List<Clima_tech>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');



                    techs.Add(new Humidifier(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    Convert.ToDouble(values[3], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    values[7],
                    values[8],
                    values[9],
                    values[10]
                    ));
                }
            }
            return techs;
        }

        public static List<Clima_tech> Heaters_template(string file)
        {
            List<Clima_tech> techs = new List<Clima_tech>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    techs.Add(new Heater(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    Convert.ToDouble(values[3], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    values[7],
                    values[8],
                    values[9],
                    values[10]
                    ));
                }
            }
            return techs;
        }

        public static List<Clima_tech> Air_cleaners_template(string file)
        {
            List<Clima_tech> techs = new List<Clima_tech>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    techs.Add(new Air_cleaner(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    Convert.ToDouble(values[3], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    values[7],
                    values[8],
                    values[9],
                    values[10],
                    values[11]
                    ));
                }
            }
            return techs;
        }

        public static List<Clima_tech> Fans_template(string file)
        {
            List<Clima_tech> techs = new List<Clima_tech>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    techs.Add(new Fan(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    Convert.ToDouble(values[3], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    values[7],
                    values[8],
                    values[9],
                    values[10]
                    ));
                }
            }
            return techs;
        }
    }
}
