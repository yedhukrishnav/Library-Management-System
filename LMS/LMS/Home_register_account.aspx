<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home_register_account.aspx.cs" Inherits="LMS.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                            </div>
                            <form class="user" runat="server">
                                <div class="form-group ">
                                    <asp:TextBox ID="txt_full_name" placeholder="Full Name" class="form-control form-control-user" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txt_phone_num" placeholder="Enter Phone Number" class="form-control form-control-user" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txt_age" placeholder="Enter Age" class="form-control form-control-user" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txt_email" class="form-control form-control-user" placeholder="Email Address" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txt_password" class="form-control form-control-user" placeholder="Password" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txt_confirm_passsword" class="form-control form-control-user" placeholder="Repeat Password" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                                <asp:Button ID="btn_register" OnClick="btn_register_Click" class="btn btn-primary btn-user btn-block" runat="server" Text="Register Account" />
                             <hr>
                            <div class="text-center">
                                <asp:Button ID="btn_forgot_password" OnClick="btn_forgot_password_Click" class="small btn btn-light btn-user" runat="server" Text="Forgot Password?" />
                            </div>
                            <div class="text-center">
                                <asp:Button ID="btn_login" OnClick="btn_login_Click" class="small btn btn-light btn-user" runat="server" Text="Already have an account? Login!" />
                            </div>
                            </form>
</asp:Content>
