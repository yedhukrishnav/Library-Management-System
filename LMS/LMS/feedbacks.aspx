<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="feedbacks.aspx.cs" Inherits="LMS.WebForm9" %>
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
                                <asp:Repeater ID="rptFeedback" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                            <thead>
                                                <tr>
                                                    <th>Student Name</th>
                                                    <th>Feedback</th>
                                                    <th>Response</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("u_FullName") %></td>
                                            <td><%# Eval("feedback_content") %></td>
                                            <td><%# Eval("feedback_response") %></td>
                                            <td>
                                                <asp:LinkButton ID="btnReply" runat="server" Text="Reply" CommandArgument='<%# Eval("fed_Id") %>' OnClick="btnReply_Click" CssClass="btn btn-sm btn-primary" />
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

                                    <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Give Reply</h6>
                        </div>
                                <div class="form-group ">
                                    <asp:TextBox ID="txt_Content" class="form-control form-control-user" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="form-group ">
                                    <asp:TextBox ID="txt_reply" placeholder="within 500 characters" class="form-control form-control-user" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </div>                               
                                    <asp:Button ID="btn_reply" class="btn btn-primary btn-user btn-user" runat="server" Text="Send feedback" OnClick="btn_reply_Click" />
                                &nbsp &nbsp <asp:Label ID="reply_label" runat="server" Text="Label"></asp:Label>
                             <hr>
            <asp:HiddenField ID="hfFedId" runat="server" />
        </form>


                            </div>
                        </div>
                    </div>

                </div>
</asp:Content>
