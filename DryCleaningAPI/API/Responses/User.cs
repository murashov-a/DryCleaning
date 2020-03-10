using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class User
    {
        [DisplayName("Номер паспорта")]
        public int PassportID { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Должность")]
        public string Role { get; set; }

        [DisplayName("Права администратора")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// For set to DB only
        /// </summary>
        [Browsable(false)]
        public string Password { get; set; }

        public override int GetHashCode()
        {
            return PassportID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is User user)
            {
                equaled = user.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }
    }
}
