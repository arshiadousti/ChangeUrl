using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Data
{
    public class URL
    {
        [Key]
        public int Id { get; set; }

        public string Url { get; set; }
    }
}
