using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qaf_mvc.Models
{
    public class SiteData
    {
        public SiteData()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee
            {
                Id = "zhuliang",
                Name = "Zhuliang Huang",
                Title = "Managing Director",
                PhotoUrl = "images/zhuliang.jpg",
                Details = new List<string>
                {
                    "Zhuliang has been providing professional mortgage services to clients since Jan 2017. Prior to working as a mortgage broker, Zhuliang was in an analytical role, providing solutions to help SME (Small and Medium Enterprises) clients against credit risks. Zhuliang has been participated in participating in the CFA program and passed all 3 levels of CFA exams.",
                    //"With extensive experience in mortgage, in 2020, Zhuliang, together with Cofounder, Monique JIANG, formed QA Finance, and continue to provide professional services to clients overall Australia.",
                    "With extensive experience in mortgage, in 2020, Zhuliang formed QA Finance, and continue to provide professional services to clients overall Australia.",

                    "“Helping clients to achieve their financial goal has given me the most rewarding moments in my career, working with dedicated team members, we will continue to deliver, as our company name represents, Quality Assured services to more clients for their mortgage needs”"
                }
            });
        }

        public List<Employee> Employees { get; set; }
    }
}
