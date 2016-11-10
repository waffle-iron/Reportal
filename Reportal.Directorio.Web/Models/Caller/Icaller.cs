using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Web.Models.Caller
{
    public interface Icaller
    {
        List<T> Get<T>();
        T Get<T>(int id);
        void Create<T>(T o);
        void Update<T>(int id, T o);
        void Delete(int id);
    }
}