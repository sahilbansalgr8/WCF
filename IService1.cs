[ServiceContract]

    public interface IService1

    {

        [OperationContract]

       int add(int a,int b);

 

        [OperationContract]

       int Sub(int a, int b);

 

        [OperationContract]

        int Mul(int a, int b);

 

        [OperationContract]

        int Div(int a, int b);

 

        // TODO: Add your service operations here

    }
