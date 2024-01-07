using System.ComponentModel.DataAnnotations;

namespace StarDentApi.Entities
{
    public class AccesstokenEntity
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Userid { get; set; }
        public string  Accesstoken{ get; set; }
        public string Refreshtoken { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime Createtime { get; set; }
        public bool Isactive { get; set; }
    }
}
