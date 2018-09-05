using BBS.Models.Role;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Models.Roles
{
    [Table("role_info")]
    public class RoleInfo : Entity
    {
        [Column("sex", TypeName = "int")]
        public int Sex { get; set; }
        [Column("lvl", TypeName = "int")]
        public int Level { get; set; }
        [Column("phone", TypeName = "nvarchar(13)")]
        public int Phone { get; set; }
        [ForeignKey("rid")]
        public Role Rid { get; set; }
        //public int Rid { get; set; }
    }
}
