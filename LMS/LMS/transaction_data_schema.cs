using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS
{
    public class transaction_data_schema
    {
        private int _trans_id;
        private int _trans_userID;
        private int _trans_bookID;
        private string _trans_DOR;
        private string _trans_DOB;
        private int _trans_fine;
        private string _trans_status;

        public int trans_id
        {
            get { return _trans_id; }
            set { _trans_id = value; }
        }

        public int trans_userID
        {
            get { return _trans_userID; }
            set { _trans_userID = value; }
        }

        public int trans_bookID
        {
            get { return _trans_bookID; }
            set { _trans_bookID = value; }
        }

        public string trans_DOR
        {
            get { return _trans_DOR; }
            set { _trans_DOR = value; }
        }

        public string trans_DOB
        {
            get { return _trans_DOB; }
            set { _trans_DOB = value; }
        }

        public int trans_fine
        {
            get { return _trans_fine; }
            set { _trans_fine = value; }
        }

        public string trans_status
        {
            get { return _trans_status; }
            set { _trans_status = value; }
        }
    }
}