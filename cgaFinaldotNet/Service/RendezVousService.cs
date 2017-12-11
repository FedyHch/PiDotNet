using Domain;
using Service.Pattern;
using Data.Infrastructure;

namespace Service
{
    public class RendezVousService : Service<rendez_vous>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork ut = new UnitOfWork(df);
        public RendezVousService() :base(ut)
        {

        }

    }
}
