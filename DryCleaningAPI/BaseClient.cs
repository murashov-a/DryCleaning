namespace DryCleaningAPI
{
    public abstract class BaseClient
    {
        internal readonly Session _session;
        internal BaseClient(Session session)
        {
            _session = session;
        }
    }
}
