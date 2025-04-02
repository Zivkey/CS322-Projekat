using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Models
{
    public class Vinyl
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseYear {  get; set; }
        public decimal Price { get; set; }

        //Artist 
        public int ArtistId {  get; set; }
        public virtual Artist Artist { get; set; }

        public Vinyl() { }
    }
}
