using RPG090524.Kasy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RPG090524
{
    internal class BazaContext:DbContext
    {
        public DbSet<dod.PlayerModel> character { get; set; }
        


    }

    /*  PlayerContext db=new PlayerContext();
        PlayerModel pm = new playerModel()
        {
            Player = player,
            IsDead = false
      };
    db.character.add(pm);
     */

}
