using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abbas_Rahimzadeh_Dotnet.Models
{
    public class Order
    {
        [Required]
        [Key]
        public int Id {get;set;}
    }
}