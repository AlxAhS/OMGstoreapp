using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoices.DAL.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public DateTime Date { get; set; } = DateTime.UtcNow;

		[Column(TypeName = "nvarchar(10)")]
        public string? Serial { get; set; }

        

    }
}
