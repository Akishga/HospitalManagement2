using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Management2.Models
{
    
    public class Doctor
    {
        [JsonIgnore]
        [Key]        
        public int ID { get; set; }
        public string DocType { get; set; }
        public string DocName { get; set; }
        public string gender { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string status { get; set; }
    }

}
