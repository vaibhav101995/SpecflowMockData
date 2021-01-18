using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPICore.Data;
using WebAPICore.Models;


namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class LeaveDetailsController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public LeaveDetailsController(EmployeeContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IEnumerable<LeaveDetails> GetLeaveDetails()
        //{
        //    return _context.LeaveDetails;
        //}

        [HttpGet]
        public IEnumerable<LeaveDetails> GetLeaveDetails()
        {
           // return b;
            return _context.LeaveDetails.FromSql<LeaveDetails>("spGetLeaveDetails").ToList();
        }

        [HttpGet("{id}")]
        public IEnumerable<LeaveDetails> GetLeaveDetail([FromRoute] long id)
        {
            MailController x = new MailController();
            x.Send_LeaveRequestMail();

            var leaveDetail = _context.LeaveDetails.FromSql<LeaveDetails>("spGetLeaveDetailsByEmployeeID {0}", id).ToList();

            return leaveDetail;
        }

        [HttpPost]
        public async Task<IActionResult> PostLeaveDetails([FromBody] LeaveDetails leaveDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.LeaveDetails.Add(leaveDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLeaveDetails", new { id = leaveDetails.LeaveID }, leaveDetails);
        }

        [HttpPut("{id}/{leaveStatus}")]
        public void PutLeaveDetails([FromRoute] long id, [FromRoute] string leaveStatus)
        {
            //var para[] = new SqlParameter { ("p0", id), ("p1", leaveStatus )};
            _context.Database.ExecuteSqlCommand("spUpdateLeaveStatus @p0, @p1",id,leaveStatus);
            ////var leavedetail = new Department();
            ////department.Name = txtDepartment.text.trim();
            ////db.Departments.add(department);
            ////db.SaveChanges();
            ////// EF will populate department.DepartmentId
            //_context.UpdateLeaveStatus.FromSql<UpdateLeaves>("spUpdateLeaveStatus {0}{1}", id, leaveStatus);
            _context.SaveChanges();

        }

        

    }
}