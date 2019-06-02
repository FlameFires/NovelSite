using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("_BookTags")]
    public class _BookTags
    {
        public _BookTags()
        {
            CreateDateTime = DateTime.Now;
        }

        public int Id { get; set; }

        // 书本id
        [ForeignKey("bookInfo")]
        public int BookId { get; set; }

        // 标签Id
        [ForeignKey("tags")]
        public int TagsId { get; set; }

        // 创建时间
        public DateTime? CreateDateTime { get; set; }

        public Tags tags { get; set; }

        public BookInfo bookInfo { get; set; }
    }
}
