using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class MaterialsClient : BaseClient
    {
        internal MaterialsClient(Session session) : base(session) { }

        public Material[] GetMaterials() => _session.Requestor.Get<Material[]>("/materials");

        public void Add(string name) =>
            _session.Requestor.Post($"/materials?name={name}");

        public void Add(Material material) =>
            Add(material.Name);

        public void Edit(string oldName, string newName) =>
            _session.Requestor.Put($"/materials/{oldName}?name={newName}");

        public void Edit(string oldName, Material material) =>
            Edit(oldName, material.Name);

        public void Delete(string name) =>
            _session.Requestor.Delete($"/materials/{name}");

        public void Delete(Material material) =>
            Delete(material.Name);

    }
}
