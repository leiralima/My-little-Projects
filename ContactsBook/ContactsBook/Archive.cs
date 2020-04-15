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
        public List<string> readFile()
        {
            List<string> records = new List<string>();
            try
            {
                string line = "line";

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Sample.txt", true);
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
        public void editFile()
        {
            try
            {
                //
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
        public void deleteLineFile()
        {
            try
            {
                //
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
