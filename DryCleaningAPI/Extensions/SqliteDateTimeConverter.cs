using Newtonsoft.Json.Converters;

namespace DryCleaningAPI.Extensions
{
    public class SqliteDateTimeConverter : IsoDateTimeConverter
    {
        public const string SQLITE_DATE_FORMAT = "dd-MM-yyyy";
        public SqliteDateTimeConverter()
        {
            base.DateTimeFormat = SQLITE_DATE_FORMAT;
        }
    }
}
