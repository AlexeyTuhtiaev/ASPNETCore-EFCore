using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal.Entities;

namespace Dal
{
    public class UserRepo : IRepo
    {
        private Context _db = new Context();

        public void Create(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void Update(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetUser(int id)
        {
            using (Context db = new Context())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == id);
                return user;
            }
        }
    }
}
