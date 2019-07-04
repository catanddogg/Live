using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveMotion.Models
{
    [Table("Presentations")]
    public class Presentations
    {
        [PrimaryKey, AutoIncrement]
        public string id { get; set; }
        public string Title { get; set; }
    }
}
