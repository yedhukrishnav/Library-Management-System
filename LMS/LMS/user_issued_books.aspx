<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="user_issued_books.aspx.cs" Inherits="LMS.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                    <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Issued Books</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>Book Title</th>
                                            <th>Author Name</th>
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
