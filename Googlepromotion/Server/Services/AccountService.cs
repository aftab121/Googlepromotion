﻿using System;
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
                string data = "";
              string query1 = "Insert into Login_User values ('" + user.Email + "','" + user.UserName + "','" + null + "','"+DateTime.Now.ToString()+"','" + user.status + "')";
                dataAccess.ExecuteNonQuery_IUD(query1);
                string query2 = "SELECT * FROM Login_User where UserEmail='" + user.Email + "'";
                dtContainer = dataAccess.DataTable_return(query2);
                foreach (DataRow row in dtContainer.Rows)
                {
                    data = row["Id"].ToString();
                   
                }
                foreach (var con in contacts)
                {
                    string query3 = "Insert into User_Contacts values ('" + con.Contact + "','" + DateTime.Now.ToString() + "','" + data+"')";
                    dataAccess.ExecuteNonQuery_IUD(query3);
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

        public List<UserContacts> GetContacts(string Username)
        {

            List<UserContacts> order = new List<UserContacts>();
            try
            {
                //  Username = "";
                string query = "SSELECT User_Contacts.Contact FROM User_Contacts INNER JOIN Login_User ON User_Contacts.UserId = Login_User.Id where Login_User.UserEmail = '" + Username + "'";
                dtContainer = dataAccess.DataTable_return(query);
                if (dtContainer.Rows.Count > 0)
                {
                    order = GenerateSQL.ConvertToList<UserContacts>(dtContainer);
                }
            }
            catch (Exception ex)
            {
                // LogManager.InsertLog(LogTypeEnum.DatabaseOprationError, ex.Message, ex);
            }
            return order;
        }
    }
}
