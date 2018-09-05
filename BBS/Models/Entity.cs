using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Models.Role
{
    public class Entity
    {
        [Key]
        [Required]
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }
        [Column("CreateTime", TypeName = "nvarchar(20)")]
        public string CreateDate { get; set; }
        [Column("LoginTime", TypeName = "nvarchar(20)")]
        public string LoginDate { get; set; }
    }
}
