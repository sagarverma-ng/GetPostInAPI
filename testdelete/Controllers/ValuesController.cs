using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testdelete.DbConnection;
using System.Data.Entity;
using System.Data;
namespace testdelete.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        ProductEntities _context = new ProductEntities();
        [HttpGet]
        public dynamic Get()
        {
            List<SchoolInfo> one = _context.SchoolInfoes.Where(a => a.Id == 1).Include("Students").ToList();
            dynamic returnObj = new System.Dynamic.ExpandoObject();
            foreach (SchoolInfo item in one)
            {
                returnObj.Id = item.Id;
                returnObj.ClassName = item.ClassName;
                returnObj.Students = new List<System.Dynamic.ExpandoObject>();
                foreach (Student objSt in item.Students)
                {
                    dynamic objNewSt = new System.Dynamic.ExpandoObject();
                    objNewSt.Id = objSt.Id;
                    objNewSt.RNo = objSt.RNo;
                    objNewSt.studentName = objSt.studentName;
                    objNewSt.Marks = new List<System.Dynamic.ExpandoObject>();
                    foreach (Mark mark in objSt.Marks)
                    {
                        dynamic objMark = new System.Dynamic.ExpandoObject();
                        objMark.Id = mark.Id;
                        objMark.SubjectName = mark.SubjectName;
                        //objNewSt.Marks = new List<System.Dynamic.ExpandoObject>();
                        objNewSt.Marks.Add(objMark);
                    }
                   // returnObj.Students = new List<System.Dynamic.ExpandoObject>();
                    returnObj.Students.Add(objNewSt);
                }
            }
            return returnObj;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
