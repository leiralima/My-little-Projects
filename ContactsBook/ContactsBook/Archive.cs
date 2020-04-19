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
        private List<string> records;
        public List<string> readFile()//Read the file and each line is returned as a item on a string list
        {
            records = new List<string>();
            try
            {
                string line = "line";
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Contacts.txt", true);
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
            }
        }
        public void writeFile(string name, string phone, string email, string id)//Write in the file the information of the new contact
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("Contacts.txt", true);
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
        public void editFile(string oldStr, string newStr)
        {
            try
            {
                records = new List<string>();//list to store all the lines so later the selected one can be edited
                string line;//line to auxiliate in the construction of the records list
                StreamReader sr = new StreamReader("Contacts.txt", true);
                line = sr.ReadLine();
                if (line == oldStr)//checks if the line is the one to be edited
                {
                    line = newStr;//if it is the line is replaced by the edited string
                }
                records.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line == oldStr)
                    {
                        line = newStr;
                    }
                    records.Add(line);
                }//This is to make records to have each line of the archive as an item on the list
                sr.Close();
                System.IO.File.Delete("Contacts.txt");//deletes the old file
                StreamWriter sw = new StreamWriter("Contacts.txt", true);//makes a new one
                for (int i = 0; i < records.Count - 1; i++)//writes the new file using the list, now with the edited item
                {
                    sw.WriteLine(records[i]);
                }
                sw.Close();
                records.Clear();
                records = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message, "Exception Error");
            }
            finally
            {
                MessageBox.Show("Contact Edited.", "Edited Successfully");
            }
        }
        public void deleteLineFile(string str)
        {
            try
            {
                records = new List<string>();//list to store all the lines so later the selected one can be removed
                string line;//line to auxiliate in the construction of the records list
                StreamReader sr = new StreamReader("Contacts.txt");
                line = sr.ReadLine();
                records.Add(line);
                while(line != null)
                {
                    line = sr.ReadLine();
                    records.Add(line);
                }//This is to make records to have each line of the archive as an item on the list
                records.Remove(str);//Removes the live which matches the line selected on the ListView
                sr.Close();
                System.IO.File.Delete("Contacts.txt");//deletes the old file
                StreamWriter sw = new StreamWriter("Contacts.txt");//makes a new one
                for (int i = 0; i < records.Count - 1; i++)//writes the new file using the list, now without the deleted item
                {
                    sw.WriteLine(records[i]);
                }
                sw.Close();
                records.Clear();
                records = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message, "Exception Error");
            }
            finally
            {
                MessageBox.Show("Contact Deleted.", "Deletion Successful");
            }
        }
    }
}
