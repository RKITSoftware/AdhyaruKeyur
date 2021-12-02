using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users objUser = new Users
            {
                name = textBox1.Text,
                city = textBox2.Text
            };
            
            //format the doc in Binary Format.
            //BinaryFormatter bf = new BinaryFormatter();

            XmlSerializer xs = new XmlSerializer(typeof(Users));
            
            FileStream fsout = new FileStream("user.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    //serialize -set info xml format.
                    xs.Serialize(fsout, objUser);
                    label3.Text = "Object Serialized";
                }
            }
            catch
            {
                label3.Text = "An error has occured";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users objUser = new Users();

            //BinaryFormatter bf = new BinaryFormatter();
            XmlSerializer xs = new XmlSerializer(typeof(Users));
            FileStream fsin = new FileStream("user.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    objUser = (Users)xs.Deserialize(fsin);
                    label3.Text = "Object Deserialized";

                    textBox1.Text = objUser.name;
                    textBox2.Text = objUser.city;
                }
            }
            catch
            {
                label3.Text = "An error has occured";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset Button.
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
