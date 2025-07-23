<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="book_transactions.aspx.cs" Inherits="LMS.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                    <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Feedback List</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

        <form id="form1" runat="server">
                                <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">

                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:Repeater ID="rptAllTransactions" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>Student Name</th>
                                                    <th>Book Title</th>
                                                    <th>Date of Borrow</th>
                                                    <th>Date of Return</th>
                                                    <th>Fine</th>
                                                    <th>Status</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("u_FullName") %></td>
                                            <td><%# Eval("b_title") %></td>
                                            <td><%# Eval("DOB") %></td>
                                            <td><%# Eval("DOR") %></td>
                                            <td><%# Eval("trans_fine") %></td>
                                            <td><%# Eval("trans_status") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnCloseTransaction" runat="server" Text="Close" CommandArgument='<%# Eval("transId") %>' OnClick="btnCloseTransaction_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                            </tbody>
                                        </table>
                                    </FooterTemplate>
                                </asp:Repeater>

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
