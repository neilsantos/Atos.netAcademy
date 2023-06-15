using System.Text.Json.Serialization;

namespace ResApi.DataModels
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public virtual ICollection<Email>? Emails { get; set; }
    }
}
