using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class User
    {
        [DisplayName("Номер паспорта")]
        public int PassportID { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Должность")]
        public string Role { get; set; }

        [DisplayName("Права администратора")]
        public bool IsAdmin { get; set; }
    }
}
