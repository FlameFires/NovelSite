using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("BookChapter")]
    public class BookChapter
    {
        public BookChapter()
        {
            CreateDataTime = DateTime.Now;
        }

        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey("")]
        public int? Book_Id { get; set; }

        // 章节标题
        [MaxLength(100)]
        public string Title { get; set; }

        // 章节内容
        public string Content { get; set; }

        // 章节目录
        public string chapterPath { get; set; } 

        // 字数
        public int Words { get; set; }

        // 创立时间
        public DateTime CreateDataTime{get;set;}

        
    }
}