using Domain;
using Service.Pattern;
using Data.Infrastructure;
using Data.Models;

namespace Service
{
    public class InsuranceCompanyService : Service<insurancecompany>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork ut = new UnitOfWork(df);
        public InsuranceCompanyService() : base(ut)
        {

        }

    }
}

