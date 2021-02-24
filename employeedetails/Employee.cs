

using System;
using System.Collections.Generic;
using System.Linq;

namespace employeedetails
{
    public delegate void IdMethodDelegate(Object sender,EventArgs args);
    public delegate void NameMethodDelegate(Object sender,EventArgs args);
    public delegate void DepartmentNameMethodDelegate(Object sender,EventArgs args);
    public class Employee
    {
        public Employee(double id,string name, string departmentname)
        {
            
         
           Id=id;
           Name=name;
           DepartmentName=departmentname; 
             
           
        }

        public double Updating(double a)
        {   
            var g=new List<double>();
            g.Add(a);

            return a;
        }

        public string Updating(string b)
        {
            var g=new List<string>();
            g.Append(b);

            return b;
        }

        public object Updating(object c)
        {
             var g=new List<object>();
            g.Append(c);

            return c;
        }


       
        public double GetId(double idss)
        {   
             Id=idss;
             if(IdMethod!=null) 
            {
              IdMethod(this, new EventArgs());  
            }
            return Id;   
            
      
        }
       
        public event IdMethodDelegate IdMethod;  

        public string GetName(string names)
        {
            Name=names;
             if(NameMethod!=null) 
            {
              NameMethod(this, new EventArgs());  
            }
            return Name;
        }
        public event NameMethodDelegate NameMethod; 

        public string GetDepartmentName(string dept)
        {
            DepartmentName=dept;
            if(DepartmentNameMethod!=null) 
            {
              DepartmentNameMethod(this, new EventArgs());  
            }
            return DepartmentName;
        }
        public event DepartmentNameMethodDelegate DepartmentNameMethod; 

        public double Id
        {
            get; set;
        }
        

        public string Name
        {
            get; set;
        }

        public string DepartmentName
        {
            get; set;
        }
            
    
    }
}