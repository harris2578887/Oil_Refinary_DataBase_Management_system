using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilRefinery
{
    class User
    {
        int Empid;
        string Name;
        string Email;
        long Contact;
        int Salary;
        string Username;
        int departmentid;
        string departmentname;
        public User()
        {
            Empid = 0;
            Name = "";
            Email = "";
            Contact = 0;
            Salary = 0;
            Username = "";
            departmentid = 0;

        }
        public int getid()
        {
            return Empid;
        }
        public void setid(int id)
        {
            Empid = id;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string email)
        {
            Email = email;
        }
        public long getContact()
        {
            return Contact;
        }
        public void setContact(long contact)
        {
            Contact = contact;
        }
        public int getSalary()
        {
            return Salary;
        }
        public void setSalary(int salary)
        {
            Salary = salary;
        }
        public string getUsername()
        {
            return Username;
        }
        public void setUsername(string username)
        {
            Username = username;
        }
        public int getDeptid()
        {
            return departmentid;
        }
        public void setDeptid(int deptid)
        {
            departmentid = deptid;
            if (deptid == 1)
            {
                departmentname = "Sales";
            }
            else if (deptid == 2)
            {
                departmentname = "Production";
            }
            else if (deptid == 3)
            {
                departmentname = "Management";
            }
        }
        public string getdeptname()
        {
            return departmentname;
        }
    }
}
