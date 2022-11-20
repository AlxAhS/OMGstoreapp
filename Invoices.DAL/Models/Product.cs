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
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? ProductDescription { get; set; }
        
        [Column(TypeName = "nvarchar(20)")] 
        public string? ProductValue { get; set; }

    }
}
