<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="user_fine_history.aspx.cs" Inherits="LMS.WebForm18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                            <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">All Transactions</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>Book Title</th>
                                            <th>Author Name</th>
                                            <th>Status</th>
                                            <th>Date of Borrow</th>
                                            <th>Date of Return</th>
                                            <th>Fine</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Literal ID="ltTableRows" runat="server" />
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                </div>
</asp:Content>
