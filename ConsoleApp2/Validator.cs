using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public abstract class Validator<T> where T : class
    {

        protected Validator<T>? NextValidator { get; set; }

        public Validator<T> SetNext(Validator<T> next)
        {
            NextValidator = next;
            return next;
        }

        public virtual bool Handle(T request)
        {
            if (NextValidator != null)
            {
                return NextValidator.Handle(request);
            }
            return true;  
        }
    }
}
