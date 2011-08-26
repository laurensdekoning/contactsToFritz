using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ContactsToFritzBox
{
    public partial class Form1 : Form
    {
        XmlTextWriter phBookXml;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This simple application was written bij Laurens de Koning and is 100% freeware.", "About ContactsToFritzBox", MessageBoxButtons.OK);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgOpenInputFile.ShowDialog();

            if (dlgOpenInputFile.FileName.Length > 5)
            {
                textBox1.Text = dlgOpenInputFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dlgSaveOutputFile.ShowDialog();

            if (dlgSaveOutputFile.FileName.Length > 5)
            {
                textBox2.Text = dlgSaveOutputFile.FileName;
            }
        }

        private string convertPhoneNumber(string oldPhoneNumber)
        {
            string tmpPhoneNumber;

            if (oldPhoneNumber.StartsWith("+31", true,System.Globalization.CultureInfo.CurrentCulture))
            {
                tmpPhoneNumber = "0" + oldPhoneNumber.Substring(oldPhoneNumber.Length - 9, 9);
                return tmpPhoneNumber;
            }

            return oldPhoneNumber;            
        }
        private void writeFritzPhoneBookHeader(string fileOutput)
        {
            phBookXml = new XmlTextWriter(fileOutput, null);

            phBookXml.Formatting = Formatting.Indented;
            phBookXml.WriteStartDocument();

            phBookXml.WriteStartElement("phonebooks");

            phBookXml.WriteStartElement("phonebook");
            phBookXml.WriteAttributeString("name", "Telephone Book");


            phBookXml.WriteElementString("services","");
            phBookXml.WriteElementString("setup", "");
        }

        private void writeFritzPhoneBookFooter()
        {
            phBookXml.WriteFullEndElement();
            phBookXml.Close();            
        }

        private string getPhoneNumberType(string phonenumber)
        {
            if (phonenumber.Substring(0, 2) == "06")
            {
                return "mobile";
            }

            return "home";
        }

        private void writeFritzBoxPhoneBookContact(string name, string phonenumber,int quickdial)
        {
            phBookXml.WriteStartElement("contact");

            phBookXml.WriteElementString("category","0");

            phBookXml.WriteStartElement("person");
            phBookXml.WriteElementString("realName", name);
            phBookXml.WriteEndElement();

            phBookXml.WriteStartElement("telephony");
            phBookXml.WriteStartElement("number");
            phBookXml.WriteAttributeString("type", getPhoneNumberType(phonenumber));
            phBookXml.WriteAttributeString("vanity", "");
            phBookXml.WriteAttributeString("quickdial", quickdial.ToString());
            phBookXml.WriteAttributeString("prio", "1");
            phBookXml.WriteString(phonenumber);
            phBookXml.WriteEndElement();
            phBookXml.WriteEndElement();

            phBookXml.WriteEndElement();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] csvData;
            int csvLine = 0;
            string strTmp;
            bool skipCsvHeader = true;

            StreamReader fileInput = new StreamReader(@textBox1.Text);
            
            writeFritzPhoneBookHeader(textBox2.Text);

            while (!fileInput.EndOfStream)
            {
                strTmp = fileInput.ReadLine();
                if (skipCsvHeader && csvLine > 0)
                {
                    csvData = strTmp.Split(',');
                    if (csvData.Length > 30)
                    {
                        if ((csvData[0].Length > 0) && (csvData[35].Length > 0))
                        {
                            writeFritzBoxPhoneBookContact(csvData[0], convertPhoneNumber(csvData[35]),csvLine);
                        }
                    }
                }
                csvLine++;
            }
            
            writeFritzPhoneBookFooter();
        }
    }
}
