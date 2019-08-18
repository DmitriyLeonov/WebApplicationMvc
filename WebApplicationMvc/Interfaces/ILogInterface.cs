using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Interfaces
{
    public interface ILogInterface
    {
        void Insert(FilterModel model);
    }
}
