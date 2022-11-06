using System;

namespace SandboxProject
{
    public class Person
    {
        protected string _firstName = "";
        protected string _lastName = "";

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

    }



}