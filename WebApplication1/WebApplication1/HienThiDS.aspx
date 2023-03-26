<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HienThiDS.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="masv" DataSourceID="SqlDataSource1" GridLines="Vertical">
        <AlternatingRowStyle BackColor="Gainsboro" />
        <Columns>
            <asp:BoundField DataField="masv" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="masv" />
            <asp:BoundField DataField="hoten" HeaderText="Name" SortExpression="hoten" />
            <asp:BoundField DataField="diachi" HeaderText="Adress" SortExpression="diachi" />
            <asp:BoundField DataField="dienthoai" HeaderText="Phone" SortExpression="dienthoai" />
            <asp:BoundField DataField="malop" HeaderText="Malop" SortExpression="malop" />
            <asp:BoundField DataField="tenlop" HeaderText="Tenlop" SortExpression="tenlop" />
           <asp:TemplateField HeaderText="Anh">

               <ItemTemplate>
                     <asp:Image ID="Image1" runat="server" Width="50" Height="50px" ImageUrl='<%#"~/images/"+Eval("anh") %>' />
               </ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Chi tiet">
               <ItemTemplate>
                   <a href="xemthem.aspx?masv=<%# Eval("masv") %>" class="button">Chi Tiet</a>
               </ItemTemplate>
            </asp:TemplateField> 
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
        DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @masv"
        InsertCommand="INSERT INTO [sinhvien] ([hoten], [diachi], [dienthoai], [malop], [anh]) VALUES (@hoten, @diachi, @dienthoai, @malop, @anh)" 
        SelectCommand="select masv,hoten,dienthoai,diachi,anh,s.malop,l.tenlop
                            from sinhvien s , lophoc l
                            where s.malop = l.malop"
        UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [diachi] = @diachi, [dienthoai] = @dienthoai, [malop] = @malop, [anh] = @anh WHERE [masv] = @masv">
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

</asp:Content>
