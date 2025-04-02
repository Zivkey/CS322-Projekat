using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Models
{
    public class UserSaleItem
    {
        public int Id { get; set; }

        //Vinyl
        public int VinylId {  get; set; }
        public virtual Vinyl Vinyl {  get; set; }

        //User sale
        public int UserSaleId { get; set; }
        public virtual UserSale UserSale { get; set; }

        public int Quantity {  get; set; }
    }
}
