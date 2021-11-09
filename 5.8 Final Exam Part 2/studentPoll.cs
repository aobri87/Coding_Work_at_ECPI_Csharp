// Name: Andrew O'Brien
// Date: 19 July 2021
// studentPoll.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5._8_Final_Exam_Part_2
{
    public partial class studentPoll : Form
    {
        protected int TextBoxCount { get; set; } = 1; // number of TextBoxes
        private StreamWriter fileWriter; // writes data to text file
        private StreamReader fileReader;
        public int[] freq = new int[11]; // create array of frequecnty counters
        public string i = null;

        //enumeration constants specify TextBox indices
        public enum TextBoxIndices { inputTxt }
        public studentPoll()
        {
            InitializeComponent();
        } // end studentPoll()
        
        // clear all TextBoxes
        public void ClearTextBoxes()
        {
            // iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                // if Control is TextBox, clear it
                (guiControl as TextBox)?.Clear();
            }// end foreach
        }// end cleartextboxes

        //set text box values to string-array values
        public void SetTextBoxValues(string[] values)
        {
            //determine whether string array has correct length
            if (values.Length != TextBoxCount)
            {
                // throw exception if not correct length
                throw (new ArgumentException(
                    $"There must be {TextBoxCount} strings in the array", nameof(values)));
            } // close if
            else // set array values if array has correct length
            {
                // set array values to TextBox values
                inputTxt.Text = values[(int)TextBoxIndices.inputTxt];
            } // close else
        }// CloseReason SetTextBoxValues

        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                inputTxt.Text
            };
        }// close getTextBoxValues

        // handler for enter key Click
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // if enter key is pressed
            if (e.KeyChar == (char)13)
            {
                if(i == null)
                {
                    //create and show dialog box enabling user to save file
                    DialogResult result; // result of SaveFileDialog
                    string fileName; // name of file containing data

                    using (var fileChooser = new SaveFileDialog())
                    {
                        fileChooser.CheckFileExists = false; // let user create file
                        result = fileChooser.ShowDialog();
                        fileName = fileChooser.FileName; // name of file to save data
                    } // close using
                      // ensure that user clicked "OK"
                    if (result == DialogResult.OK)
                    {
                        // show error if user specified invalid file
                        if (string.IsNullOrEmpty(fileName))
                        {
                            MessageBox.Show("Invalid File Name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }// close if
                        else
                        {
                            //save file via FileStream
                            try
                            {
                                // open file with write access
                                var output = new FileStream(fileName,
                                    FileMode.OpenOrCreate, FileAccess.Write);

                                // sets file to where data is written
                                fileWriter = new StreamWriter(output);

                                i = "a";

                            }// close try
                            catch (IOException)
                            {
                                // notify user if file does not exist
                                MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }// close catch
                        }// close else
                    }// close if
                }// end if 
                // store TextBox values string array
                string[] values = GetTextBoxValues();

                // determine whether TextBox account field is empty
                if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.inputTxt]))
                {
                    // store TextBox values in Record and output it
                    try
                    {
                        // Record containing TextBox values to output
                        var record = new Record(int.Parse(values[(int)TextBoxIndices.inputTxt]));

                        freq[record.Rating] = freq[record.Rating] + 1; 

                       
                    }// close try
                    catch (IOException)
                    {
                        MessageBox.Show("Error Writing to File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // close catch
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid Format", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // close catch
                }// close if
                ClearTextBoxes();
            } // end if
        } // end enter key handler

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
             {
                for(var rate = 1; rate< 11; ++rate)
                {   
                    //write Record to file
                    fileWriter.WriteLine(
                        $"{rate}\t{freq[rate]}");
                }
                  

                fileWriter?.Close(); // close StreamWriter and underlying file.

                // disable Save and load buttons and enable Enter and exit buttons
                btnDone.Enabled = false;
            } // close try
             catch (IOException)
             {
                 MessageBox.Show("Cannot close file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
             }// close catch
        } // end btnDone handler

        private void btnResults_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file
            DialogResult result; // result of OpenFileDialog
            string fileName; // name of file containing data

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified name
            }// close using

            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                ClearTextBoxes();
            }// close if

            // show error if user specified invalid file
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid File Name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// close if
            else
            {
                try
                {
                    // create FileStream to obtain read access to file
                    FileStream input = new FileStream(
                        fileName, FileMode.Open, FileAccess.Read);

                    // set file from where data is read
                    fileReader = new StreamReader(input);

                    string inputRecord = fileReader.ReadToEnd();

                    if (inputRecord != null)
                    {
                        string newLine = Environment.NewLine;
                        txtbxResults.Text = "Rating\t Frequency" + newLine + inputRecord;
                    }// close if
                }// close try
                catch (IOException)
                {
                    MessageBox.Show("Error reading from file", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// close catch
            }// close else
        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            this.inputTxt.KeyPress += new
            System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }
    } // end class studentPoll : Form
} // end namespace
