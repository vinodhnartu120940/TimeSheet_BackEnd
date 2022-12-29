using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheets.API.Models
{
    public class TimeSheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EmployeeID { get; set; } 
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public string Activity { get; set; }
        public string Task { get; set; }
        public DateTime Date { get; set; }
        public int WorkHours { get; set; }
    }
}
