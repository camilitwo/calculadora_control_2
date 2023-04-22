<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="Control2_V2._1.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body style="text-align: center" onload="carga()" >
    <form id="form1" runat="server">
    <div id="formError" class="container">
        <asp:Label ID="lbl_error2" runat="server" style="color: #CC0000"></asp:Label>
        <asp:Label ID="lbl_error" runat="server" style="color: #CC0000"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="link_login" runat="server" OnClick="link_login_Click">login...</asp:LinkButton>
&nbsp;
        <asp:Label ID="lbl_nombre" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Núm 1"></asp:Label>
        <asp:TextBox ID="txt_num1" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Núm 2"></asp:Label>
        <asp:TextBox ID="txt_num2" runat="server" ></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="btn_suma" runat="server" OnClick="btn_suma_Click" Text="Sumar" 
            CssClass="btn btn-primary btn-sm" />

        <asp:Button ID="btn_resta" runat="server" OnClick="btn_resta_Click" Text="Restar" 
            CssClass="btn btn-primary btn-sm" />

        <asp:Button ID="btn_mult" runat="server" OnClick="btn_mult_Click" style="height: 29px" Text="Multiplicar" 
            CssClass="btn btn-primary btn-sm" />
        <asp:Button ID="btn_div" runat="server" OnClick="btn_div_Click" Text="Dividir" 
            CssClass="btn btn-primary btn-sm"/>
        <br />
        <br />
        <asp:Label ID="lbl_result" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
