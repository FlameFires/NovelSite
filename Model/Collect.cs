using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Collect")]
    public class Collect
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("BookInfo")]
        public int Book_Id { get; set; }

        [ForeignKey("Account")]
        public int User_Id { get; set; }
    }
}
