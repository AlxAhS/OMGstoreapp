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
        public int ClientID { get; set; }

        //To do: Add document type enum (CC,CE, NIT, TI etc..)
        [Column(TypeName = "nvarchar(10)")]
        public string? DocumentType { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string? DocumentID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? ClientName { get; set; }
    }
}