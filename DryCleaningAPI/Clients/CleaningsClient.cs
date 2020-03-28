using System;
using DryCleaningAPI.API.Responses;
using DryCleaningAPI.Extensions;

namespace DryCleaningAPI
{
    public class CleaningsClient : BaseClient
    {
        internal CleaningsClient(Session session) : base(session) { }

        public Cleaning[] GetCleanings() => _session.Requestor.Get<Cleaning[]>("/cleanings");

        public Cleaning Add(DateTime date, string result, int employee, string chemicalagent, int thing) =>
            _session.Requestor.Post<Cleaning>($"/cleanings?date={date.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&result={result}&employee={employee}&chemicalagent={chemicalagent}&thing={thing}");

        public void Edit(int id, DateTime date, string result, int employee, string chemicalagent, int thing) =>
            _session.Requestor.Put($"/cleanings/{id}?date={date.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&result={result}&employee={employee}&chemicalagent={chemicalagent}&thing={thing}");

        public void Edit(int id, Cleaning cleaning) =>
            Edit(id, cleaning.Date, cleaning.Result, cleaning.Employee, cleaning.ChemicalAgent, cleaning.Thing);

        public void Delete(int id) =>
            _session.Requestor.Delete($"/cleanings/{id}");

        public void Delete(Cleaning cleaning) =>
            Delete(cleaning.ID);
    }
}
