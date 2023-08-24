<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebApp2.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
    <title>Product Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4">Product One</div>
                <div class="col-md-3">Product Two</div>
                <div class="col-md-3">Product Three</div>
            </div>
            <div class="row">
                <div class="col-md-4"><asp:Image runat="server" ID="Image3" ImageUrl="~/Images/Picture 1.jpg"
                    Width="150" Height="150" CssClass="img-fluid" />
                </div>
                <div class="col-md-4"><asp:Image runat="server" ID="Image1" ImageUrl="~/Images/Picture 2.jpg"
                    Width="150" Height="150" CssClass="img-fluid" />
                </div>
                <div class="col-md-4"><asp:Image runat="server" ID="Image2" ImageUrl="~/Images/Picture 3.png"
                    Width="150" Height="150" CssClass="img-fluid" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
