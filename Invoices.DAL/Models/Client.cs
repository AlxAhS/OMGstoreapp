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
        [Column(TypeName = "nvarchar(25)")]
        //Todo: Add document type enum (CC,CE, NIT, TI etc..)
        public string? DocumentID { get; set; }
       
        [Column(TypeName = "nvarchar(100)")]
        public string? ClientName { get; set; }
    }
}