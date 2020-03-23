using System.ComponentModel;
using BrightIdeasSoftware;

namespace DryCleaningClient.API.Responses
{
    public class User
    {
        [OLVColumn("Номер паспорта")]
        public int PassportID { get; set; }

        [OLVColumn("ФИО")]
        public string Name { get; set; }

        [OLVColumn("Должность")]
        public string Role { get; set; }

        [OLVColumn("Права администратора")]
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

        public User Clone()
        {
            return new User() { IsAdmin = IsAdmin, Name = Name, PassportID = PassportID, Password = Password, Role = Role };
        }

        public static readonly User Default = new User()
        {
            Name = "",
            IsAdmin = false,
            Role = "",
            Password = "",
            PassportID = 0
        };
    }
}
