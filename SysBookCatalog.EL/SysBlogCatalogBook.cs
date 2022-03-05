using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SysBookCatalog.EL
{
    internal class SysBlogCatalogBook
    {
        [Key]
        private int IdUser { get; set; }
        private string LevelUser { get; set; }
        [Required]
        [StringLength(100)]
        private DateTime DateCreateUser { get; set; }
        [Required]
        [StringLength(50)]
        private string Name { get; set; }
        internal string Email { get; set; }
        internal string Password { get; set; }
        private Boolean State { get; set; }


        public void ReadBook() { 
        }
        public void PlaysAudioBook() { 
        }

        public void HistoryBookCap() { 
        }
        public void CalificaLibro()
        {

        }


    }
}
