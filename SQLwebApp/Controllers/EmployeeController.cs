using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SQLwebApp.Models;
using AccessData;

namespace SQLwebApp.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            using (CompanyDBEntities entities = new CompanyDBEntities())
            {
                return entities.Employees.ToList();
            }
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            using (CompanyDBEntities entities = new CompanyDBEntities())
            {
                return entities.Employees.FirstOrDefault(e=>e.EmployeeId == id);
            }
        }

        // POST: api/Employee
        public HttpResponseMessage Post([FromBody]Employee value)
        {
            try
            {
                using (CompanyDBEntities entities = new CompanyDBEntities())
                {
                    entities.Employees.Add(value);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created,value);
                    message.Headers.Location = new Uri(Request.RequestUri + value.EmployeeId.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
