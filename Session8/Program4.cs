using System;

interface ISet
{
    void Accept Details(int valOne, string valTwo);

}
interface IGet
{
    void Display();
}

class Employee : ISet
{
    int_empID;
        string_empName;
        public void Accept Details (int valOne, string valTwo)
    {
        _empID = valOne;
        _empName = valTwo;
    }
    static void Main (string[]args)
    {
        Employee objEmployee = new Employee();
        objEmployee.Accept Details(10, "Jack");
        IGet objGet = objEmployee as IGet;
        if (objGet != null)
        {
            objGet.Display();
        }
        else
        {
            Console.WriteLine("Invalid casting occurred");
        }
    }
}
