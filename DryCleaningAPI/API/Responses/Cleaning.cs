using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DryCleaningAPI.API.Responses
{
    public class Cleaning
    {
        public int ID { get; set; }

        [JsonConverter(typeof(Extensions.SqliteDateTimeConverter))]
        public DateTime Date { get; set; }

        public string Result { get; set; }

        public int Employee { get; set; }

        public string ChemicalAgent { get; set; }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Cleaning cleaning)
            {
                equaled = cleaning.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public Cleaning Clone()
        {
            return new Cleaning()
            {
                ID = ID,
                Result = Result,
                ChemicalAgent = ChemicalAgent,
                Date = Date,
                Employee = Employee
            };
        }

        public override string ToString()
        {
            return $"{this.ID}";
        }
    }
}
