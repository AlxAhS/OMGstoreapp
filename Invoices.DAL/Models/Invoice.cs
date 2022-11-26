using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public DateTime InvoiceDate { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? InvoiceNumber { get; set; }
    }
}
