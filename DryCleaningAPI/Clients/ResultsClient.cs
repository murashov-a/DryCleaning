using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class ResultsClient : BaseClient
    {
        internal ResultsClient(Session session) : base(session) { }

        public Result[] GetResults() => _session.Requestor.Get<Result[]>("/results");

        public void Add(string name) =>
            _session.Requestor.Post($"/results?name={name}");

        public void Add(Result result) =>
            Add(result.Name);

        public void Edit(string oldName, string newName) =>
            _session.Requestor.Put($"/results/{oldName}?name={newName}");

        public void Edit(string oldName, Result result) =>
            Edit(oldName, result.Name);

        public void Delete(string name) =>
            _session.Requestor.Delete($"/results/{name}");

        public void Delete(Result result) =>
            Delete(result.Name);
    }
}
