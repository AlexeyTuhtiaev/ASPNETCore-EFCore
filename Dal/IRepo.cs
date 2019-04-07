using System.Collections.Generic;
using Dal.Entities;

namespace Dal
{
    public interface IRepo
    {
        IEnumerable<User> GetAll();
    }
}
