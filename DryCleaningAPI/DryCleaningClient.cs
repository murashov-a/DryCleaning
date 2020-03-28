namespace DryCleaningAPI
{
    public class DryCleaningClient
    {
        private Session Session { get; set; }

        public UsersClient Users { get; private set; }
        public ClientsClient Clients { get; private set; }
        public RolesClient Roles { get; private set; }
        public MaterialsClient Materials { get; private set; }
        public ResultsClient Results { get; private set; }
        public TypesClient Types { get; private set; }
        public ChemicalAgentClient ChemicalAgent { get; private set; }
        public CleaningOrdersClient CleaningOrders { get; private set; }

        public DryCleaningClient(string ApiUrl, int passport, string password)
        {
            Session = new Session(ApiUrl, passport, password);
            InitClients();
        }
        public DryCleaningClient(string ApiUrl, string token)
        {
            Session = new Session(ApiUrl, token);
            InitClients();
        }

        private void InitClients()
        {
            Users = new UsersClient(Session);
            Roles = new RolesClient(Session);
            Clients = new ClientsClient(Session);
            Materials = new MaterialsClient(Session);
            Results = new ResultsClient(Session);
            Types = new TypesClient(Session);
            ChemicalAgent = new ChemicalAgentClient(Session);
            CleaningOrders = new CleaningOrdersClient(Session);
        }
    }
}