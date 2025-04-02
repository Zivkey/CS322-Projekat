using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Models
{
    public class UserSale
    {
        public int Id {  get; set; }

        //User
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime SaleDate { get; set; }
        public decimal Total {  get; set; }
        public virtual ICollection<UserSaleItem> SaleItems { get; set; }

        public UserSale()
        {
            SaleItems = new List<UserSaleItem>();
        }


    }
}
