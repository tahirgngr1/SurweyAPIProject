using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurweyAndLists
{
    public class Surwey : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Question { get; set; }
        public List<Option>? Options { get; set; }
    }
}
