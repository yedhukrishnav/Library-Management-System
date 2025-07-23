<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="admin_Add_book.aspx.cs" Inherits="LMS.WebForm23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="text-center">
          <h1 class="h4 text-gray-900 mb-4">Add Book</h1>
    </div>
    <div class="container-fluid">
                                <form class="user" runat="server">
                                
                                <div class="form-group ">
                                    <asp:TextBox ID="txt_Book_Title" placeholder="Book Title" class="form-control form-control-user" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group ">
                                    <asp:TextBox ID="txt_Book_Author" placeholder="Author Name" class="form-control form-control-user" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group ">
                                    <asp:TextBox ID="txt_Book_Publisher" placeholder="Publisher Name" class="form-control form-control-user" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group ">
                                    <asp:TextBox ID="txt_Book_Quantity" placeholder="Quantity" class="form-control form-control-user" runat="server"></asp:TextBox>
                                </div>


                                <asp:Button ID="btn_AddBook" OnClick="btn_AddBook_Click" class="btn btn-primary btn-user btn-user" runat="server" Text="Add Book"/>
                                &nbsp &nbsp <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                             <hr>
                            </form>
    </div>


</asp:Content>
