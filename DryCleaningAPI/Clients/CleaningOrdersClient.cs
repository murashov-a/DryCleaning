using System;
using System.Collections.Generic;
using System.Linq;
using DryCleaningAPI.API.Responses;
using DryCleaningAPI.Extensions;

namespace DryCleaningAPI
{
    public class CleaningOrdersClient : BaseClient
    {
        internal CleaningOrdersClient(Session session) : base(session) { }

        public CleaningOrder[] GetCleaningOrders() => _session.Requestor.Get<CleaningOrder[]>("/cleaningorders");

        public CleaningOrder Add(DateTime dateofreceipt, DateTime targetterm, int employee, int client) =>
            _session.Requestor.Post<CleaningOrder>($"/cleaningorders?dateofreceipt={dateofreceipt.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&targetterm={targetterm.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&employee={employee}&client={client}");

        public CleaningOrder Edit(int id, DateTime dateofreceipt, DateTime? dateofreturn, DateTime targetterm, DateTime? actualterm, int employee, int client) =>
            _session.Requestor.Put<CleaningOrder>($"/cleaningorders/{id}?dateofreceipt={dateofreceipt.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&dateofreturn={dateofreturn?.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&targetterm={targetterm.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&actualterm={actualterm?.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)}&employee={employee}&client={client}");

        public CleaningOrder Edit(int id, CleaningOrder cleaningOrder) =>
            Edit(id, cleaningOrder.DateOfReceipt, cleaningOrder.DateOfReturn, cleaningOrder.TargetTerm,
                cleaningOrder.ActualTerm, cleaningOrder.Employee, cleaningOrder.Client);

        public CleaningOrder Get(int id) =>
            _session.Requestor.Get<CleaningOrder>($"/cleaningorders/{id}");

        public void Delete(int id) =>
            _session.Requestor.Delete($"/cleaningorders/{id}");

        public void Delete(CleaningOrder cleaningorder) =>
            Delete(cleaningorder.ID);


    }
}
