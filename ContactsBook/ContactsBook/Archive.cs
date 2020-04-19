using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;

/// <summary>
/// Class to write, read, search, and edit the text file
/// </summary>
/*Edit text:
var contents = System.IO.File.ReadAllText("Sample.txt");
contents = contents.Replace("Test", "Tested");
System.IO.File.WriteAllText("Sample.txt", contents);
 
//alt:
StringBuilder newFile = new StringBuilder();
StringBuilder newFile = new StringBuilder();
string temp = "";
string[] file = File.ReadAllLines(@"C:\Documents and Settings\john.grove\Desktop\1.txt");
foreach (string line in file)
{
    if (line.Contains("string"))
    {
        temp = line.Replace("string", "String");
        newFile.Append(temp + "\r\n");
        continue;
    }
    newFile.Append(line + "\r\n");
}
File.WriteAllText(@"C:\Documents and Settings\john.grove\Desktop\1.txt", newFile.ToString());*/

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
        public void editFile(string name, string phone, string email)
        {
            try
            {
                /*var contents = System.IO.File.ReadAllText("Sample.txt");
                contents = contents.Replace("Test", "Tested");
                System.IO.File.WriteAllText("Sample.txt", contents);*/
                /*records = new List<string>();//list to store all the lines so later the selected one can be removed
                string line;//line to auxiliate in the construction of the records list
                StreamReader sr = new StreamReader("Sample.txt", true);
                line = sr.ReadLine();
                records.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                    records.Add(line);
                }//This is to make records to have each line of the archive as an item on the list
                records.Remove(str);//Removes the live which matches the line selected on the ListView
                sr.Close();
                System.IO.File.Delete("Sample.txt");//deletes the old file
                StreamWriter sw = new StreamWriter("Sample.txt");//makes a new one
                for (int i = 0; i < records.Count - 1; i++)//writes the new file using the list, now without the deleted item
                {
                    sw.WriteLine(records[i]);
                }
                sw.Close();
                records.Clear();
                records = null;*/
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
                StreamReader sr = new StreamReader("Sample.txt", true);
                line = sr.ReadLine();
                records.Add(line);
                while(line != null)
                {
                    line = sr.ReadLine();
                    records.Add(line);
                }//This is to make records to have each line of the archive as an item on the list
                records.Remove(str);//Removes the live which matches the line selected on the ListView
                sr.Close();
                System.IO.File.Delete("Sample.txt");//deletes the old file
                StreamWriter sw = new StreamWriter("Sample.txt");//makes a new one
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
