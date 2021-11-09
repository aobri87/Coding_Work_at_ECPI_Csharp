using System;
using System.Windows.Forms;
using System.IO;


namespace GradeBook
{
    public partial class Grade : Form
    {
        protected int TextBoxCount { get; set; } = 5; // number of TextBoxes
        private StreamWriter fileWriter; // writes data to text file
        private StreamReader fileReader;

        //enumeration constants specify TextBox indices
        public enum TextBoxIndices { Last, First, ID, Course, Grade}
        public Grade()
        {
            InitializeComponent();
        }

        // clear all TextBoxes
        public void ClearTextBoxes()
        {
            // iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                // if Control is TextBox, clear it
                (guiControl as TextBox)?.Clear();
            }// close foreach
        }// close cleartextboxes

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
                lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
                firstNameTextBox.Text = values[(int)TextBoxIndices.First];
                idTextBox.Text = values[(int)TextBoxIndices.ID];
                courseTextBox.Text = values[(int)TextBoxIndices.Course];
                gradeTextBox.Text = values[(int)TextBoxIndices.Grade];
            } // close else
        }// CloseReason SetTextBoxValues
        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                lastNameTextBox.Text, firstNameTextBox.Text, idTextBox.Text,
                courseTextBox.Text, gradeTextBox.Text
            };
        }// close getTextBoxValues

        // handler for enterButton Click
        private void enterButton_Click(object sender, EventArgs e)
        {
            // store TextBox values string array
            string[] values = GetTextBoxValues();

            // determine whether TextBox account field is empty
            if (!string.IsNullOrEmpty(values[(int) TextBoxIndices.Last]))
            {
                // store TextBox values in Record and output it
                try
                {
                    // Record containing TextBox values to output
                    var record = new Record(values[(int)TextBoxIndices.Last],
                        values[(int)TextBoxIndices.First],
                        int.Parse(values[(int)TextBoxIndices.ID]),
                        values[(int)TextBoxIndices.Course],
                        values[(int)TextBoxIndices.Grade]);
                    //write Record to file, fields separated by commas
                    fileWriter.WriteLine(
                        $"{record.Last}, {record.First}:\t{record.ID}\t{record.Course}\t{record.Grade}");
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
        }// close enterButton handler

        private void saveButton_Click(object sender, EventArgs e)
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

                        // disable Save and load buttons and enable Enter and exit buttons
                        saveButton.Enabled = false;
                        loadButton.Enabled = false;
                        enterButton.Enabled = true;
                        exitButton.Enabled = true;
                    }// close try
                    catch (IOException)
                    {
                        // notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }// close catch
                }// close else
            }// close if
        }// close saveButton handler

        // handler for exitButton Click
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter?.Close(); // close StreamWriter and underlying file.
            } // close try
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// close catch
            Application.Exit();
        } // close exitButton handler

        private void loadButton_Click(object sender, EventArgs e)
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
                    // disable Save button and enable Exit button
                    saveButton.Enabled = false;
                    exitButton.Enabled = true;
                    // create FileStream to obtain read access to file
                    FileStream input = new FileStream(
                        fileName, FileMode.Open, FileAccess.Read);

                    // set file from where data is read
                    fileReader = new StreamReader(input);

                    string inputRecord = fileReader.ReadToEnd();

                    if (inputRecord != null)
                    {
                        textBox1.Text = inputRecord;
                    }// close if
                }// close try
                catch (IOException)
                {
                    MessageBox.Show("Error reading from file", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// close catch
            }// close else
        }
    } // close class
} // close namespace
