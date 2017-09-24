using DNP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormMath
{
    public partial class Form1 : Form
    {
        private MathLib lib = new MathLib();
        private double a;
        private double b;
        private bool parsable = false;
        private const string ADDITION = "+", SUBTRACTION = "-", MULTIPLICATION = "*", DIVISION = "/";

        public Form1()
        {
            InitializeComponent();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            calculate(ADDITION);
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            calculate(SUBTRACTION);
        }
        private void mul_btn_Click(object sender, EventArgs e)
        {
            calculate(MULTIPLICATION);
        }
        private void div_btn_Click(object sender, EventArgs e)
        {
            calculate(DIVISION);
        }
        private void clr_btn_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void clear_list_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void save_list_btn_Click(object sender, EventArgs e)
        {
             //openSaveFileDialog();
            
            createXML();
        }

        private void read_list_btn_Click(object sender, EventArgs e)
        {
            readList();
        }


        private void stress_test_btn_Click(object sender, EventArgs e)
        {

        }
        private void convert_A_B()
        {

            double parsedValue;
            if (!double.TryParse(first_number.Text, out parsedValue)
                || !double.TryParse(second_number.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
            else
            {
                a = double.Parse(first_number.Text);
                b = double.Parse(second_number.Text);
                parsable = true;
            }
        }
        private void calculate(string operation)
        {
            double result = 0;
            convert_A_B();
            if (parsable)
            {
                if (operation == ADDITION)
                {
                    result = lib.double_addition(a, b);
                }
                else if (operation == SUBTRACTION)
                {
                    result = lib.double_subtraction(a, b);

                }
                else if (operation == MULTIPLICATION)
                {
                    result = lib.double_multiplication(a, b);

                }
                else if (operation == DIVISION)
                {
                    result = lib.double_division(a, b);

                }
                addToListBox(operation, result);
            }
        }
        private void addToListBox(string operation, double result)
        {
            string item = a + " " + operation + " " + b + " = " + result;
            listBox1.Items.Add(item);
            reset();

        }
        private void reset()
        {
            first_number.Text = "";
            second_number.Text = "";
            parsable = false;

        }





        private void createXML()
        {
            List<Object> list = listBox1.Items.OfType<Object>().ToList();
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("mathematics");
            xmlDoc.AppendChild(rootNode);

            foreach (Object item in list)
            {
                XmlNode node = xmlDoc.CreateElement("operation");
                // XmlAttribute attribute = xmlDoc.CreateAttribute("Addition");
                //attribute.Value = "add";
                // userNode.Attributes.Append(attribute);
                node.InnerText = item.ToString();
                rootNode.AppendChild(node);
            }
            xmlDoc.Save(@"D:\GitHub\DNP1\WinFormMath\operationsExecuted.xml");
        }

        private void openSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML XML|*.xml";
            saveFileDialog.Title = "Save an XML File";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream fs = File.Open(saveFileDialog.FileName, FileMode.CreateNew)) ;
             
                  createXML();

                 //fs.Close();
            }
        }

        private void readList()
        {
            XmlTextReader reader;
            reader = new XmlTextReader(@"D:\GitHub\DNP1\WinFormMath\operationsExecuted.xml");
            //reader = new XmlTextReader("addressbook.xml");
            listBox1.Items.Clear();
            while (reader.Read())
            {
                if (reader.IsStartElement("operation"))
                {
                    reader.Read();  //  read the name
                                    // Console.Write("{0}, ", r.Value);
                    listBox1.Items.Add(reader.Value);
                }
            }
            reader.Close();
        }
    }
}
