<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Control2_v2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <!– jQuery first, then Popper.js, then Bootstrap JS –>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>



<body>
    <form id="form1" runat="server">
    <div style="text-align: center" class="container">
    
        <h3>Inicio de sesión</h3>
    
        <asp:Label ID="lbl_error" runat="server" style="color: #CC0000"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt_usuario" runat="server" ToolTip="Usuario" placeholder="Usuario"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txt_clave" runat="server" TextMode="Password" placeholder="Contraseña" style="text-align: justify;" ToolTip="Contraseña"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bnt_ingresar" runat="server" OnClick="bnt_ingresar_Click" Text="Ingresar" CssClass="btn-success"/>
    
    </div>
    </form>
</body>
</html>
