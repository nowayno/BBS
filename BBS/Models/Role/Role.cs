﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Models.Role
{
    [Table("role")]
    public class Role : Entity
    {
        [Column("role_name", TypeName = "nvarchar")]
        public string Name { get; set; }
        [Column("pass", TypeName = "int")]
        public int Password { get; set; }
        [Column("reg_name", TypeName = "nvarchar")]
        public string RegName { get; set; }
    }
}
