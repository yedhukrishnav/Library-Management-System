<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_home.aspx.cs" Inherits="LMS.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .book-ad-card {
    background: #fff;
    border-radius: 10px;
    box-shadow: 0 4px 12px rgba(0,0,0,0.1);
    transition: transform 0.3s ease, box-shadow 0.3s ease;
    overflow: hidden;
    text-align: center;
    padding: 15px;
    height: 100%;
}

.book-ad-card:hover {
    transform: translateY(-6px);
    box-shadow: 0 10px 25px rgba(0,0,0,0.2);
}

.book-cover {
    width: 100%;
    height: 200px;
    object-fit: contain;
    background-color: #f8f9fc;
    padding: 10px;
    border-radius: 5px;
    margin-bottom: 10px;
}


.book-info h6 {
    font-weight: bold;
    color: #4e73df;
    margin-bottom: 5px;
}

.book-info p {
    font-size: 0.9rem;
    color: #6c757d;
    margin-bottom: 6px;
}

.book-info span {
    font-size: 0.75rem;
    background: #e0ebff;
    color: #1b4dd8;
    padding: 4px 10px;
    border-radius: 50px;
    display: inline-block;
}

    </style>

<div class="container-fluid">
    <div class="card shadow mb-4">

        <div class="card shadow mb-4">
    <div class="card-header py-3">
        <h5 class="m-0 font-weight-bold text-primary">📚 New Arrivals This Week</h5>
    </div>
    <div class="card-body">
        <div class="row">

            <!-- Card 1 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9780735211292-L.jpg" alt="Atomic Habits" class="book-cover" />
                    <div class="book-info">
                        <h6>Atomic Habits</h6>
                        <p>James Clear</p>
                        <span>🔥 Trending Now</span>
                    </div>
                </div>
            </div>

            <!-- Card 2 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9781455586691-L.jpg" alt="Deep Work" class="book-cover" />
                    <div class="book-info">
                        <h6>Deep Work</h6>
                        <p>Cal Newport</p>
                        <span>💡 Must Read</span>
                    </div>
                </div>
            </div>

            <!-- Card 3 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9780061122415-L.jpg" alt="The Alchemist" class="book-cover" />
                    <div class="book-info">
                        <h6>The Alchemist</h6>
                        <p>Paulo Coelho</p>
                        <span>🌟 Staff Pick</span>
                    </div>
                </div>
            </div>

            <!-- Card 4 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9780062316097-L.jpg" alt="Sapiens" class="book-cover" />
                    <div class="book-info">
                        <h6>Sapiens</h6>
                        <p>Yuval Noah Harari</p>
                        <span>📖 New Arrival</span>
                    </div>
                </div>
            </div>

            <!-- Card 5 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9780143130727-L.jpg" alt="Ikigai" class="book-cover" />
                    <div class="book-info">
                        <h6>Ikigai</h6>
                        <p>Francesc Miralles</p>
                        <span>🧘 Bestseller</span>
                    </div>
                </div>
            </div>

            <!-- Card 6 -->
            <div class="col-md-4 mb-4">
                <div class="book-ad-card">
                    <img src="https://covers.openlibrary.org/b/isbn/9781544512280-L.jpg" alt="Can't Hurt Me" class="book-cover" />
                    <div class="book-info">
                        <h6>Can't Hurt Me</h6>
                        <p>David Goggins</p>
                        <span>🚀 Hot Release</span>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>



    </div>
</div>


</asp:Content>
