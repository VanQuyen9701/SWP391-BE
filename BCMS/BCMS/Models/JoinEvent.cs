﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BCMS.Models
{
    public partial class JoinEvent
    {
        [Key]
        [Column("MemberID")]
        [StringLength(10)]
        public string MemberId { get; set; }
        [Key]
        [Column("PostID")]
        [StringLength(10)]
        public string PostId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        public bool IsFollow { get; set; }
        [Key]
        [StringLength(10)]
        public string BirdId { get; set; }

        [ForeignKey("BirdId")]
        [InverseProperty("JoinEvent")]
        public virtual Bird Bird { get; set; }
        [ForeignKey("MemberId")]
        [InverseProperty("JoinEvent")]
        public virtual Member Member { get; set; }
        [ForeignKey("PostId")]
        [InverseProperty("JoinEvent")]
        public virtual Post Post { get; set; }
    }
}