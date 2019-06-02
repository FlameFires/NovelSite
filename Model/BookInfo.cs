using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("BookInfo")]
    public class BookInfo
    {
        public BookInfo()
        {
            Click = 0;
            Recommend = 0;
            UpDateTime = DateTime.Now;
        }

        [Required]
        [Key]
        public int Id { get; set; }

        // 小说名
        public string Name { get; set; }

        public int? Words { get; set; }

        public string Tags { get; set; }

        public string Describe { get; set; }

        // 上传时间
        public DateTime? UpDateTime { get; set; }

        // 修改时间
        public DateTime? AmendDateTime { get; set; }

        // 1， 正在连载
        public int status { get; set; }

        // 是否删除
        public bool IsDelete { get; set; }

        // 点击数
        public int? Click { get; set; }

        // 推荐
        public int? Recommend { get; set; }

        // 文件夹名
        public string FloderName { get; set; }

        [ForeignKey("BookType")]
        // 小说类型
        public int Type_Id { get; set; }
        
        // 上传者id
        public int UpUser_Id { get; set; }

        // 封面图片
        public string CoverImg { get; set; }

        public BookType BookType { get; set; }
    }
}
