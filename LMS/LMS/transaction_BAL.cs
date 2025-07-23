using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class transaction_BAL
    {

        public int requestBook(transaction_data_schema objSchema)
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.requestBook(objSchema);
        }

        public DataTable GetAllBooksRequests()
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.GetAllBooksRequests();
        }

        public int approveRequest(transaction_data_schema objSchema)
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.approveRequest(objSchema);
        }

        public int rejectRequest(transaction_data_schema objSchema)
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.rejectRequest(objSchema);
        }

        public DataTable getFineDetails()
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.getFineDetails();
        }

        public DataTable getAllTransactions()
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.getAllTransactions();
        }

        public int closeTransaction(transaction_data_schema objSchema)
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.closeTransaction(objSchema);
        }

        public DataTable getActiveTransactions()
        {
            transaction_DAL objDal = new transaction_DAL();
            return objDal.getActiveTransactions();
        }
    }
}