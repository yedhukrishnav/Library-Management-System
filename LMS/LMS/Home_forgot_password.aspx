<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home_forgot_password.aspx.cs" Inherits="LMS.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-2">Forgot Your Password?</h1>
                                        <p class="mb-4">We get it, stuff happens. Just enter your email address below
                                            and we'll send you a link to reset your password!</p>
                                    </div>
                                    <form class="user" runat="server">
                                        <div class="form-group">
                                            <asp:TextBox ID="txt_forgot_email" aria-describedby="emailHelp" placeholder="Enter Email Address..." class="form-control form-control-user" runat="server"></asp:TextBox>
                                        </div>
                                        <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                                        <asp:Button ID="btn_reset_password" OnClick="btn_reset_password_Click" class="btn btn-primary btn-user btn-block" runat="server" Text="Reset Password" />
                                    <hr>
                                    <div class="text-center">
                                        <asp:Button ID="btn_register_account" OnClick="btn_register_account_Click" class="small btn btn-light btn-user" runat="server" Text="Create an Account!" />
                                    </div>
                                    <div class="text-center">
                                        <asp:Button ID="btn_login" OnClick="btn_login_Click" class="small btn btn-light btn-user" runat="server" Text="Already have an account? Login!" />
                                    </div>
                                    </form>

</asp:Content>
