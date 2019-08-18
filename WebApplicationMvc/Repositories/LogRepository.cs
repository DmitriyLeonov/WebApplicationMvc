using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMvc.Interfaces;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Repositories
{
    public class LogRepository : ILogInterface
    {
        private readonly MyContext _context;
        
        public LogRepository(MyContext context)
        {
            _context = context;
        }

        public void Insert(FilterModel model)
        {
            _context.LogFilter.Add(model);
            _context.SaveChanges();
        }
    }
}