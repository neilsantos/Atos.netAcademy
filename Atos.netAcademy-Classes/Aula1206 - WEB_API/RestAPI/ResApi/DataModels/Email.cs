using System.Text.Json.Serialization;

namespace ResApi.DataModels
{
    public class Email
    {
        public int Id { get; set; }
        [JsonIgnore]
        public string E_mail { get; set; } = string.Empty;
        public virtual Pessoa? Pessoa { get; set; }
    }
}
