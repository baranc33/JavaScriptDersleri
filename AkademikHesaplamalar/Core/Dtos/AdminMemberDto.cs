﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class AdminMemberDto
    {
        [Key]
        public int Id { get; set; }

        public int IdRow { get; set; }


        public string UserName{ get; set; } = "";
        public string UserEmail{ get; set; } = "";


        [MaxLength(150, ErrorMessage = "En Fazla 150 karakter olabilir")]
        public string MyUserId { get; set; } = "";



        [MaxLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string? FullName { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? Degree { get; set; } = "";// ünvan
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? Github { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? Linkedin { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? Instegram { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? Facebook { get; set; } = "";
        [MaxLength(1000, ErrorMessage = "En Fazla 1000 karakter olabilir")]
        public string? Description { get; set; } = "";
        [MaxLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string? MailAdres { get; set; } = "";
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")]
        public string? MailExtension { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string? WebSiteUrl { get; set; } = "";
        [MaxLength(150, ErrorMessage = "En Fazla 150 karakter olabilir")]
        public string? İmage { get; set; } = "";
    }
}
