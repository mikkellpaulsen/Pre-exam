using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_action_linq
{
    public class Mydelegate
    {
        MyDel _writer;
        Manager manager = new Manager();
        Employee employee = new Employee();

        public Mydelegate()
        {
            _writer = new MyDel(manager.write);
            _writer("Invoked igennem parameter \n");

            _writer += employee.write;
            _writer("Invoked fra invocationlist ved tilføjes til den \n");

            //Fjerner alt fra invocation listen.
            //_writer = null;
        }
    }
}
