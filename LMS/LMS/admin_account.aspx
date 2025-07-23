<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="admin_account.aspx.cs" Inherits="LMS.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
          <h1 class="h4 text-gray-900 mb-4">Update your Details</h1>
    </div>
    <div class="container-fluid">
                                <form class="user" runat="server">

                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                    <asp:TextBox ID="txt_full_name" placeholder="Full Name" class="form-control form-control-user" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txt_age" placeholder="Enter Age" class="form-control form-control-user" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txt_phone_num" placeholder="Enter Phone Number" class="form-control form-control-user" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                    <asp:TextBox ID="txt_email" class="form-control form-control-user" placeholder="Email Address" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <div class="col-sm-4 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txt_old_password" class="form-control form-control-user" placeholder="Enter old password" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txt_new_password" class="form-control form-control-user" placeholder="Enter new password" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txt_confirm_passsword" class="form-control form-control-user" placeholder="Repeat new Password" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                
                                <asp:Button ID="btn_update" OnClick="btn_update_Click" class="btn btn-primary btn-user btn-user" runat="server" Text="Update changes"/>
                                &nbsp &nbsp <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                             <hr>
                            </form>
    </div>
</asp:Content>
