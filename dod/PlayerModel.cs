using RPG090524.Kasy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dod
{
    internal class PlayerModel
    {
        [Key]
        public int id { get; set; }
        public string klasa { get; set; }
        public int hp { get; set; }
        public int sila { get; set; }
        public int inteligencja { get; set; }
        public bool isdead { get; set; }
    }
}
