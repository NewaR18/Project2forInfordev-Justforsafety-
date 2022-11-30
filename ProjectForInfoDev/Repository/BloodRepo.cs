using ProjectForInfoDev.Models;

namespace ProjectForInfoDev.Repository
{
    public class BloodRepo:IBloodRepo
    {
        private readonly BloodContext _context;
        public BloodRepo(BloodContext context)
        {
            _context = context;
        }
        public void AddHospital(Blood b1)
        {
            _context.Bloods.Add(b1);
            _context.SaveChanges();
        }
        public IEnumerable<Blood> GetHospital()
        {
            var mylist=_context.Bloods.ToList();
            return mylist;
        }
        public Blood GetSingleHospital(int id)
        {
            Blood b=_context.Bloods.Find(id);
            return b;
        }
        public Blood Updatehospital(Blood b1)
        {
            _context.Bloods.Update(b1);
            _context.SaveChanges();
            return b1;
        }
        public Blood RemoveHospital(int id)
        {
            Blood b1 = _context.Bloods.Find(id);
            _context.Bloods.Remove(b1);
            _context.SaveChanges();
            return b1;
        }
        public void AddQuery(SpecialQuery s1)
        {
            _context.Queries.Add(s1);
            _context.SaveChanges();
        }
    }
}
