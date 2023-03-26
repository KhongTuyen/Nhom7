<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="trangchuv2.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <form id="form1" runat="server">
         <asp:DataList ID="DataList1" runat="server" DataKeyField="masv" DataSourceID="SqlDataSource1" RepeatColumns="5">
             <ItemTemplate>
                 Max SV:
                 <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
                 <br />
                 Ho Ten:
                 <asp:Label ID="hotenLabel" runat="server" Text='<%# Eval("hoten") %>' />
                 <br />
                 Dia chi:
                 <asp:Label ID="diachiLabel" runat="server" Text='<%# Eval("diachi") %>' />
                 <br />
                 Phone:
                 <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Eval("dienthoai") %>' />
                 <br />
                 Ma Lop:
                 <asp:Label ID="malopLabel" runat="server" Text='<%# Eval("malop") %>' />
                 <br />
                 Anh:
                  <asp:Image ID="Image1" runat="server" Width="50" Height="50" ImageUrl='<%#"~/images/"+Eval("anh") %>' />
                 <br />
<br />
             </ItemTemplate>
         </asp:DataList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server"
             ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString3 %>" 
             SelectCommand="SELECT * FROM [sinhvien]"></asp:SqlDataSource>
     </form>
</asp:Content>
