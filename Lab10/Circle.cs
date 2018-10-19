using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab10
{
    class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }


        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;

        }
        public string CalculateFormattedCircumference()
        {
            string formatCircum = FormatNumber(CalculateCircumference());
            return formatCircum.ToString();
        }
        public double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI; 
        }
        public string CalculateFormattedArea()
        {
            string formatArea = FormatNumber(CalculateArea());
            return formatArea;
        }
        private string FormatNumber(double x)
        {
            double temp = Math.Round(x,2);
            return temp.ToString();
        }

    }
}
