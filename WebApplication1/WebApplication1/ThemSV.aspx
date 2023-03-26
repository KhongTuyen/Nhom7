<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemSV.aspx.cs" Inherits="WebApplication1.ThemSV" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>THÊM SINH VIÊN </title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Thêm sinh viên</h2>
            
            <asp:FormView ID="FormView1" runat="server" DataKeyNames="masv" 
                DataSourceID="SqlDataSource1" Width="340px"
                DefaultMode="Insert" OnItemInserted="InsertedCmd" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both">
                <EditItemTemplate>
                    masv:
                    <asp:Label ID="masvLabel1" runat="server" Text='<%# Eval("masv") %>' />
                    <br />
                    hoten:
                    <asp:TextBox ID="hotenTextBox" runat="server" Text='<%# Bind("hoten") %>' />
                    <br />
                    diachi:
                    <asp:TextBox ID="diachiTextBox" runat="server" Text='<%# Bind("diachi") %>' />
                    <br />
                    dienthoai:
                    <asp:TextBox ID="dienthoaiTextBox" runat="server" Text='<%# Bind("dienthoai") %>' />
                    <br />
                    malop:
                    <asp:TextBox ID="malopTextBox" runat="server" Text='<%# Bind("malop") %>' />
                    <br />
                    anh:
                    <asp:TextBox ID="anhTextBox" runat="server" Text='<%# Bind("anh") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    Họ tên:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="hotenTextBox" runat="server" Text='<%# Bind("hoten") %>' />
                    <br />
                    <br />
                    Địa chỉ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="diachiTextBox" runat="server" Text='<%# Bind("diachi") %>' />
                    <br />
                    <br />
                    Điện thoại:
                    <asp:TextBox ID="dienthoaiTextBox" runat="server" Text='<%# Bind("dienthoai") %>' />
                    <br />
                    <br />
                    Mã lớp:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource22" DataTextField="tenlop" DataValueField="malop" 
                        SelectedValue='<%# Bind("malop") %>'>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource22" runat="server" ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString3 %>" 
                        SelectCommand="SELECT * FROM [lophoc]"></asp:SqlDataSource>
                    <br />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    <br />
                    Ảnh&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="anhTextBox" runat="server" Text='<%# Bind("anh") %>' />
                    <br />
                    <a href="javascript:__doPostBack('ctl01$InsertButton','')">T</a>hêm SV&nbsp; <a href="javascript:__doPostBack('ctl01$InsertCancelButton','')">H</a>ủy
                </InsertItemTemplate>
                <ItemTemplate>
                    masv:
                    <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
                    <br />
                    hoten:
                    <asp:Label ID="hotenLabel" runat="server" Text='<%# Bind("hoten") %>' />
                    <br />
                    diachi:
                    <asp:Label ID="diachiLabel" runat="server" Text='<%# Bind("diachi") %>' />
                    <br />
                    dienthoai:
                    <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Bind("dienthoai") %>' />
                    <br />
                    malop:
                    <asp:Label ID="malopLabel" runat="server" Text='<%# Bind("malop") %>' />
                    <br />
                    anh:
                    <asp:Label ID="anhLabel" runat="server" Text='<%# Bind("anh") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
            </asp:FormView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString3 %>" DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @masv" InsertCommand="INSERT INTO [sinhvien] ([hoten], [diachi], [dienthoai], [malop], [anh]) VALUES (@hoten, @diachi, @dienthoai, @malop, @anh)" SelectCommand="SELECT * FROM [sinhvien]" UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [diachi] = @diachi, [dienthoai] = @dienthoai, [malop] = @malop, [anh] = @anh WHERE [masv] = @masv">
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
            <br />
            <br />
           
            <asp:Label ID="errmsg" runat="server" ForeColor="Red" />
       
            <br />
            <a href="Danhsach.aspx" style=" border: 1px solid black; background-color:yellow; text-decoration:none;">XEM DANH SÁCH SINH VIÊN </a>
            
        </div>
    </form>
</body>
</html>