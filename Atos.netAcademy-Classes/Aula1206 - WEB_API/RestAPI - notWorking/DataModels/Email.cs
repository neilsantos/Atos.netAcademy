using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAPI.DataModels
{
    public class Email
    {
        public int Id { get; set; }
        [JsonIgnore]
        public string E_mail { get; set; } = string.Empty;
        public virtual Pessoa? Pessoa { get; set; }
    }
}