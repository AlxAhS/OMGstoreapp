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
  

    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string? IdType { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string? IDNumber { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string? Email{ get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string? PhoneNumber { get; set; }


    }
}