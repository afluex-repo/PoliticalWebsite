using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace PoliticalWebsite.Models
{
    public class YouthConversation
    {
        public string Pk_Id { get; set; }
        public string FullName { get; set; }

        public string FatherName { get; set; }

        public string Age { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string InstituteName { get; set; }

        public string Course { get; set; }
        public string AddedBy { get; set; }
        public string Date { get; set; }
        public List<YouthConversation> lstYouthConversation { get; set; }

        public DataSet SaveYouthConversation()
        {
            SqlParameter[] para = {
                new SqlParameter("@FullName",FullName),
                new SqlParameter("@FatherName",FatherName),
                new SqlParameter("@Age",Age),
                new SqlParameter("@MobileNo",MobileNo),
                new SqlParameter("@Email",Email),
                new SqlParameter("@Address",Address),
                new SqlParameter("@InstituteName",InstituteName),
                new SqlParameter("@Course",Course),
                new SqlParameter("@AddedBy",AddedBy)
            };
            DataSet ds = Connection.ExecuteQuery("SaveYouthConversationDetails", para);
            return ds;
        }
        public DataSet YouthConversationDetails()
        {
            SqlParameter[] para = { new SqlParameter("@Pk_Id", Pk_Id) };
            DataSet ds = Connection.ExecuteQuery("YouthConversationDetails", para);
            return ds;
        }
    }
}