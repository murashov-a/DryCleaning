using Newtonsoft.Json.Converters;

namespace DryCleaningAPI.Extensions
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public const string SQLITE_DATE_FORMAT = "dd-MM-yyyy";
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = SQLITE_DATE_FORMAT;
        }
    }
}
