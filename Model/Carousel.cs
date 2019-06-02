using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Carousel")]
    public class Carousel
    {
        public Carousel()
        {
            CreateDateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        // 展示图片
        public string ShowImg { get; set; }

        // 书本id
        public int BookId { get; set; }

        // 链接地址
        public string LinkAddress {get;set;}

        public bool IsShow { get; set; }

        public DateTime? CreateDateTime { get; set; }

        public int ImgWidth { get; set; }

        public int ImgHeight { get; set; }
    }
}
