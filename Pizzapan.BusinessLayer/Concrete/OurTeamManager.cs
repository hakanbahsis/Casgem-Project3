using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TAdd(OurTeam entity)
        {
            _ourTeamDal.Add(entity);
        }

        public List<OurTeam> TGetAll()
        {
            return _ourTeamDal.GetAll();
        }

        public OurTeam TGetById(int id)
        {
            return _ourTeamDal.Get(id);
        }

        public void TRemove(OurTeam entity)
        {
            _ourTeamDal.Delete(entity);
        }

        public void TUpdate(OurTeam entity)
        {
            _ourTeamDal.Update(entity);
        }
    }
}
