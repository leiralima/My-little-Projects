using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;

/// <summary>
/// Class to write, read, search, and edit the text file
/// </summary>
namespace ContactsBook
{
    class Archive
    {
        //private string line;
        public List<string> readFile(/*List<Contact> records*/)
        {
            List<string> records = new List<string>();
            try
            {
                string line = "line";
                //string[] str = new string[4] { "name", "phone", "email", "id" };
                //Contact person = new Contact();

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Sample.txt", true);

                //int i = 0;
                //Read the first line of text
                /*line = sr.ReadLine();
                //records.Add(line);
                str = line.Split(';');
                person.setName(str[0]);
                person.setPhone(str[1]);
                person.setEmail(str[2]);
                person.setId(str[3]);
                records.Add(person);
                //records.Insert(i, person);
                //MessageBox.Show("Name: " + str[0] + ", Phone: " + str[1] + ", Email: " + str[2] + ", ID: " + str[3], "Contact");
                //MessageBox.Show("Name: " + person.getName() + ", Phone: " + person.getPhone() + ", Email: " + person.getEmail() + ", ID: " + person.getId(), "Contact");
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //Read the next line
                    line = sr.ReadLine();
                    str = line.Split(';');
                    person.setName(str[0]);
                    person.setPhone(str[1]);
                    person.setEmail(str[2]);
                    person.setId(str[3]);
                    records.Add(person);
                    //records.Insert(i, person);
                    //i++;
                    //MessageBox.Show("Name: " + str[0]+", Phone: "+str[1]+", Email: "+str[2]+", ID: "+ str[3], "Contact");
                    //MessageBox.Show("Name: " + person.getName() + ", Phone: " + person.getPhone() + ", Email: " + person.getEmail() + ", ID: " + person.getId(), "Contact");
                }*/
                line = sr.ReadLine();
                records.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                    records.Add(line);
                }

                //close the file
                sr.Close();
                return records;
            }
            catch (Exception e)
            {
                if (records == null)
                {
                    MessageBox.Show("Exception: " + e.Message, "Exception Error");
                    return null;
                }
                else
                {
                    MessageBox.Show("Exception: " + e.Message, "Exception Error");
                    return records;
                }
                //MessageBox.Show("Exception: " + e.Message, "Exception Error");
            }
            /*finally
            {
                MessageBox.Show("Reading done.", "Reading successful");
            }*/
        }
        public void writeFile(string name, string phone, string email, string id)//Write in the file the information of the new contact
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("Sample.txt", true);

                //Write contact information
                sw.WriteLine(name + ";" + phone + ";" + email + ";" + id);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message, "Exception Error");
            }
            finally
            {
                MessageBox.Show("New contact saved.", "Success");
            }
        }
    }
}
