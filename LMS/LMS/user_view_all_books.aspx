<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="user_view_all_books.aspx.cs" Inherits="LMS.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
                    <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">All Book List</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

        <form id="form1" runat="server">
                                <div class="container-fluid">



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
                                <asp:Repeater ID="rptViewAllBooks" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>Book Title</th>
                                                    <th>Book Author</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("b_title") %></td>
                                            <td><%# Eval("b_author") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnReserve" runat="server" Text="Reserve" CommandArgument='<%# Eval("book_id") %>' OnClick="btnReserve_Click" CssClass="btn btn-sm btn-primary" />
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
