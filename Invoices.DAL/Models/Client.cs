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
        [Key]
        public string ClientID { get; set; }
       
        [Column(TypeName = "nvarchar(100)")]
        public string ClientName { get; set; }
    }
}