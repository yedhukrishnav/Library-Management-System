using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class User_BAL
    {
        public DataTable loginUser(User_Data_schema objSchema)
        {
            User_DAL objDal = new User_DAL();
            return objDal.loginUser(objSchema);
        }

        public int registerAccount(User_Data_schema objSchema)
        {
            User_DAL objDal = new User_DAL();
            return objDal.registerAccount(objSchema);
        }

        public DataTable getUserDetailsByID(int userID)
        {
            User_DAL objDal = new User_DAL();
            return objDal.getUserDetailsByID(userID);
        }

        public int UpdateChanges(User_Data_schema objSchema)
        {
            User_DAL objDal = new User_DAL();
            return objDal.UpdateChanges(objSchema);
        }

        public DataTable getAllUserList()
        {
            User_DAL objDal = new User_DAL();
            return objDal.getAllUserList();
        }

        public int suspendAccount(int id)
        {
            User_DAL objDal = new User_DAL();
            return objDal.suspendAccount(id);
        }

        public int activateAccount(int id)
        {
            User_DAL objDal = new User_DAL();
            return objDal.activateAccount(id);
        }

        public DataTable getAllRequests()
        {
            User_DAL objDal = new User_DAL();
            return objDal.getAllRequests();
        }

        public int rejectAccount(int id)
        {
            User_DAL objDal = new User_DAL();
            return objDal.rejectAccount(id);
        }
    }
}