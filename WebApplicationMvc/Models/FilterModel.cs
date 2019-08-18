using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMvc.Models
{
    public class FilterModel
    {
        public string UserName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public DateTime DateTime { get; set; }
        public string CorreltionId { get; set; }
    }
}