using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoices.DAL.Models
{


    public class StoreInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? NIT { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string? OwnerName{ get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? Address { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string? City { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? State { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? Phone { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? AccountNumber { get; set; }

    }
}