using TimeSheets.API.Data;
using TimeSheets.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TimeSheets.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeSheetsController : Controller
    {
        private readonly TimeSheetsDbContext timeSheetsDbContext;
        public TimeSheetsController(TimeSheetsDbContext TimeSheetsDbContext)
        {
            this.timeSheetsDbContext = TimeSheetsDbContext;
        }

        //Post TimeSheet
        //[HttpPost]
        //public async Task<IActionResult> PostTimeSheet(TimeSheet timeSheet)
        //{
        //    //timeSheet.EmployeeID = timeSheet.EmployeeID;
        //    await timeSheetsDbContext.TimeSheets.AddAsync(timeSheet);
        //    await timeSheetsDbContext.SaveChangesAsync();
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> PostTimeSheet(List<TimeSheet> timeSheets)
        {
            foreach (var item in timeSheets)
            {
                var timeSheet = new TimeSheet();
                timeSheet.EmployeeID = item.EmployeeID;
                timeSheet.EmployeeName = item.EmployeeName;
                timeSheet.ProjectName = item.ProjectName;
                timeSheet.Activity = item.Activity;
                timeSheet.Task = item.Task;
                timeSheet.Date = item.Date;
                timeSheet.WorkHours = item.WorkHours;
                await timeSheetsDbContext.TimeSheets.AddAsync(timeSheet);
                //timeSheetsDbContext.SaveChanges();
            }
            timeSheetsDbContext.SaveChanges();
            //await timeSheetsDbContext.TimeSheets.AddAsync(timeSheet);
            //await timeSheetsDbContext.SaveChangesAsync();  
            return Ok();

        }        

        //Get TimeSheets
        [HttpGet]
        public async Task<IActionResult> GetTimeSheets()
        {
            var TimeSheets = await timeSheetsDbContext.TimeSheets.ToListAsync();
            return Ok(TimeSheets);
        }

        //Get TimeSheet
        [HttpGet]
        [Route("{EmployeeID}")]
        public async Task<IActionResult> GetTimeSheet([FromRoute] int EmployeeID)
        {
            //var timeSheet = await timeSheetsDbContext.TimeSheets.FirstOrDefaultAsync(x => x.EmployeeID == EmployeeID);
            var timeSheet = await timeSheetsDbContext.TimeSheets.Where(x => x.EmployeeID == EmployeeID).ToListAsync();
            if (timeSheet != null)
            {
                return Ok(timeSheet);
            }

            return NotFound("Card not found");
        }

        [HttpGet]
        [Route("{EmployeeID}/{Date}")]
        public async Task<IActionResult> GetTimeSheet1([FromRoute] int EmployeeID, string Date)
        {
            var timeSheet = await timeSheetsDbContext.TimeSheets.Where(x => x.EmployeeID == EmployeeID && x.Date == Date).ToListAsync();
            if (timeSheet != null)
            {
                return Ok(timeSheet);
            }

            return NotFound("Card not found");
        }
    }
}
