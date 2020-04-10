using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsBook
{
    class Contact
    {
        private string name, phone, email;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getName()
        {
            return name;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }
        public string generateID()//Generates a string that serves as an unique id
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
