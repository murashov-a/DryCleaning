using System;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class ClientsClient
    {
        private readonly Session _session;

        internal ClientsClient(Session session)
        {
            _session = session;
        }

        public Client[] GetClients() => _session.Requestor.Get<Client[]>("/clients");

        public Client GetClient(int id) => _session.Requestor.Get<Client>($"/clients/{id}");

        public Client Add(string name, string telephone) => _session.Requestor.Post<Client>($"/clients?name={name}&telephone={telephone}");

        [Obsolete("Для автоматической генерации ID используйте другую перегрузку", true)]
        public Client Add(Client client) => throw new ArgumentException();

        public Client Edit(int id, string name, string telephone) => _session.Requestor.Put<Client>($"/clients/{id}?name={name}&telephone={telephone}");
        public Client Edit(Client client) => Edit(client.ID, client.Name, client.Telephone);

        public void Delete(int id) =>  _session.Requestor.Delete($"/clients/{id}");
    }
}
