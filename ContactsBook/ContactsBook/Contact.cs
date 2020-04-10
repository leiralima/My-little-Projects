using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsBook
{
    class Contact
    {
        private string name, phone, email;
        //private int id;
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
        /*public void setId(int id)
        {
            this.id = id;
        }*/
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
        /*public int getId()
        {
            return id;
        }*/
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
