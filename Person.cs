using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ely_1
{
    class Person
    {
        public string _id;
        public string _name;
        public int _birth;
        public float _height;

        public Person(string id, string name, int birth, float height)
        {
            _id = id;
            _name = name;
            _birth = birth;
            _height = height;
        }
        public Person(string id)
        {
            _id = id;
        }
        public Person()
        {

        }

        public override string ToString()
        {
            string result = $"name: {_name} id: {_id} birth: {_birth} height: {_height} ";
            return result;
        }
    }
}
