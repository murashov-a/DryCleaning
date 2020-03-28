using System;
using System.ComponentModel;

namespace DryCleaningClient.API.Responses
{
    public class Client
    {
        public int ID { get; set; }

        public string Name { get; set; }

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

        public Client Clone()
        {
            return new Client() { ID = ID, Name = Name, Telephone = Telephone };
        }

        [Obsolete("ID выдаёт БД, поэтому невозможно создать экземпляр по умолчанию", true)]
        public static Client Default;

        public override string ToString()
        {
            return Name;
        }
    }
}
