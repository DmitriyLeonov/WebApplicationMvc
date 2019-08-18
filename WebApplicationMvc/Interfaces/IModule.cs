using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationMvc.Interfaces
{
    public interface IModule
    {
        void Register (IUnityContainer container);
    }
}
