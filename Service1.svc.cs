public class Service1 : IService1

    {

       

        int IService1.add(int a, int b)

        {

            return (a + b);

        }

 

        int IService1.Sub(int a, int b)

        {

            if (a >= b)

            {

                return (a - b);

            }

            else

            {

                return (b - a);

            }

        }

       

       

        public int Mul(int a, int b)

        {

            return (a * b);

        }

 

        public int Div(int a, int b)

        {

            if(a>=b)

                try { return (a / b); }

                catch

                { return 0; }

            else

                return (b / a);

        }

    }
