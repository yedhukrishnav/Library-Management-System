<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home_login.aspx.cs" Inherits="LMS.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Welcome Back!</h1>
                                    </div>
                                    <form class="user" runat="server">
                                        <div class="form-group">
                                            <asp:TextBox ID="txt_login_email" aria-describedby="emailHelp" placeholder="Enter Email Address..." class="form-control form-control-user" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="txt_login_password" placeholder="Password" runat="server" class="form-control form-control-user"></asp:TextBox>
                                        </div>
                                        <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                                        <asp:Button ID="btn_login" OnClick="btn_login_Click" runat="server" class="btn btn-primary btn-user btn-block" Text="Login"/>
                                    <hr>
                                    <div class="text-center">
                                        <asp:Button ID="btn_forgot_password" class="small btn btn-light btn-user" runat="server" Text="Forgot Password?" OnClick="btn_forgot_password_Click" />
                                    </div>
                                    <div class="text-center">
                                        <asp:Button ID="btn_create_an_account" class="small btn btn-light btn-user" runat="server" Text="Create an Account!" OnClick="btn_create_an_account_Click" />
                                    </div>
                                    </form>


</asp:Content>
