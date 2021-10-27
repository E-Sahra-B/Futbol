using Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Match:IEntity
    {
        [Key]
        public int MatchId { get; set; }
        public int TeamId1 { get; set; }
        public int TeamId2 { get; set; }

        public Team Teams { get; set; }
        public int Result1 { get; set; }
        public int Result2 { get; set; }
       
       

    }
}
