<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Danhsach.aspx.cs" Inherits="WebApplication1.Danhsach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>DANH SÁCH SINH VIÊN </h2>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="masv" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 60px" Width="716px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="masv" HeaderText="Mã Sinh Viên " InsertVisible="False" ReadOnly="True" SortExpression="masv" />
                    <asp:BoundField DataField="hoten" HeaderText="Họ Tên " SortExpression="hoten" />
                    <asp:BoundField DataField="diachi" HeaderText="Địa chỉ " SortExpression="diachi" />
                    <asp:BoundField DataField="dienthoai" HeaderText="Phone" SortExpression="dienthoai" />
                    <asp:BoundField DataField="malop" HeaderText="Mã lớp " SortExpression="malop" />
                    <asp:BoundField DataField="anh" HeaderText="Image" SortExpression="anh" />
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                CommandName="Delete"  Text="Xóa" HeaderText="Xoa" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa không ?')"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:truonghocdb1ConnectionString3 %>" DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([diachi] = @original_diachi) OR ([diachi] IS NULL AND @original_diachi IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))" InsertCommand="INSERT INTO [sinhvien] ([hoten], [diachi], [dienthoai], [malop], [anh]) VALUES (@hoten, @diachi, @dienthoai, @malop, @anh)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [sinhvien]" UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [diachi] = @diachi, [dienthoai] = @dienthoai, [malop] = @malop, [anh] = @anh WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([diachi] = @original_diachi) OR ([diachi] IS NULL AND @original_diachi IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_masv" Type="Int32" />
                <asp:Parameter Name="original_hoten" Type="String" />
                <asp:Parameter Name="original_diachi" Type="String" />
                <asp:Parameter Name="original_dienthoai" Type="String" />
                <asp:Parameter Name="original_malop" Type="Int32" />
                <asp:Parameter Name="original_anh" Type="String" />
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
                <asp:Parameter Name="original_masv" Type="Int32" />
                <asp:Parameter Name="original_hoten" Type="String" />
                <asp:Parameter Name="original_diachi" Type="String" />
                <asp:Parameter Name="original_dienthoai" Type="String" />
                <asp:Parameter Name="original_malop" Type="Int32" />
                <asp:Parameter Name="original_anh" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
    <br />
        <a href="ThemSV.aspx" style=" border: 1px solid black; background-color:yellow; text-decoration:none;">THÊM SINH VIÊN </a><br/><br/>
       <a href="Edit.aspx" style=" border: 1px solid black; background-color:yellow; text-decoration:none;">SỬA THÔNG TIN SINH VIÊN </a>
</body>
</html>
