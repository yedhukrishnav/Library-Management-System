<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="user_feedbacks.aspx.cs" Inherits="LMS.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <div class="container-fluid">

                    <!-- DataTales -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Share your feedbacks</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">

            <div class="text-center">
    </div>
    <div class="container-fluid">
                                <form class="user" runat="server">

                                <div class="form-group ">
                                    <asp:TextBox ID="txt_feedback" placeholder="within 500 characters" class="form-control form-control-user" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </div>
                                
                                <asp:Button ID="btn_save_response" OnClick="btn_save_response_Click" class="btn btn-primary btn-user btn-user" runat="server" Text="Send feedback"/>
                                &nbsp &nbsp <asp:Label ID="result_label" runat="server" Text="Label"></asp:Label>
                                    <br /


                             <hr>
                            </form>
    </div>


                            </div>
                        </div>
                    </div>

                </div>

                                <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Your Feedbacks</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>Admin Responded</th>
                                            <th>Feedback</th>
                                            <th>Response</th>
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
