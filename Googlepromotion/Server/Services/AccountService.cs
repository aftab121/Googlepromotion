using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Google.GData.Extensions;
using Googlepromotion.Server.Helper;
using Googlepromotion.Shared.Models;

namespace Googlepromotion.Server.Services
{
    public partial class AccountService : IAccountService
    {
        DataTable dtContainer;
        SqlDataAccess dataAccess = new SqlDataAccess();
       
        public bool SaveUserDetails(User user, List<UserContacts> contacts)
        {
            string query = "SELECT * FROM Login_User where UserEmail='" + user.Email + "'";
            dtContainer = dataAccess.DataTable_return(query);
            if (dtContainer.Rows.Count > 0)
            {
               
            }
            else
            {
                string query1 = "Insert into Login_User values ('" + user.Email + "','" + user.UserName + "','" + null + "','2021-01-01 00:00:00.000','" + user.status + "')";
                var data = dataAccess.ExecuteNonQuery_IUD(query1);
                foreach(var con in contacts)
                {
                    string query2 = "Insert into User_Contacts values ('" + con.Contact + "','2021-01-01 00:00:00.000','" +data+"')";
                    dataAccess.ExecuteNonQuery_IUD(query2);
                }
               
            }
           
            return true;
        }
        

     
        public List<User> GetProfile(string Username)
        {

            List<User> order = new List<User>();
            try
            {
              //  Username = "";
                string query = "SELECT Id,UserEmail as Email,UserName,create_Date,Status,UserProfile FROM Login_User where UserEmail='" + Username + "'";
                dtContainer = dataAccess.DataTable_return(query);
                if (dtContainer.Rows.Count > 0)
                {
                    order = GenerateSQL.ConvertToList<User>(dtContainer);
                }
            }
            catch (Exception ex)
            {
                // LogManager.InsertLog(LogTypeEnum.DatabaseOprationError, ex.Message, ex);
            }
            return order;
        }

        public bool SavePromoteBusniessDetails(PromoteBusiness promote)
        {
            try
            {
                string query1 = "Insert into UserWebsite_Details values ('" + promote.Name + "','" + promote.Website_Link + "','" + promote.Logo + "','"+promote.UserId+"','" + promote.Status + "')";
                var data = dataAccess.ExecuteNonQuery_IUD(query1);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
