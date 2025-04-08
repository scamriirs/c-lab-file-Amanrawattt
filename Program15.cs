using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

public class XmlReaderForm : Form
{
    public XmlReaderForm()
    {
        TextBox textBox = new TextBox { Multiline = true, Dock = DockStyle.Fill, ReadOnly = true };
        Controls.Add(textBox);
        LoadXmlData(textBox);
    }

    private void LoadXmlData(TextBox textBox)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml"); // Ensure data.xml exists
        textBox.Text = doc.OuterXml;
    }
    
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new XmlReaderForm());
    }
}
