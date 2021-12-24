using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Repository
{
    public class StudentRepository : GenericRepository<Student>
    {
        public List<Student> Search(string name)
        {
            if(string.IsNullOrEmpty(name)) return null;
            var studens = this.SelectAll().ToList(); 
            //Get student by firstname or last name
            return studens.Where(item => item.FirstName.ToLower().Contains(name.ToLower()) || item.LastName.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}