using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmployeeName { get; set; }

        public int FileInfoID { get; set; }

        [ForeignKey("FileInfoID")]
        public virtual ICollection<FileInfo> FileInfos { get; set; }
    }
}
