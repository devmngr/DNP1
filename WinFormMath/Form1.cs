using DNP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormMath
{
    public partial class Form1 : Form
    {
        private MathLib lib = new MathLib();
        private double a=0;
        private double b=0;
        private bool parsable = false;
        private const string ADDITION = "+", SUBTRACTION = "-", MULTIPLICATION = "*", DIVISION = "/";
        private bool threadRunning =true;

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
             openSaveFileDialog();
            
        }

        private void read_list_btn_Click(object sender, EventArgs e)
        {
            openFileDialogBox();
        }


        private void stress_test_btn_Click(object sender, EventArgs e)
        {
            new Thread(ThreadEngine).Start();
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
                Console.WriteLine(result);
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





        private void createXML(string path)
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
            


            xmlDoc.Save(path);
        }

        private void openSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML XML|*.xml";
            saveFileDialog.Title = "Save an XML File";

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                

                System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog.OpenFile();
           string path = Path.GetFullPath(saveFileDialog.FileName);
                fs.Close();
                createXML(path);
               
            }

            
       
        }

        private void openFileDialogBox()
        {
            string path ="";
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\GitHub\\DNP1\\WinFormMath";
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        path = openFileDialog.FileName;
                        readList(path);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Error: " + ex.Message);
                }

            }
            stream.Close();
        }
        private void readList(string path)
        {
            XmlTextReader reader;
            // reader = new XmlTextReader(@"D:\GitHub\DNP1\WinFormMath\operationsExecuted.xml");
            reader = new XmlTextReader(path);
             //reader = new XmlTextReader("operationsExecuted.xml");
             listBox1.Items.Clear();
            while (reader.Read())
            {
                if (reader.IsStartElement("operation"))
                {
                    //Read operation
                    reader.Read();
                    //add it to the listBox
                    listBox1.Items.Add(reader.Value);
                }
            }
            reader.Close();
        }
        void ThreadEngine()
        {
            while (threadRunning)
            {
                string total = "";
                Random r = new Random();
                double t1 = r.Next(100);
                double t2 = r.Next(100);
                double result = 0;
                int whichMethod = r.Next(4);
                switch (whichMethod)
                {
                    case 0:
                        {
                            result = lib.double_addition(t1, t2);
                            string s = t1.ToString() + " + " + t2.ToString() + " = " + result.ToString();
                            total = s;
                            break;
                        }
                    case 1:
                        {
                            result = lib.double_subtraction(t1, t2);
                            string s = t1.ToString() + " - " + t2.ToString() + " = " + result.ToString();
                            total = s;
                            break;
                        }
                    case 2:
                        {
                            result = lib.double_multiplication(t1, t2);
                            string s = t1.ToString() + " * " + t2.ToString() + " = " + result.ToString();
                            total = s;
                            break;
                        }
                    case 3:
                        {
                            if (t2 > 0)
                            {
                                result = lib.double_division(t1, t2);
                                string s = t1.ToString() + " / " + t2.ToString() + " = " + result.ToString();
                                total = s;
                            }
                            break;
                        }
                }

                // this.textBox3.Text = total; OOPS cross thread exception will arise!!

                if (this.InvokeRequired)
                {
                    MethodInvoker del = delegate { this.listBox1.Items.Add(total); };
                    this.Invoke(del);
                }
                else
                {
                    this.listBox1.Items.Add(total);
                }

                Thread.Sleep(500);
            }
        }
        /*
            private void run_Stress()
            {

                Random random = new Random();
                a = random.Next(100,1000);
                b = random.Next(0,100);
                int operation = random.Next(0, 4);



                switch (operation)
                {
                    case 0:
                        calculate(ADDITION);
                        break;
                    case 1:
                        calculate(SUBTRACTION);
                        break;
                    case 2:
                        calculate(MULTIPLICATION);
                        break;
                    case 3:
                        calculate(DIVISION);
                        break;

                    default:
                        break;
                }
                Thread.Sleep(1000);



            }
            */
    }
}
