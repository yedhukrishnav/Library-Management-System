<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="book_reservations.aspx.cs" Inherits="LMS.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                        <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Feedback List</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

        <form id="form2" runat="server">
                                <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">

                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:Repeater ID="rptBookRequests" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>Student Name</th>
                                                    <th>Book Title</th>
                                                    <th>Book Author</th>
                                                    <th>Quantity</th>
                                                    <th>Approve</th>
                                                    <th>Reject</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("u_FullName") %></td>
                                            <td><%# Eval("b_title") %></td>
                                            <td><%# Eval("b_author") %></td>
                                            <td><%# Eval("b_quantity") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnApprove" runat="server" Text="Approve" CommandArgument='<%# Eval("transId") %>' OnClick="btnApprove_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="btnReject" runat="server" Text="Reject" CommandArgument='<%# Eval("transId") %>' OnClick="btnReject_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                            <!-- Hidden column with HiddenField -->
                                            <td style="display:none;">
                                                <asp:HiddenField ID="hfBookId" runat="server" Value='<%# Eval("book_id") %>' />
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
