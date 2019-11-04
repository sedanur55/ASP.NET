<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeBehind="giris.aspx.cs" Inherits="sinav.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 800px;
            height: 32px;
        }
        .auto-style4 {
            width: 125px;
        }
        .sorgu{
            font-size:18px;
        }
        </style>
</head>

<body>
    <form id="form1" runat="server" align="center">
        <asp:dropdownlist runat="server" ID="baslik" name="baslik"  Width="800px" AutoPostBack="True" OnSelectedIndexChanged="baslik_SelectedIndexChanged"  >
        </asp:dropdownlist>
        
    <p>
        &nbsp;<asp:TextBox ID="TextBox17"  name="TextBox17" class="sorgu" runat="server" Height="291px" Width="800px" TextMode="MultiLine" ></asp:TextBox>
        </p>
        
    <p>
        &nbsp;<asp:TextBox ID="TextBox18" name="TextBox18" class="auto-style3" runat="server" Height="20px" Width="800px"  placeholder="1-)" TextMode="MultiLine" ></asp:TextBox>
        </p>

    
        <asp:TextBox ID="TextBox1" name="TextBox1" runat="server" Width="400px"  placeholder="A-)"></asp:TextBox>
        <asp:TextBox ID="TextBox2"  name="TextBox2" runat="server"  Width="400px" placeholder="B-)"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox3"  name="TextBox3"  runat="server" Width="400px" placeholder="C-)"></asp:TextBox>
            <asp:TextBox ID="TextBox4"  name="TextBox4" runat="server" Width="400px" placeholder="D-)"></asp:TextBox>
        </p>
    
   <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
        </asp:DropDownList>
        <p>
        &nbsp;<asp:TextBox ID="TextBox19" name="TextBox19" class="auto-style3" runat="server" Height="20px" Width="800px"  placeholder="2-)" TextMode="MultiLine" ></asp:TextBox>
        </p>

    
        <asp:TextBox ID="TextBox5" name="TextBox5" runat="server" Width="400px" placeholder="A-)"></asp:TextBox>
        <asp:TextBox ID="TextBox6" name="TextBox6" runat="server" Width="400px" placeholder="B-)"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox7" name="TextBox7" runat="server" Width="400px" placeholder="C-)"></asp:TextBox>
            <asp:TextBox ID="TextBox8" name="TextBox8" runat="server" Width="400px" placeholder="D-)"></asp:TextBox>
        </p>
    
   <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
        </asp:DropDownList>
        <p>
        &nbsp;<asp:TextBox ID="TextBox20" name="TextBox20" class="auto-style3" runat="server" Height="20px" Width="800px"  placeholder="3-)" TextMode="MultiLine" ></asp:TextBox>
        </p>

    
        <asp:TextBox ID="TextBox9" name="TextBox9" runat="server" Width="400px" placeholder="A-)"></asp:TextBox>
        <asp:TextBox ID="TextBox10" name="TextBox10" runat="server"  Width="400px" placeholder="B-)"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox11" name="TextBox11" runat="server" Width="400px" placeholder="C-)"></asp:TextBox>
            <asp:TextBox ID="TextBox12" name="TextBox12" runat="server" Width="400px" placeholder="D-)"></asp:TextBox>
        </p>
    
    <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
        </asp:DropDownList>
        <p>
        &nbsp;<asp:TextBox ID="TextBox21" name="TextBox21" class="auto-style3" runat="server" Height="20px" Width="800px" TextMode="MultiLine"  placeholder="4-)" ></asp:TextBox>
        </p>

    
        <asp:TextBox ID="TextBox13" name="TextBox13" runat="server" Width="400px" placeholder="A-)"></asp:TextBox>
        <asp:TextBox ID="TextBox14" name="TextBox14" runat="server" Width="400px"  placeholder="B-)"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox15" name="TextBox15" runat="server" Width="400px" placeholder="C-)"></asp:TextBox>
            <asp:TextBox ID="TextBox16" name="TextBox16" runat="server" Width="400px" placeholder="D-)"></asp:TextBox>
        </p>
    
   <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
        </asp:DropDownList>
&nbsp;<p>
            <asp:Button ID="Button1" runat="server" Text="SINAV OLUŞTUR" Width="256px" OnClick="Button1_Click" />
        </p>

    </form>
</body>
</html>
