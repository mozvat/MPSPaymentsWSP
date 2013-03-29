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
           // builder.Append("<MerchantID>" + "595901" + "</MerchantID>");
            builder.Append("<MerchantID>" + "88430100662" + "</MerchantID>");
            builder.Append("<TranType>Credit</TranType>");
            builder.Append("<TranCode>Sale</TranCode>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Memo>Discover Test</Memo>");
            builder.Append("<Frequency>OneTime</Frequency>");
            builder.Append("<RecordNo>RecordNumberRequested</RecordNo>");
            builder.Append("<Account>");
            builder.AppendFormat("<AcctNo>{0}</AcctNo>", "6221197626920643");
            builder.AppendFormat("<ExpDate>{0}</ExpDate>", "1017");
            builder.Append("</Account>");
            builder.Append("<Amount>");
            builder.Append("<Purchase>" + "3.50" + "</Purchase>");
            builder.Append("</Amount>");
            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            //Attempt to process credit card
            string creditResult = Credit.Process(builder.ToString(), "81122HER");
        }
    }
}
