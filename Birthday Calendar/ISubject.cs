using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Calendar
{
    public interface ISubject
    {
        void notify();
        void attach(IObserver observer);
    }
}
