using CS322_Projekat.Data;
using CS322_Projekat.Enums;
using CS322_Projekat.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Services
{
    public class ArtistService
    {
        private readonly AppDbContext _context;

        public ArtistService()
        {
            _context = new AppDbContext();
        }

        public void Add(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public void Update(Artist artist)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var artist = _context.Artists.FirstOrDefault(a => a.Id == id);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }

        public List<Artist> GetAll()
        {
            return _context.Artists.ToList();
        }

    }
}
