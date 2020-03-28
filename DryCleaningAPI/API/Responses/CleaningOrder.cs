using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace DryCleaningAPI.API.Responses
{
    public class CleaningOrder
    {
        public int ID { get; set; }

        [JsonConverter(typeof(Extensions.SqliteDateTimeConverter))]
        public DateTime DateOfReceipt { get; set; }

        [JsonConverter(typeof(Extensions.SqliteDateTimeConverter))]
        public DateTime? DateOfReturn { get; set; }

        [JsonConverter(typeof(Extensions.SqliteDateTimeConverter))]
        public DateTime TargetTerm { get; set; }

        [JsonConverter(typeof(Extensions.SqliteDateTimeConverter))]
        public DateTime? ActualTerm { get; set; }

        public int Employee { get; set; }

        public int Client { get; set; }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is CleaningOrder cleaningOrder)
            {
                equaled = cleaningOrder.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public CleaningOrder Clone()
        {
            return new CleaningOrder()
            {
                ID = ID,
                Client = Client,
                ActualTerm = ActualTerm,
                DateOfReceipt = DateOfReceipt,
                DateOfReturn = DateOfReturn,
                Employee = Employee,
                TargetTerm = TargetTerm
            };
        }

        public override string ToString()
        {
            return $"{this.ID}";
        }
    }
}
