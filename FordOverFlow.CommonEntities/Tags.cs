﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordOverFlow.CommonEntities
{
    [Table("Tags")]
    public class Tags 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TagID { get; set; }

        [Required, StringLength(500)]
        public string TagName { get; set; }

        public virtual List<UserTags> UserTags { get; set; }
        public virtual List<PostTags> PostTags { get; set; }

        ////23.10
        //public Tags()
        //{
        //    UserTags = new List<UserTags>();
        //    PostTags = new List<PostTags>();    
        //}
    }
}
