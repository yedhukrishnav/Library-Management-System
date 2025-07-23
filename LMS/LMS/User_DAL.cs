using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace LMS
{
    public class User_DAL
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;

        public DataTable loginUser(User_Data_schema objSchema)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "Login_User");
                    cmd.Parameters.AddWithValue("u_email", objSchema.Email);
                    cmd.Parameters.AddWithValue("u_password", objSchema.Password);

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

        public int registerAccount(User_Data_schema objSchema)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "Register_User");
                    cmd.Parameters.AddWithValue("u_FullName", objSchema.FullName);
                    cmd.Parameters.AddWithValue("u_accountType", objSchema.AccountType);
                    cmd.Parameters.AddWithValue("u_phoneNumber", objSchema.PhoneNumber);
                    cmd.Parameters.AddWithValue("u_age", objSchema.Age);
                    cmd.Parameters.AddWithValue("u_email", objSchema.Email);
                    cmd.Parameters.AddWithValue("u_password", objSchema.Password);
                    cmd.Parameters.AddWithValue("u_accountStatus", objSchema.AccountStatus);

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

        public DataTable getUserDetailsByID(int userID)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "get_Details_By_Id");
                    cmd.Parameters.AddWithValue("userId", userID);


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

        public int UpdateChanges(User_Data_schema objSchema)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "Update_Changes");
                    cmd.Parameters.AddWithValue("userId", objSchema.UserId);
                    cmd.Parameters.AddWithValue("u_FullName", objSchema.FullName);               
                    cmd.Parameters.AddWithValue("u_phoneNumber", objSchema.PhoneNumber);
                    cmd.Parameters.AddWithValue("u_age", objSchema.Age);
                    cmd.Parameters.AddWithValue("u_email", objSchema.Email);
                    cmd.Parameters.AddWithValue("u_password", objSchema.Password);

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

        public DataTable getAllUserList()
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "get_All_User_List");

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

        public int suspendAccount(int userId)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "suspend_Account");
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("u_accountStatus", "suspended");

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

        public int activateAccount(int userId)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "activate_Account");
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("u_accountStatus", "active");

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

        public DataTable getAllRequests()
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "get_All_Membership_Requset_List");
                    cmd.Parameters.AddWithValue("u_accountStatus", "pending");

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

        public int rejectAccount(int userID)
        {
            using (cmd = new SqlCommand("user_table_procedure", conn))
            {
                try
                {
                    cmd = new SqlCommand("user_table_procedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parameter", "reject_Account");
                    cmd.Parameters.AddWithValue("userId", userID);
                    cmd.Parameters.AddWithValue("u_accountStatus", "rejected");

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