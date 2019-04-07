using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkWithEFCoreApp.Entities;

namespace WorkWithEFCoreApp
{
   static class Operations
    {
        public static void Create(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static void Update(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
        }

        public static void Delete(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public static IEnumerable<User> GetAll()
        {
            using (Context db = new Context())
            {
                return db.Users;
            }
        }

        public static User GetUser(int id)
        {
            using (Context db = new Context())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == id);
                return user;
            }
        }
    }
}
