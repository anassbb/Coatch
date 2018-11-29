using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        CoachITContext Get();
    }

}
