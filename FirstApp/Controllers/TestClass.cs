using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class TestClass
    {
        private int x;

        public TestClass()
        {
            x = 15;
            First(x);
            Console.WriteLine(x);
        }

        public void First(int x)
        {
            x = 10;
            FirstNested(ref x);

        }

        public void FirstNested(ref int x)
        {
            x = 30;
            x = secondNested(ref x);
        }

        public int secondNested(ref int x)
        {
            x = 21;
            return 31;
        }
    }
}
