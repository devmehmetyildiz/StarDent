using System.ComponentModel.DataAnnotations;

namespace StarDentApi.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; }
        public DateTime Createtime { get; set; }
        public DateTime Updatetime { get; set; }
        public DateTime Deletetime { get; set; }
        public string Createduser { get; set; }
        public string Updateduser { get; set; }
        public string Deleteduser { get; set; }
        public bool Isactive { get; set; }
    }
}
