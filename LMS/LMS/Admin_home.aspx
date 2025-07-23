<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_home.aspx.cs" Inherits="LMS.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container-fluid">

    <!-- Header -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Library Dashboard</h1>
    </div>

    <!-- Cards Row -->
    <div class="row">

        <!-- Total Users -->
        <div class="col-xl-3 col-md-6 mb-4">
            <div class="card border-left-primary shadow h-100 py-2">
                <div class="card-body">
                    <div class="row no-gutters align-items-center">
                        <div class="col mr-2">
                            <div class="text-xs font-weight-bold text-primary text-uppercase mb-1">Total Users</div>
                            <div class="h5 mb-0 font-weight-bold text-gray-800">
                                <asp:Label ID="lblTotalUsers" runat="server" Text="0"></asp:Label>
                            </div>
                        </div>
                        <div class="col-auto">
                            <i class="fas fa-users fa-2x text-gray-300"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Total Books -->
        <div class="col-xl-3 col-md-6 mb-4">
            <div class="card border-left-success shadow h-100 py-2">
                <div class="card-body">
                    <div class="row no-gutters align-items-center">
                        <div class="col mr-2">
                            <div class="text-xs font-weight-bold text-success text-uppercase mb-1">Total Books</div>
                            <div class="h5 mb-0 font-weight-bold text-gray-800">
                                <asp:Label ID="lblTotalBooks" runat="server" Text="0"></asp:Label>
                            </div>
                        </div>
                        <div class="col-auto">
                            <i class="fas fa-book fa-2x text-gray-300"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Issued Books -->
        <div class="col-xl-3 col-md-6 mb-4">
            <div class="card border-left-warning shadow h-100 py-2">
                <div class="card-body">
                    <div class="row no-gutters align-items-center">
                        <div class="col mr-2">
                            <div class="text-xs font-weight-bold text-warning text-uppercase mb-1">Issued Books</div>
                            <div class="h5 mb-0 font-weight-bold text-gray-800">
                                <asp:Label ID="lblIssuedBooks" runat="server" Text="0"></asp:Label>
                            </div>
                        </div>
                        <div class="col-auto">
                            <i class="fas fa-book-reader fa-2x text-gray-300"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Overdue Transactions -->
        <div class="col-xl-3 col-md-6 mb-4">
            <div class="card border-left-danger shadow h-100 py-2">
                <div class="card-body">
                    <div class="row no-gutters align-items-center">
                        <div class="col mr-2">
                            <div class="text-xs font-weight-bold text-danger text-uppercase mb-1">Overdue</div>
                            <div class="h5 mb-0 font-weight-bold text-gray-800">
                                <asp:Label ID="lblOverdue" runat="server" Text="0"></asp:Label>
                            </div>
                        </div>
                        <div class="col-auto">
                            <i class="fas fa-exclamation-circle fa-2x text-gray-300"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />

<div class="container mt-4">
  <div class="row">
    
    <!-- Quick Tips -->
    <div class="col-md-4 mb-4">
      <div class="card shadow-sm border-left-info">
        <div class="card-header bg-info text-white font-weight-bold">💡 Quick Tips</div>
        <div class="card-body">
          <ul class="mb-0 pl-3">
            <li>Archive old transactions every semester.</li>
            <li>Use filters to find overdue books faster.</li>
            <li>Update book quantity after return.</li>
          </ul>
        </div>
      </div>
    </div>

    <!-- Library Operating Hours -->
    <div class="col-md-4 mb-4">
      <div class="card shadow-sm border-left-primary">
        <div class="card-header bg-primary text-white font-weight-bold">⏰ Library Hours</div>
        <div class="card-body">
          <ul class="mb-0 list-unstyled">
            <li><strong>Mon–Fri:</strong> 9:00 AM – 6:00 PM</li>
            <li><strong>Saturday:</strong> 10:00 AM – 4:00 PM</li>
            <li><strong>Sunday:</strong> Closed</li>
          </ul>
        </div>
      </div>
    </div>

    <!-- Static Notifications -->
    <div class="col-md-4 mb-4">
      <div class="card shadow-sm border-left-warning">
        <div class="card-header bg-warning text-white font-weight-bold">🔔 Notifications</div>
        <div class="card-body">
          <ul class="mb-0 pl-3">
            <li>📅 Semester starts: <strong>Aug 1</strong></li>
            <li>📚 Return books by: <strong>July 31</strong></li>
            <li>⚠️ Maintenance: <strong>Aug 5 (2–4 PM)</strong></li>
          </ul>
        </div>
      </div>
    </div>

  </div>
</div>



    </div>
</div>
</asp:Content>
