<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="WebApplication1.StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        tr,td{
            border:1px solid #D8D8D8;
            padding:20px;
            
        }
        tr{
            box-shadow: #6E6E6E 0px 0px 1px 2px inset;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Danh sách sinh viên </h2>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="masv" DataSourceID="SqlDataSource1" RepeatColumns="5" RepeatDirection="Horizontal" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingItemStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <ItemTemplate>
                    masv:
                    <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
                    <br />
                    hoten:
                    <asp:Label ID="hotenLabel" runat="server" Text='<%# Eval("hoten") %>' />
                    <br />
                    diachi:
                    <asp:Label ID="diachiLabel" runat="server" Text='<%# Eval("diachi") %>' />
                    <br />
                    dienthoai:
                    <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Eval("dienthoai") %>' />
                    <br />
                    malop:
                    <asp:Label ID="malopLabel" runat="server" Text='<%# Eval("malop") %>' />
                    <br />
                    anh:
                    
                    <asp:Image ID="Image1" runat="server" Width="50" Height="50" ImageUrl='<%#"~/images/"+Eval("anh") %>' />
                    <br />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="<%$ ConnectionStrings:truonghocdb2ConnectionString %>" 
                DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @masv"
                InsertCommand="INSERT INTO [sinhvien] ([hoten], [diachi], [dienthoai], [malop], [anh]) VALUES (@hoten, @diachi, @dienthoai, @malop, @anh)" 
                SelectCommand="select masv,hoten,dienthoai,diachi,sinhvien.malop,lophoc.tenlop,anh
            from sinhvien,lophoc
            where sinhvien.malop=lophoc.malop" UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [diachi] = @diachi, [dienthoai] = @dienthoai, [malop] = @malop, [anh] = @anh WHERE [masv] = @masv">
                <DeleteParameters>
                    <asp:Parameter Name="masv" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="hoten" Type="String" />
                    <asp:Parameter Name="diachi" Type="String" />
                    <asp:Parameter Name="dienthoai" Type="String" />
                    <asp:Parameter Name="malop" Type="Int32" />
                    <asp:Parameter Name="anh" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="hoten" Type="String" />
                    <asp:Parameter Name="diachi" Type="String" />
                    <asp:Parameter Name="dienthoai" Type="String" />
                    <asp:Parameter Name="malop" Type="Int32" />
                    <asp:Parameter Name="anh" Type="String" />
                    <asp:Parameter Name="masv" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <a href="Addstudent.aspx">Thêm sinh viên</a>
        </div>
    </form>
</body>
</html>
