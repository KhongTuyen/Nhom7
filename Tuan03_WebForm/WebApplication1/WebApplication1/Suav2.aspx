<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Suav2.aspx.cs" Inherits="WebApplication1.Suav2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="masv" DataSourceID="SqlDataSource1">
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
            <InsertItemTemplate>
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
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
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
              
            </ItemTemplate>
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
    </form>
</asp:Content>
