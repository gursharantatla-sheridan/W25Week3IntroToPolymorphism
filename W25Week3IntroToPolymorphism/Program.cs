namespace W25Week3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add(2, 3);
            
            //int[] arr = { 2, 3, 4 };
            //PrintArray(arr);



            // method overriding
            BaseClass objBase = new BaseClass();
            objBase.Show();

            //DerivedClass objDerived = new DerivedClass();
            //objDerived.Show();

            objBase = new DerivedClass();
            objBase.Show();


            //objDerived = new BaseClass();
        }




        // method overloading
        static void PrintArray(int[] a)
        {
            // method body
        }

        //static void PrintArray(params int[] a)
        //{
        //    // method body
        //}


        static void Add(int n1, int n2)
        {
            int sum = n1 + n2;
        }

        //static int Add(int n1, int n2)
        //{
        //    return n1 + n2;
        //}

        static void Add(string n1, string n2)
        {
            string sum = n1 + n2;
        }

        static void Add(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
        }

        static void Add(int n1, int n2, ref int n3)
        {
            int sum = n1 + n2 + n3;
        }

        
    }
}
