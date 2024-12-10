using System.ComponentModel.DataAnnotations;

namespace File_Upload.Models
{
    public class Gift {
        [Key]
        public int Id { get; set; } // for pk we use data annotations
        [Required]
        public string GiftImage { get; set; }
    }
}
