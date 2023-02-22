using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurweyAndLists
{
    public class Option : IEntity
    {
        
        [Key]
        public int Id { get; set; }
        
        public string? OptionText { get; set; }
        public int? NumberOfVotes { get; set; }  

        public Surwey? surwey { get; set; } // OneToMany bağlantısında One tarafının karşılığı

        [ForeignKey("surwey")]
        public int? survey_id { get; set; }

    }
}
