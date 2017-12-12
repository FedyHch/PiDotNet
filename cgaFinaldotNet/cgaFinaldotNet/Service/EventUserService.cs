using Data.Infrastructure;
using Data.Models;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
  public  class EventUserService:Service<evenement_user>
    {

        private static DatabaseFactory dbf = new DatabaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);
        public EventUserService() : base(unt)
        {
        }
        public IEnumerable<evenement_user> verifyBooking(int id1, int id2)
        {
            var res = from req in unt.getRepository<evenement_user>().GetAll()
                      where (req.participants_id == id1 && req.listEvents_EventID == id2)
                      select req;
            return res;
        }
        
    }
}
