<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 412px;
        }
    </style>
</head>
<body style="height: 415px; width: 947px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nazwa kategorii:"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownListCategory" runat="server" DataSourceID="EntityDataSource1" DataTextField="CategoryName" DataValueField="CategoryID">
        </asp:DropDownList>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=NorthwindEntities" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Categories" Select="it.[CategoryID], it.[CategoryName]">
        </asp:EntityDataSource>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cena od:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Pole wymagane!"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Wartośd musi być liczbą całkowitą z zakresu od 0 do 99999!" MaximumValue="99999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cena do:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Pole wymagane!"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Wartośd musi być liczbą całkowitą z zakresu od 0 do 99999!" MaximumValue="99999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="Dolny próg ceny nie może być wyższy niż górny!" Operator="GreaterThanEqual" Type="Integer"></asp:CompareValidator>
        <br />
        <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Szukaj" />
        <br />
    </form>
</body>
</html>
