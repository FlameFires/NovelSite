using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Tags
    {
        public Tags()
        {

        }

        [Key]
        public int Id { get; set; }

        // 标签名
        public string Name { get; set; }

        public DateTime? CreateDateTime { get; set; }

        // 头部显示
        public bool IsHeadShow { get; set; }
    }
}
