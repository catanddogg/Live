using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveMotion.Models
{
    [Table("Slides")]
    public class Slides
    {
        [PrimaryKey, AutoIncrement]
        public string id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public string PresentationId { get; set; }
    }
}
