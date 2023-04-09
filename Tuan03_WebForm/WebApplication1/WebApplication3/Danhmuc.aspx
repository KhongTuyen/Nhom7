<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Danhmuc.aspx.cs" 
    Inherits="WebApplication3.Danhmuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="masv" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="masv" HeaderText="masv" InsertVisible="False" ReadOnly="True" SortExpression="masv" />
            <asp:BoundField DataField="hoten" HeaderText="hoten" SortExpression="hoten" />
            <asp:BoundField DataField="diachi" HeaderText="diachi" SortExpression="diachi" />
            <asp:BoundField DataField="dienthoai" HeaderText="dienthoai" SortExpression="dienthoai" />
            <asp:BoundField DataField="malop" HeaderText="malop" SortExpression="malop" />
             <asp:TemplateField HeaderText="Anh">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Width="50" Height="50px" ImageUrl='<%# Eval("anh") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString %>" 
       SelectCommand="select masv,hoten,dienthoai,diachi,anh,s.malop,l.tenlop
                            from sinhvien s , lophoc l
                            where s.malop = l.malop">
       <SelectParameters>
                <asp:QueryStringParameter Name="malop" Type="Int16" QueryStringField="malop" />
            </SelectParameters>

    </asp:SqlDataSource>

</asp:Content>
