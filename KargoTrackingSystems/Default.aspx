<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KargoTrackingSystems.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aquamarine">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Kargo Adı :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxKargoAdi" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="Label2" runat="server" Text="Kargo Numarası :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbxKargoNumarasi" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Kargo Açıklaması :"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="tbxKargoAciklamasi" runat="server" Height="109px" Width="294px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Sonuç :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSonuc" runat="server" Text="[lblSonuc]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnUrunEkle" runat="server" Text="Ürün Ekle" Width="131px" OnClick="btnUrunEkle_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSil" runat="server" Text="Ürün Sil" Width="131px" OnClick="btnSil_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUrunGuncelle" runat="server" Text="Ürün Güncelle" Width="131px" OnClick="btnUrunGuncelle_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUrunListele" runat="server" Text="Ürün Listele" Width="132px" OnClick="btnUrunListele_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:GridView ID="GridView1" runat="server" Height="187px" Width="883px" BackColor="White">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
