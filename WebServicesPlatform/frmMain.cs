using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebServicesPlatform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnCreditSale_Click(object sender, EventArgs e)
        {
            string invoiceNumber = InvoiceNumber.New(DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year);
            StringBuilder builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Transaction>");
            builder.Append("<MerchantID>" + "595901" + "</MerchantID>");
            //builder.Append("<MerchantID>" + "88430100662" + "</MerchantID>");
            builder.Append("<TranType>Credit</TranType>");
            builder.Append("<TranCode>Sale</TranCode>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Memo>Discover Test</Memo>");
            //builder.Append("<Frequency>OneTime</Frequency>");
            //builder.Append("<RecordNo>RecordNumberRequested</RecordNo>");
            builder.Append("<Account>");
            builder.AppendFormat("<AcctNo>{0}</AcctNo>", "4003000123456781");
            builder.AppendFormat("<ExpDate>{0}</ExpDate>", "1215");
            builder.Append("</Account>");
            builder.Append("<Amount>");
            builder.Append("<Purchase>" + "3.50" + "</Purchase>");
            builder.Append("</Amount>");
            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            //Attempt to process credit card
            string result = Credit.Process(builder.ToString(), "xyz");
        }

        private void btnGiftSale_Click(object sender, EventArgs e)
        {
            //First have to issue.
            string invoiceNumber = InvoiceNumber.New(DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year);
            StringBuilder builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Transaction>");
            builder.Append("<IpPort>" + "9100" + "</IpPort>");
            builder.Append("<MerchantID>" + "595901" + "</MerchantID>");
            builder.Append("<TranType>PrePaid</TranType>");
            builder.Append("<TranCode>Issue</TranCode>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Memo>Gift Test</Memo>");

            builder.Append("<Account>");
            //Swipe example
            //builder.AppendFormat("<Track2>{0}</Track2>", "7712950000000000316=250110113");
            //Keyed example
            builder.AppendFormat("<AcctNo>{0}</AcctNo>", "6050110010021824998");
            builder.Append("</Account>");

            builder.Append("<Amount>");
            builder.Append("<Purchase>" + "210.00" + "</Purchase>");
            builder.Append("</Amount>");

            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            //Attempt to issue gift card
            string result = Gift.Process(builder.ToString(), "xyz");

            //Sale
            invoiceNumber = InvoiceNumber.New(DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year);
            builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Transaction>");
            builder.Append("<IpPort>" + "9100" + "</IpPort>");
            builder.Append("<MerchantID>" + "595901" + "</MerchantID>");
            builder.Append("<TranType>PrePaid</TranType>");
            builder.Append("<TranCode>Sale</TranCode>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Memo>Gift Test</Memo>");

            builder.Append("<Account>");
            //Swipe example
            //builder.AppendFormat("<Track2>{0}</Track2>", "7712950000000000316=250110113");
            //Keyed Example
            builder.AppendFormat("<AcctNo>{0}</AcctNo>", "6050110010021824998");
            builder.Append("</Account>");
            
            builder.Append("<Amount>");
            builder.Append("<Purchase>" + "3.50" + "</Purchase>");
            builder.Append("</Amount>");
            
            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            //Attempt to process gift card
            result = Gift.Process(builder.ToString(), "xyz");


            //Gift Balance
            invoiceNumber = InvoiceNumber.New(DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year);
            builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Transaction>");
            builder.Append("<IpPort>" + "9100" + "</IpPort>");
            builder.Append("<MerchantID>" + "595901" + "</MerchantID>");
            builder.Append("<TranType>PrePaid</TranType>");
            builder.Append("<TranCode>Balance</TranCode>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Memo>Gift Test</Memo>");

            builder.Append("<Account>");
            //Swipe example
            //builder.AppendFormat("<Track2>{0}</Track2>", "7712950000000000316=250110113");
            //Keyed Example
            builder.AppendFormat("<AcctNo>{0}</AcctNo>", "6050110010021824998");
            builder.Append("</Account>");

            builder.Append("<Amount>");
            builder.Append("<Purchase>" + "3.50" + "</Purchase>");
            builder.Append("</Amount>");

            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            //Attempt to get gift card balance
            result = Gift.Process(builder.ToString(), "xyz");

        }
    }
}
