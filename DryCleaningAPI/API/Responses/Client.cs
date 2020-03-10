using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class Client
    {
        [DisplayName("Номер")]
        public int ID { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Номер телефона")]
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Client client)
            {
                equaled = client.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }
    }
}
