using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.Iformatable
{
    public class Employee :IFormattable
    {
        public int Id { get; set; }
        public string Tittle {  get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }

        public string FullName => $"{Tittle} {FirstName} {LastName}";

        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }

        public  string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);

        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "F";
            }

            if(formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpper())
            {
                case "F":return $"{Id} {Tittle} {FirstName} {LastName}";
                case "FL": return$"{FirstName} {LastName}";

                default:throw  new FormatException("HATALSINN");
                   
            }
        }
    }
}
