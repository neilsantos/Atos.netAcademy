using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DataModels
{
    public class Email
    {
        public int Id { get; set; }
        public string E_mail { get; set; } = string.Empty;
        public virtual Pessoa Pessoa { get; set; }
    }
}