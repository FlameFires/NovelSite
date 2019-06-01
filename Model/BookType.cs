using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("BookType")]
    public class BookType
    {
        public BookType()
        {
        }

        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsHeadShow { get; set; }
    }
}
