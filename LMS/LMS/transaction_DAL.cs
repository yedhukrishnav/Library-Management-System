using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class transaction_DAL
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        public int requestBook(transaction_data_schema objSchema)
        {
            using (cmd = new SqlCommand("transaction_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("transaction_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "request_book");
                    cmd.Parameters.AddWithValue("trans_userID", objSchema.trans_userID);
                    cmd.Parameters.AddWithValue("trans_bookID", objSchema.trans_bookID);
                    cmd.Parameters.AddWithValue("DOB", objSchema.trans_DOB);
                    cmd.Parameters.AddWithValue("DOR", objSchema.trans_DOR);
                    cmd.Parameters.AddWithValue("trans_fine", objSchema.trans_fine);
                    cmd.Parameters.AddWithValue("trans_status", objSchema.trans_status);

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable GetAllBooksRequests()
        {
            using (cmd = new SqlCommand("[transaction_procedure]", conn))
            {
                try
                {
                    cmd = new SqlCommand("[transaction_procedure]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Get_all_books_Requests");

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    conn.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int approveRequest(transaction_data_schema objSchema)
        {
            using (cmd = new SqlCommand("transaction_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("transaction_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "approve_Request");
                    cmd.Parameters.AddWithValue("transId", objSchema.trans_id);
                    cmd.Parameters.AddWithValue("DOB", objSchema.trans_DOB);
                    cmd.Parameters.AddWithValue("DOR", objSchema.trans_DOR);
                    cmd.Parameters.AddWithValue("trans_status", objSchema.trans_status);

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int rejectRequest(transaction_data_schema objSchema)
        {
            using (cmd = new SqlCommand("transaction_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("transaction_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "reject_Request");
                    cmd.Parameters.AddWithValue("transId", objSchema.trans_id);
                    cmd.Parameters.AddWithValue("trans_status", objSchema.trans_status);

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable getFineDetails()
        {
            using (cmd = new SqlCommand("[transaction_procedure]", conn))
            {
                try
                {
                    cmd = new SqlCommand("[transaction_procedure]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Get_Fine_Details");

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    conn.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable getAllTransactions()
        {
            using (cmd = new SqlCommand("[transaction_procedure]", conn))
            {
                try
                {
                    cmd = new SqlCommand("[transaction_procedure]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Get_All_Transactions");
                    cmd.Parameters.AddWithValue("trans_status", "requested");

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    conn.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int closeTransaction(transaction_data_schema objSchema)
        {
            using (cmd = new SqlCommand("transaction_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("transaction_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "close_Transaction");
                    cmd.Parameters.AddWithValue("transId", objSchema.trans_id);
                    cmd.Parameters.AddWithValue("trans_status", objSchema.trans_status);

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable getActiveTransactions()
        {
            using (cmd = new SqlCommand("[transaction_procedure]", conn))
            {
                try
                {
                    cmd = new SqlCommand("[transaction_procedure]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Get_All_Active_Transactions");
                    cmd.Parameters.AddWithValue("trans_status", "issued");

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    conn.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int UpdateFine(int transactionId, int calculatedFine)
        {
            using (cmd = new SqlCommand("transaction_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("transaction_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "update_Fine");
                    cmd.Parameters.AddWithValue("transId", transactionId);
                    cmd.Parameters.AddWithValue("trans_fine", calculatedFine);

                    if (conn.State.Equals(ConnectionState.Closed))
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}