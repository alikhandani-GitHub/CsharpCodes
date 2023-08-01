using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_test01
{
    class Person
    {
        private String name;
        private int id;

        public Person(String name,int id)
        {
            this.name = name;
            this.id = id;
        }
        public String getName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
    }
}
