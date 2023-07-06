using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_114_HashTables
{
    internal class Student
    {
        private int _id;
        private string _name;
        private float _gpa;

        public Student(int id, string name, float gpa)
        { 
            this._id = id;
            this._name = name;
            this._gpa = gpa;
        }

        public int Id
        { 
            get => _id; set => _id = value;
        }

        public string Name
        {
            get => _name; set => _name = value;
        }

        public float Gpa
        {
            get => _gpa; set => _gpa = value;
        }
    }
}
