using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNote.Models
{
    public class Note
    {
        //note
        public int ID { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
