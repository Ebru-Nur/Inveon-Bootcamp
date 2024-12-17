using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Entities
{
    public class Book     {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string Author { get; set; }

        [Required]
        public int PublicationYear { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [MaxLength(50)]
        public string Genre { get; set; }

        [MaxLength(50)]
        public string Publisher { get; set; }

        [Required]
        public int PageCount { get; set; }

        [MaxLength(50)]
        public string Language { get; set; }

        [MaxLength(1000)]
        public string Summary { get; set; }

        [Required]
        public int AvailableCopies { get; set; }
    
}
}
