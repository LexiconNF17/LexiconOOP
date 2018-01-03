using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOOP
{
    abstract class Animal
    {
        public abstract void Talk();

        public override string ToString()
        {
            return GetType().Name;
        }    
    }
}
