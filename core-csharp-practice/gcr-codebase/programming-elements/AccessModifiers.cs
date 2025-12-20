using System;
using ProjectA;


namespace ProjectA
{
    public class BaseClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("Public Method: Accessible Everywhere");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method: Only inside BaseClass");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method: Accessible in Derived Classes");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method: Only within same assembly");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method: Same Assembly OR Derived Class");
        }

        // private protected void PrivateProtectedMethod()
        // {
        //     Console.WriteLine("Private Protected Method: Derived + Same Assembly Only");
        // } 
    }
    //  created a derived class in same assembly named  subclass
    public class SubClass : BaseClass
    {
        public void AccesingMethods()
        {
            PublicMethod(); // it is accessible 
            ProtectedMethod(); // accessible if inherited
            InternalMethod(); // only accessible if in same assssembly
            ProtectedInternalMethod(); // outside the class but in same assembly or derived class
            // PrivateProtectedMethod();  , only accesible if there is in inherit relation in classes of same assembly
            // PrivateMethod(); // not accessible , it is not acccesible outside the class
        }
    }
}

namespace ProjectB
{
    public class AnotherClass : BaseClass
    {
        public void AccessingMethods()
        {
            PublicMethod();
            ProtectedMethod(); // accessible if inherited
            ProtectedInternalMethod(); // accessible because it is derived class
            // InternalMethod(); // not allowed , this is in different assembly
            // PrivateProtectedMethod(); // not allowed , outside the class this is in different assembly
            // PrivateMethod(); // not accessible , it is not acccesible outside the class

        }
    }

    public class AccessModifiers
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
             Console.WriteLine("Accessing methods from Base Class in different assembly :");
            obj.PublicMethod();             
            obj.InternalMethod();              
            obj.ProtectedInternalMethod();     

            // obj.ProtectedMethod();        is not allowed because not in inherit relation  
            // obj.PrivateProtectedMethod();   is not allowed because not in inherit relation
            // obj.PrivateMethod();            is not accessible outside the class

            AnotherClass AnotherObj = new AnotherClass();
            Console.WriteLine("\nAccessing methods from Derived Class in different assembly :");
            AnotherObj.AccessingMethods();

            SubClass subObj = new SubClass();
            Console.WriteLine("\nAccessing methods from Derived Class in same assembly :");
            subObj.AccesingMethods();
            
        }
    }
    
}