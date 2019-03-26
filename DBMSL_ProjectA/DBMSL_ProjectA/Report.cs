using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSL_ProjectA
{
    class Report
    {
        private string title;
        private string mainAdvisor;
        private string coAdvisor;
        private string industryAdvisor;
        private string member1;
        private string member2;
        private string member3;
        private string member4;

        public string Title { get => title; set => title = value; }
        public string MainAdvisor { get => mainAdvisor; set => mainAdvisor = value; }
        public string CoAdvisor { get => coAdvisor; set => coAdvisor = value; }
        public string IndustryAdvisor { get => industryAdvisor; set => industryAdvisor = value; }
        public string Member1 { get => member1; set => member1 = value; }
        public string Member2 { get => member2; set => member2 = value; }
        public string Member3 { get => member3; set => member3 = value; }
        public string Member4 { get => member4; set => member4 = value; }
    }
}
