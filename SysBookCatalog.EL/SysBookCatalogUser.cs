using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SysBookCatalog.EL
{
    internal class SysBookCatalogUser
    {
        [Key]
        private int IdBook { get; set; }
        private string title { get; set; }
        private DateTime Lounch { get; set; }
        private string Editorial { get; set; }
        private int NPages { get; set; }
        private Boolean State { get; set; }


        public void GiveALike()
        {

        }

        public void Comment()
        {

        }

        public void GradeBook()
        {

        }

        public void AplicPromotion()
        {

        }

        public void MakeAClaim()
        {

        }
    }
}
