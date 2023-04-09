<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xemthem.aspx.cs" Inherits="WebApplication1.xemthem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="masv" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="masv" HeaderText="masv" InsertVisible="False" ReadOnly="True" SortExpression="masv" />
            <asp:BoundField DataField="hoten" HeaderText="hoten" SortExpression="hoten" />
            <asp:BoundField DataField="diachi" HeaderText="diachi" SortExpression="diachi" />
            <asp:BoundField DataField="dienthoai" HeaderText="dienthoai" SortExpression="dienthoai" />
            <asp:BoundField DataField="malop" HeaderText="malop" SortExpression="malop" />
            <asp:TemplateField HeaderText="Anh">
               <ItemTemplate>
                     <asp:Image ID="Image1" runat="server" Width="50" Height="50px" ImageUrl='<%#"~/images/"+Eval("anh") %>' />
               </ItemTemplate>
           </asp:TemplateField>
        </Fields>
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString3 %>" 
        SelectCommand="SELECT * FROM [sinhvien] where masv=3">

        <SelectParameters>
            <asp:QueryStringParameter Name="masv" QueryStringField="masv" Type="Int16"/>
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
