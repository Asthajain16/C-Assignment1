using System;

namespace employeedetails
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var employee=new Employee(1,"","");
           employee.IdMethod+= OncalledId;
           employee.NameMethod+= OncalledName;
           employee.DepartmentNameMethod+= OncalledDepartment;
           



            while(true)
            {
                Console.WriteLine("Enter id or 'q' to quit:");
                var input1=Console.ReadLine();
                if(input1=="q")
                {
                    break;
                }
                var ids=double.Parse(input1);

                Console.WriteLine("Enter name:");
                var input2=Console.ReadLine();
               
                

                Console.WriteLine("Enter department name");
                var input3=Console.ReadLine();
                
                
                Console.WriteLine($"Id:{employee.GetId(ids)}");
                Console.WriteLine($"Name:{employee.GetName(input2)}");
                Console.WriteLine($"Department Name:{employee.GetDepartmentName(input3)}\n");
            }

            Console.WriteLine("\tEnter 'u' to update or 'q' to terminate program:");
            var input4=Console.ReadLine();
            if(input4=="u")
            {
                while(true)
                {
                Console.WriteLine("Enter id or 'q' to quit:");
                var input5=Console.ReadLine();
                if(input5=="q")
                {
                    break;
                }
                var ids=double.Parse(input5);

                Console.WriteLine("Enter name:");
                var input6=Console.ReadLine();
                

                Console.WriteLine("Enter department name");
                var input7=Console.ReadLine();
                
                Console.WriteLine($"Id:{employee.Updating(ids)}");
                Console.WriteLine($"Name:{employee.Updating(input6)}");
                Console.WriteLine($"Department Name:{employee.Updating(input7)}");

                Console.WriteLine("\n\t\t\tUpdated Successfully!\n");
                }
            }
           
        }
        static void OncalledId (object sender,EventArgs e)
        {
          Console.WriteLine("GetId() method called");
        }
        static void OncalledName (object sender,EventArgs e)
        {
          Console.WriteLine("GetName() method called");
        }
        static void OncalledDepartment (object sender,EventArgs e)
        {
          Console.WriteLine("GetDepartmentName() method called");
        }
    }
}
