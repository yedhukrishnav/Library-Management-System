<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="all_users.aspx.cs" Inherits="LMS.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">All Registered Students</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

        <form id="form2" runat="server">
                                <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">

                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:Repeater ID="rptFeedback" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>User Name</th>
                                                    <th>Phone Number</th>
                                                    <th>Age</th>
                                                    <th>Email</th>
                                                    <th>Password</th>
                                                    <th>Account Status</th>
                                                    <th>Suspend</th>
                                                    <th>Activate</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("u_FullName") %></td>
                                            <td><%# Eval("u_PhoneNumber") %></td>
                                            <td><%# Eval("u_age") %></td>
                                            <td><%# Eval("u_email") %></td>
                                            <td><%# Eval("u_password") %></td>
                                            <td><%# Eval("u_accountStatus") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnSuspend" runat="server" Text="Suspend" CommandArgument='<%# Eval("userId") %>' OnClick="btnSuspend_Click" CssClass="btn btn-sm btn-primary" />
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="btnActivate" runat="server" Text="Activate" CommandArgument='<%# Eval("userId") %>' OnClick="btnActivate_Click" CssClass="btn btn-sm btn-primary" />
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
