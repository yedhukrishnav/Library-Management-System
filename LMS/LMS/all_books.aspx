<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="all_books.aspx.cs" Inherits="LMS.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">All Books List</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

        <form id="form1" runat="server">
                                <div class="container-fluid">

                        <div class="ml-1 mb-1">
                                <asp:Button ID="btn_addBook" OnClick="btn_addBook_Click" class="small btn btn-success " runat="server" Text="Add a Book" />
                       </div>


            <!-- Search Bar -->
            <div class="input-group mb-3 ml-1 mt-2" style="width: 350px;">
                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Search by title or author..." />
                <div class="input-group-append">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                    <asp:Button ID="btnClearSearch" runat="server" Text="Clear" CssClass="btn btn-outline-secondary ml-2" OnClick="btnClearSearch_Click"/>
                </div>
            </div>


                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">

                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:Repeater ID="rptAllBooks" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>Title</th>
                                                    <th>Author</th>
                                                    <th>Quantity</th>
                                                    <th>Edit</th>
                                                    <th>Delete</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("b_title") %></td>
                                            <td><%# Eval("b_author") %></td>
                                            <td><%# Eval("b_quantity") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnEdit" runat="server" Text="Edit" CommandArgument='<%# Eval("book_id") %>' OnClick="btnEdit_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="btnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("book_id") %>' OnClick="btnDelete_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                            </tbody>
                                        </table>
                                    </FooterTemplate>
                                </asp:Repeater>
                                            <div class="d-flex justify-content-between mt-3">
                                                <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" CssClass="btn btn-secondary" />
                                                <asp:Label ID="lblPageInfo" runat="server" CssClass="align-self-center" />
                                                <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" CssClass="btn btn-secondary" />
                                            </div>
                            </div>
                        </div>
                    </div>

                </div>

        </form>


                            </div>
                        </div>
                    </div>

                </div>

</asp:Content>
