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

namespace test
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument;
        string path = Directory.GetCurrentDirectory() + "\\test.xml";
        public Form1()
        {
            InitializeComponent();
            xmlDocument = new XmlDocument();
            loadXmlOnInit();
        }

        public void loadXmlOnInit()
        {
            if (File.Exists(path))
            {
                try
                {
                    xmlDocument.Load(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading xml file" + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("days");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(path);
            }
        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            string resolt = "";
            string deyWiks = DeyOfWik(cmbDeyOfWik.Text);
            string deyNanth = DeyOfManth(cmbDeyOfManth.Text);
            string yer = years(cmbYear.Text);
            string manth = cmbManth.Text;
            XmlNode day = xmlDocument.CreateElement("day");

            day.AppendChild(xmlDocument.CreateElement("dayOfWik")).InnerText = cmbDeyOfWik.Text;
            day.AppendChild(xmlDocument.CreateElement("DeyOfManth")).InnerText = cmbDeyOfManth.Text;
            day.AppendChild(xmlDocument.CreateElement("manth")).InnerText = cmbManth.Text;
            day.AppendChild(xmlDocument.CreateElement("year")).InnerText = cmbYear.Text;
            day.AppendChild(xmlDocument.CreateElement("resolt")).InnerText = deyWiks + deyNanth + manth + yer;

            xmlDocument.FirstChild.AppendChild(day);
            
            if (cmbDeyOfManth.Text ==  "30")
            {
                 resolt = deyWiks + "\n" + deyNanth + "\n"  + yer;
            }
            else
            {
                 resolt = deyWiks + "\n" + deyNanth + " " + manth + " " + yer;
            }
            
            xmlDocument.Save(path);
            label6.Text = resolt;
            
        }

        public string DeyOfWik(string deyWiks)
        {            
            string deyWik = "";
            switch (deyWiks)
            {
                case "ראשון":
                    deyWik = "באחד בשבת";
                    break;
                case "שני":
                    deyWik = "בשני בשבת";
                    break;
                case "שלישי":
                    deyWik = "בשלישי בשבת";
                    break;
                case "רביעי":
                    deyWik = "ברביעי בשבת";
                    break;
                case "חמישי":
                    deyWik = "בחמישי בשבת";
                    break;
                case "שישי":
                    deyWik = "בששי בשבת";
                    break;
            }
            return deyWik;
        }
        public string DeyOfManth(string dayManths)
        {
            string deyManth = "";
            switch (dayManths)
            {
                case "1":
                    deyManth = "יום אחד לירח";
                    break;
                case "2":
                    deyManth = "שני ימים לירח";
                    break;
                case "3":
                    deyManth = "שלשה ימים לירח";
                    break;
                case "4":
                    deyManth = "ארבעה ימים לירח";
                    break;
                case "5":
                    deyManth = "חמשה  ימים לירח";
                    break;
                case "6":
                    deyManth = "ששה ימים לירח";
                    break;
                case "7":
                    deyManth = "שבעה ימים לירח";
                    break;
                case "8":
                    deyManth = "שמונה ימים לירח";
                    break;
                case "9":
                    deyManth = "תשעה ימים לירח";
                    break;
                case "10":
                    deyManth = "עשרה ימים לירח";
                    break;
                case "11":
                    deyManth = "אחד עשר יום לירח";
                    break;
                case "12":
                    deyManth = "שנים עשר יום לירח";
                    break;
                case "13":
                    deyManth = "שלשה עשר יום לירח";
                    break;
                case "14":
                    deyManth = "ארבעה עשר יום לירח";
                    break;
                case "15":
                    deyManth = "חמשה עשר יום לירח";
                    break;
                case "16":
                    deyManth = "ששה עשר יום לירח";
                    break;
                case "17":
                    deyManth = "שבעה עשר יום לירח";
                    break;
                case "18":
                    deyManth = "שמנה עשר יוז לירח";
                    break;
                case "19":
                    deyManth = "תשעה עשר יום לירח";
                    break;
                case "20":
                    deyManth = "עשרים יום לירח";
                    break;
                case "21":
                    deyManth = "אחד ועשרים יום לירח";
                    break;
                case "22":
                    deyManth = "שנים ועשרים יום לירח";
                    break;
                case "23":
                    deyManth = "שלשה ועשרים יום לירח";
                    break;
                case "24":
                    deyManth = "ארבעה ועשרים יום לירח";
                    break;
                case "25":
                    deyManth = "חמשה ועשרים יום לירח";
                    break;
                case "26":
                    deyManth = "ששה ועשרים יום לירח";
                    break;
                case "27":
                    deyManth = "שבעה ועשרים יום לירח";
                    break;
                case "28":
                    deyManth = "שמונה ועשרים יום לירח";
                    break;
                case "29":
                    deyManth = "תשעה ועשרים יום לירח";
                    break;
                case "30":
                    switch (cmbManth.Text)
                    {
                        case "תשרי":
                            deyManth = "יום שלשים לחדש תשרי שהוא ראש חודש חשוון";
                            break;
                        case "חשוון":
                            deyManth = "יום שלשים לחדש חשוון שהוא ראש חודש כסליו";
                            break;
                        case "כסליו":
                            deyManth = "יום שלשים לחדש כסליו שהוא ראש חודש טבת";
                            break;
                        case "טבת":
                            deyManth = "יום שלשים לחדש טבת שהוא ראש חודש שבט";
                            break;
                        case "שבט":
                            deyManth = "יום שלשים לחדש שבט שהוא ראש חודש אדר";
                            break;
                        case "אדר":
                            deyManth = "יום שלשים לחדש אדר שהוא ראש חודש ניסן";
                            break;
                        case "אדר הראשון":
                            deyManth = "יום שלשים לחדש אדר הראשון שהוא ראש חודש אדר השני";
                            break;
                        case "אדר השני":
                            deyManth = "יום שלשים לחדש אדר השני שהוא ראש חודש ניסן";
                            break;
                        case "ניסן":
                            deyManth = "יום שלשים לחדש ניסן שהוא ראש חודש אייר";
                            break;
                        case "אייר":
                            deyManth = "יום שלשים לחדש אייר שהוא ראש חודש סיון";
                            break;
                        case "סיון":
                            deyManth = "יום שלשים לחדש סיון שהוא ראש חודש תמוז";
                            break;
                        case "תמוז":
                            deyManth = "יום שלשים לחדש תמוז שהוא ראש חודש אב";
                            break;
                        case "אב":
                            deyManth = "יום שלשים לחדש אב שהוא ראש חודש אלול";
                            break;
                        case "אלול":
                            deyManth = "יום שלשים לחדש אלול שהוא ראש חודש תשרי";
                            break;
                    }
                    break;
                  
            }
            return deyManth;
        }
        public string years(string Years)
        {
            string year = "";
            switch (Years)
            {
                case "תשפ'ד":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                    break;
                case "תשפ'ה":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                    break;
                case "תשפ'ו":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                    break;
                case "תשפ'זד":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                    break;
                case "תשפ'ח":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם";
                    break;
                case "תשפ'ט":
                    year = "בשנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם";
                    break;
                case "תש'צ":
                    year = "בשנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם";
                    break;
                case "תשצ'א":
                    year = "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם";
                    break;
                case "תשצ'ב":
                    year = "בשנת חמשת אלפים ושבע מאות ותשעים ושתיים לבריאת העולם";
                    break;
                case "תשצ'ג":
                    year = "בשנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;
            }
            return year;
        }


    }
}
