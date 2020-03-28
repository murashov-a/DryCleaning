using System;
using System.ComponentModel;
using DryCleaningAPI.Extensions;
using Newtonsoft.Json;

namespace DryCleaningAPI.API.Responses
{
    public class CleaningOrder
    {
        [DisplayName("Номер")]
        public int ID { get; set; }

        [DisplayName("Дата получения")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime DateOfReceipt { get; set; }

        [DisplayName("Дата возврата")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? DateOfReturn { get; set; }

        [DisplayName("Плановый срок")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime TargetTerm { get; set; }

        [DisplayName("Фактический срок")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? ActualTerm { get; set; }

        [DisplayName("Сотрудник")]
        public int Employee { get; set; }

        [DisplayName("Клиент")]
        public int Client { get; set; }
    }
}
