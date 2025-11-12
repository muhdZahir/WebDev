<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FavoritePetApp.aspx.cs" Inherits="LabExercise2_2.FavoritePetApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>List Box, Drop Down List and Image</h3>
            <p>What is your most favorite pet?</p>
            <p>
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                    <asp:ListItem Value="bird">Bird</asp:ListItem>
                    <asp:ListItem Value="cat">Cat</asp:ListItem>
                    <asp:ListItem Value="dog">Dog</asp:ListItem>
                    <asp:ListItem Value="fish">Fish</asp:ListItem>
                    <asp:ListItem Value="lizard">Lizard</asp:ListItem>
                    <asp:ListItem Value="rabbit">Rabbit</asp:ListItem>
                </asp:ListBox>
            </p>
            <p>
                Image size: 
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Select image size</asp:ListItem>
                    <asp:ListItem Value="50">Extra small</asp:ListItem>
                    <asp:ListItem Value="100">Small</asp:ListItem>
                    <asp:ListItem Value="150">Medium</asp:ListItem>
                    <asp:ListItem Value="200">Large</asp:ListItem>
                    <asp:ListItem Value="250">Extra Large</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/pet.png" Height="200px" />
            </p>
        </div>
    </form>
</body>
</html>
