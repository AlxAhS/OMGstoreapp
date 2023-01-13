using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Models
{
  

    public class StoreInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? StoreName { get; set; }
        
        [Column(TypeName = "nvarchar(12)")]
        public string? NIT { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string? Owner{ get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string? OwnerDocumentClass { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string? OwnerDocumentNumber{ get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? Address { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string? City { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? AreaCode { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? PhoneNumber{ get; set; }





    }
}