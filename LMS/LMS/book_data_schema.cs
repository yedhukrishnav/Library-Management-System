using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS
{
    public class book_data_schema
    {
        private int _bookID;
        private string _bookTitle;
        private string _bookAuthor;
        private string _bookPublisher;
        private int _bookQuantity;

        public int bookID
        {
            get { return _bookID; }
            set { _bookID = value; }
        }

        public string bookTitle
        {
            get { return _bookTitle; }
            set { _bookTitle = value; }
        }

        public string bookAuthor
        {
            get { return _bookAuthor; }
            set { _bookAuthor = value; }
        }

        public string BookPublisher
        {
            get { return _bookPublisher; }
            set { _bookPublisher = value; }
        }

        public int BookQuantity
        {
            get { return _bookQuantity; }
            set { _bookQuantity = value; }
        }
    }
}