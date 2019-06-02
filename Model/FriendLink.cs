using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("FriendLink")]
    public class FriendLink
    {
        public FriendLink()
        {
            CreateDateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public string LinkName { get; set; }

        public string LinkAdress { get; set; }

        public DateTime? CreateDateTime { get; set; }

        public bool IsHeadShow { get; set; }
    }
}
