using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PoliticalWebsite.Models
{
    public class Admin
    {
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string WhatsappNo { get; set; }
        public List<Admin> lstcontact { get; set; }
        public List<Admin> lstKushahariMahotsav { get; set; }
        public string Pk_ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }

        public DataSet GetDetails()
        {
            DataSet ds = Connection.ExecuteQuery("BindDataForAdminDashboard");
            return ds;
        }

        public DataSet ContactDetails()
        {
            SqlParameter[] para = { new SqlParameter("@Pk_ContactId", Pk_ContactId) };
            DataSet ds = Connection.ExecuteQuery("ContactDetails", para);
            return ds;
        }
        public DataSet KushahariMahotsavDetails()
        {
            DataSet ds = Connection.ExecuteQuery("KushahariMahotsavDetails");
            return ds;
        }
    }
}