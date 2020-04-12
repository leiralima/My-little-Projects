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
        public List<Contact> readFile()
        {
            try
            {
                List<Contact> records = new List<Contact>();
                string line;
                string[] str;
                Contact person = new Contact();

                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader("D:\\Aranha\\Projeto e coisas\\Programas\\Repositório de Portifólio\\ContactsBook\\ContactsBook\\bin\\Debug\\netcoreapp3.1\\Sample.txt");
                StreamReader sr = new StreamReader("Sample.txt", true);

                //Read the first line of text
                line = sr.ReadLine();
                //records.Add(line);
                str = line.Split(';');
                person.setName(str[0]);
                person.setPhone(str[1]);
                person.setEmail(str[2]);
                person.setId(str[3]);
                records.Add(person);

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    //MessageBox.Show(line, "Reading lines");
                    //Read the next line
                    line = sr.ReadLine();
                    /*person.setName(line);
                    records.Add(person);*/
                    str = line.Split(';');
                    person.setName(str[0]);
                    person.setPhone(str[1]);
                    person.setEmail(str[2]);
                    person.setId(str[3]);
                    records.Add(person);
                }
                //close the file
                sr.Close();
                return records;
                //MessageBox.Show(Console.ReadLine(), "Reading lines");

                /*
                // Collection to be populated with the record data in the file
                List<Record> records = new List<Record>();
                using (FileStream fs = new FileStream("Sample.txt", FileMode.Open))
                using (StreamReader rdr = new StreamReader(fs))
                {
                    line = rdr.ReadLine();
                    while (line != null)
                    {
                        // Check if we have a new record
                        if (line.Contains(";"))
                        {
                            // We have a start of a record so create an instance of the Record class
                            Record record = new Record();

                            // Add the first line to the record
                            record.Lines.Add(line);

                            // Read the next line
                            line = rdr.ReadLine();

                            // While the line is not the start of a new record or end of the file,
                            // add the data to the current record instance
                            while (line != null && !line.Contains(";"))
                            {
                                record.Lines.Add(line);
                                line = rdr.ReadLine();
                            }

                            // Add the record instance to the record collection
                            records.Add(record);
                        }
                        else
                        {
                            // If we get here there was something unexpected
                            // So for now just move on and read the next line
                            line = rdr.ReadLine();
                        }
                    }
                }
                */
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message, "Exception Error");
                return null;
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
                sw.WriteLine(name + ";" + phone + ";" + email + ";" + id + ";");
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
