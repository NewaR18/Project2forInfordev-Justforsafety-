using ProjectForInfoDev.Models;

namespace ProjectForInfoDev.Repository
{
    public interface IBloodRepo
    {
        public void AddHospital(Blood b1);
        public Blood RemoveHospital(int id);
        public Blood Updatehospital(Blood b1);
        public IEnumerable<Blood> GetHospital();
        public Blood GetSingleHospital(int id);
        public void AddQuery(SpecialQuery s1);
    }
}
