using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Please enter full name.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter father's name.")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Please enter age.")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Please enter mobile number.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter institute name.")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "Please enter course.")]
        public string Course { get; set; }
        public string AddedBy { get; set; }
        public string Date { get; set; }

        [Required(ErrorMessage = "Please select district.")]
        public string District { get; set; }

  

        public string Topic { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please confirm that the information is correct.")]
        public bool IsConfirmed { get; set; }

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
                new SqlParameter("@Topic",Topic),
                new SqlParameter("@District",District),
                new SqlParameter("@Isconfirmed",IsConfirmed),
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