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

        // 类型名
        public string Name { get; set; }

        // 首页是否显示
        public bool IsHeadShow { get; set; }

        // 父级ID
        public int ParentId { get; set; }
    }
}
