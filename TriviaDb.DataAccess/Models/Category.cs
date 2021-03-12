namespace TriviaDb.DataAccess.Models
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Categories")]
    public class Category
    {
        [Column("id")]
        [Key]
        [Required]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("name")]
        [JsonProperty("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
