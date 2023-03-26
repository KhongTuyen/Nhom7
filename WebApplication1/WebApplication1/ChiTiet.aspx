<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="masv" DataSourceID="SqlDataSource1" GridLines="Vertical" style="margin-right: 40px" Width="573px" Height="182px">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="masv" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="masv" />
            <asp:BoundField DataField="hoten" HeaderText="Name" SortExpression="hoten" />
            <asp:BoundField DataField="diachi" HeaderText="Adress" SortExpression="diachi" />
            <asp:BoundField DataField="dienthoai" HeaderText="Phone" SortExpression="dienthoai" />
            <asp:BoundField DataField="malop" HeaderText="Malop" SortExpression="malop" />
            <asp:BoundField DataField="tenlop" HeaderText="Tenlop" SortExpression="tenlop" />
            <asp:BoundField DataField="anh" HeaderText="Anh" SortExpression="anh" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:truonghocdb2ConnectionString %>"
        SelectCommand="select masv, hoten, dienthoai, diachi,anh, s.malop, l.tenlop from sinhvien s, lophoc l 
            where s.malop=l.malop and s.malop=@malop">

         <SelectParameters>
                <asp:QueryStringParameter Name="malop" Type="Int16" QueryStringField="malop" />
            </SelectParameters>

    </asp:SqlDataSource>
</asp:Content>
