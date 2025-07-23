using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class book_BAL
    {

        public DataTable GetAllBooksList()
        {
            book_DAL objDal = new book_DAL();
            return objDal.GetAllBooksList();
        }

        public int updateBookCountOnApproval(book_data_schema objSchema)
        {
            book_DAL objDal = new book_DAL();
            return objDal.updateBookCountOnApproval(objSchema);
        }

        public int deleteBook(int bookID)
        {
            book_DAL objDal = new book_DAL();
            return objDal.deleteBook(bookID);
        }

        public DataTable getBookDetailsByID(int bookID)
        {
            book_DAL objDal = new book_DAL();
            return objDal.getBookDetailsByID(bookID);
        }

        public int updateBookDetails(book_data_schema objSchema)
        {
            book_DAL objDal = new book_DAL();
            return objDal.updateBookDetails(objSchema);
        }

        public int addNewBook(book_data_schema objSchema)
        {
            book_DAL objDal = new book_DAL();
            return objDal.addNewBook(objSchema);
        }
    }
}