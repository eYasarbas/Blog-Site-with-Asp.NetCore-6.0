using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Connection
    {
        [Key]
        public int ConnectionID { get; set; }
        public string ConnectionUserName { get; set; }
        public string ConnectionMail { get; set; }
        public string ConnectionSubject { get; set; }
        public string ConnectionMessage { get; set; }
        public DateTime ConnectionDate { get; set; }
        public bool ConnectionStatus { get; set; }
    }
}