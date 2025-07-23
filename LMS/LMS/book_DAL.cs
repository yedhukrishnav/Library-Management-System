using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class book_DAL
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;

        public DataTable GetAllBooksList()
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Get_all_books_list");

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

        public int updateBookCountOnApproval(book_data_schema objSchema)
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "update_Book_Count_On_Approval");
                    cmd.Parameters.AddWithValue("book_id", objSchema.bookID);

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

        public int deleteBook(int bookID)
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "delete_Book");
                    cmd.Parameters.AddWithValue("book_id", bookID);

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

        public DataTable getBookDetailsByID(int bookID)
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "get_Book_Details_By_ID");
                    cmd.Parameters.AddWithValue("book_id", bookID);

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

        public int updateBookDetails(book_data_schema objSchema)
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "Update_Book_Details");
                    cmd.Parameters.AddWithValue("book_id", objSchema.bookID);
                    cmd.Parameters.AddWithValue("b_title", objSchema.bookTitle);
                    cmd.Parameters.AddWithValue("b_author", objSchema.bookAuthor);
                    cmd.Parameters.AddWithValue("b_publisher", objSchema.BookPublisher);
                    cmd.Parameters.AddWithValue("b_quantity", objSchema.BookQuantity);

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

        public int addNewBook(book_data_schema objSchema)
        {
            using (cmd = new SqlCommand("books_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("books_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("para", "add_New_Book");
                    cmd.Parameters.AddWithValue("b_title", objSchema.bookTitle);
                    cmd.Parameters.AddWithValue("b_author", objSchema.bookAuthor);
                    cmd.Parameters.AddWithValue("b_publisher", objSchema.BookPublisher);
                    cmd.Parameters.AddWithValue("b_quantity", objSchema.BookQuantity);

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