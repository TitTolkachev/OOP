using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Person
    {
        int name;
        int surname;
        DateTime birthday;
        string sex;
        int selfTime;
        int number;

        public abstract void AddPoints();
        public abstract void RemovePoints();
    }
}
