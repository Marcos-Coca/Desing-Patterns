using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{
    class UserBuilder
    {
        User _user;
        int _id;
        public UserBuilder(int id,string name)
        {
            this._user = new User(id, name);
        }

        public UserBuilder FamilyName(string familyName)
        {
            this._user.FamilyName = familyName;
            return this;
        }

        public UserBuilder Age(int age)
        {
            this._user.Age = age;
            return this;
        }
        public UserBuilder Profession(string profession)
        {
            this._user.Profession = profession;
            return this;
        }
        public User Build() => this._user;
       

    }

    class User
    {
        int _id;
        string _name;
        string _familyName;
        int _age;
        string _profession;

        public int Id { get => _id; }
        public string Name { get => _name; set => this._name = value;}
        public string FamilyName { get => _familyName; set => this._familyName = value;}
        public int Age { get => _age; set => this._age = value; }
        public string Profession { get => _profession; set => this._profession = value; }

        
        public User(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
}
