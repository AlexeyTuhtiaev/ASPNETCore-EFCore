using System;
using System.Collections.Generic;
using System.Text;
using Dal.Entities;

namespace Dal
{
    public interface IRepo
    {
        IEnumerable<User> GetAll();
    }
}
