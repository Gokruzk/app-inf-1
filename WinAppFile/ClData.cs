using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppFile
{
    internal class ClData
    {
        string name, lastName, code;
        int age;
        public ClData() { }
        public ClData(string name, string lastName, string code, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.code = code;
            this.age = age;
        }
        public string Name { get { return name; } }
        public string LastName { get { return lastName;} }
        public int Age { get { return age;} }
        public string Code { get { return code; } }
        public void SetName(string name) { this.name = name;}
        public void SetLastName(string lastName) {  this.lastName = lastName;}
        public void SetCode(string code) {  this.code = code;}
        public void SetAge(int age) {  this.age = age;}
    }
}
