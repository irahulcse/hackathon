<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xy.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="empid" DataSourceID="SqlDataSource1" Width="646px">
            <Columns>
                <asp:BoundField DataField="empid" HeaderText="empid" InsertVisible="False" ReadOnly="True" SortExpression="empid" />
                <asp:BoundField DataField="empname" HeaderText="empname" SortExpression="empname" />
               <asp:TemplateField HeaderText="Image">
                   <ItemTemplate>
                       <asp:Image ID="image1" runat="server" Height="100px" Width="100px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((Byte[])Eval("empimg")) %>' />
                   </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=dream11;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Empdetails]"></asp:SqlDataSource>
    </form>
</body>
</html>
