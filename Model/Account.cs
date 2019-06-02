using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Account")]
    public class Account
    {
        public Account()
        {
            CreateDateTime = DateTime.Now;
            IsAdmin = false;
        }

        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Session_Id { get; set; }

        public bool IsAdmin { get; set; }

        public DateTime? CreateDateTime { get; set; }
    }
}
