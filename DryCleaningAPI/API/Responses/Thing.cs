
namespace DryCleaningAPI.API.Responses
{
    public class Thing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public int CleaningOrder { get; set; }

        public string FullName
        {
            get { return $"{Name} ({Type}, {Material})"; }
        } 

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Thing thing)
            {
                equaled = thing.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public Thing Clone()
        {
            return new Thing()
            {
                ID = ID,
                Name = Name,
                CleaningOrder = CleaningOrder,
                Material = Material,
                Type = Type
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
