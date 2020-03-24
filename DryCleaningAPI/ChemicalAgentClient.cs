using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class ChemicalAgentClient
    {
        private readonly Session _session;
        internal ChemicalAgentClient(Session session)
        {
            _session = session;
        }

        public ChemicalAgent[] GetChemicalAgents() => _session.Requestor.Get<ChemicalAgent[]>("/chemicalagents");

        public void Add(string name) =>
            _session.Requestor.Post($"/chemicalagents?name={name}");

        public void Add(ChemicalAgent chemicalAgent) =>
            Add(chemicalAgent.Name);

        public void Edit(string oldName, string newName) =>
            _session.Requestor.Put($"/chemicalagents/{oldName}?name={newName}");

        public void Edit(string oldName, ChemicalAgent chemicalAgent) =>
            Edit(oldName, chemicalAgent.Name);

        public void Delete(string name) =>
            _session.Requestor.Delete($"/chemicalagents/{name}");

        public void Delete(ChemicalAgent chemicalAgent) =>
            Delete(chemicalAgent.Name);
    }
}
