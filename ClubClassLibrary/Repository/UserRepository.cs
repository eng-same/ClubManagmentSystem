using System;
using System.Collections.Generic;
using System.Linq;
using ClubClassLibrary.Data;
using BCrypt.Net;
using ClubClassLibrary.Models;

namespace ClubClassLibrary.Repository
{
    public class UserRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public List<User> GetAll()
        {
            return _db.Users.ToList(); // Get all users from the database
        }

        public User GetById(int id)
        {
            return _db.Users.Find(id); // Use the Find method for primary key lookups
        }

        public User GetByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.Password = HashPassword(user.Password);
            user.DateCreated = DateTime.Now;

            _db.Users.Add(user);
            _db.SaveChanges(); // Save changes to the database
        }

        public void Update(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var existingUser = _db.Users.Find(user.Id);
            if (existingUser == null)
            {
                throw new ArgumentException($"User with ID {user.Id} not found.");
            }

            // Update properties
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Phone = user.Phone;
            existingUser.Address = user.Address;
            existingUser.Status = user.Status;
            existingUser.Role = user.Role;

            // Handle password update (hash if changed)
            if (!string.IsNullOrEmpty(user.Password) && user.Password != existingUser.Password)
            {
                existingUser.Password = HashPassword(user.Password);
            }

            _db.SaveChanges();
        }

        public string GetRole(string username)
        {
            var user = _db.Users.FirstOrDefault(u => u.Name == username);
            if (user == null)
            {
                throw new ArgumentException($"User with username {username} not found.");
            }

            return user.Role;
        }

        public void Delete(int id)
        {
            var userToDelete = _db.Users.Find(id);
            if (userToDelete == null)
            {
                throw new ArgumentException($"User with ID {id} not found.");
            }

            _db.Users.Remove(userToDelete);
            _db.SaveChanges();
        }
        public bool UserExists(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Name == username); // Get the user

            if (user == null)
            {
                return false; // User not found
            }

            return BCrypt.Net.BCrypt.Verify(password, user.Password); // Compare hash
        }


        private string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            }

            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}