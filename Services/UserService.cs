using CS322_Projekat.Data;
using CS322_Projekat.Enums;
using CS322_Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService()
        {
            _context = new AppDbContext();
        }

        public bool RegisterUser(string name, string email, string password)
        {
            if (_context.Users.Any(u => u.Email == email))
                return false;

            var user = new User
            {
                Name = name,
                Email = email,
                Password = password,
                Role = RoleEnum.User
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }

        public User LoginUser(string email, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
