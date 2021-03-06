﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Invoices
    {
        public string INVOICEID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Invoice_Owner { get; set; }
        public string Subject { get; set; }
        public string Sales_Order { get; set; }
        public string Invoice_Date { get; set; }
        public string Purchase_Order { get; set; }
        public string Due_Date { get; set; }
        public string Excise_Duty { get; set; }
        public string Sales_Commission { get; set; }
        public string Status { get; set; }
        public string Account_Name { get; set; }
        public string Created_By { get; set; }
        public string Contact_Name { get; set; }
        public string Modified_By { get; set; }
        public string Billing_Street { get; set; }
        public string Shipping_Street { get; set; }
        public string Billing_City { get; set; }
        public string Shipping_City { get; set; }
        public string Billing_State { get; set; }
        public string Shipping_State { get; set; }
        public string Billing_Code { get; set; }
        public string Shipping_Code { get; set; }
        public string Billing_Country { get; set; }
        public string Shipping_Country { get; set; }

        public List<AuxEntities.AuxProducts> Product_Details { get; set; }

        public string Terms_and_Conditions { get; set; }
        public string Description { get; set; }
        public string Invoice_Number { get; set; }
        public string SALESORDERID { get; set; }
        public string ACCOUNTID { get; set; }
        public string Sub_Total { get; set; }
        public string Tax { get; set; }
        public string Adjustment { get; set; }
        public string Grand_Total { get; set; }
        public string CONTACTID { get; set; }
        public string Discount { get; set; }
    }
}
