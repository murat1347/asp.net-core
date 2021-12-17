using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjeCore.Models;

namespace ProjeCore.Models
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }
        public string BirimAd { get; set; }
        public IList<Personel> Personels { get; set; }
    }
}