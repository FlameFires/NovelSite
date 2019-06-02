using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("WebConfig")]
    public class WebConfig
    {
        public WebConfig()
        {
            CreateDateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        // 网站名
        public string WebName { get; set; }

        // 网站图标
        public string WebLogo { get; set; }

        // 网站介绍
        public string WebIntroduce { get; set; }

        // 版权
        public string CopyRight {get;set;}

        public string PhoneNum { get; set; }

        public string E_mail { get; set; }

        // 技术支持
        public string Support { get; set; }

        // 公司地址
        public string Address { get; set; }

        public DateTime? CreateDateTime { get; set; }
    }
}
