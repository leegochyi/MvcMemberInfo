using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Spatial;
namespace MvcMemberInfo.Models
{
    public class Info
    {
        public int ID { get; set; }
        [Display(Name = "會員ID")]
        public int MemberID { get; set; }

        [Display(Name = "會員姓名")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "會員手機號碼")]
        [RegularExpression("^09[0-9]{2}-[0-9]{3}-[0-9]{3}", ErrorMessage = "請依照此格式(09XX-XXX-XXX),輸入手機號碼")]
        public string Mobile { get; set; }

        [Display(Name = "會員生日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true),]
        public DateTime? dtmBirth { get; set; }

        [Display(Name = "資料建立日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dtmCreat { get; set; }

        [Display(Name = "資料修改日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dtmUpdate { get; set; }
    }

    public class InfoDBContext : DbContext
    {
        public DbSet<Info> Infoes { get; set; }
    }
}
