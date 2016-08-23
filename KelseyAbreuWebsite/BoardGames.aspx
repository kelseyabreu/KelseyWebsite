<%@ Page Title="Board Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardGames.aspx.cs" Inherits="KelseyAbreuWebsite.BoardGames" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="hGameName" runat="server" style="text-align:center;"></h1>
    <div class="row" style="margin-top:15px;margin-bottom:15px">
        <asp:Button ID="btnAddPlayer" runat="server" style="float:left;width:15%" CssClass="btn btn-info" Text="Add Player" OnClientClick="AddPlayer(); return false;"/>
        <asp:Button ID="btnSavePlayers" runat="server" style="float:right;width:15%" CssClass="btn btn-success" Text="Save" OnClick="btnSavePlayers_Click" OnClientClick="SavePlayers()"/>
    </div>
    <div id="divStatus" runat="server"></div>
    <div class="row">
        <asp:DataGrid ID="dgPlayerList" runat="server" AutoGenerateColumns="False" CssClass="table table-hover table-striped PlayerList" GridLines="None" UseAccessibleHeader="true" ValidateRequestMode="Disabled" AlternatingItemStyle-BackColor="WhiteSmoke">
            <Columns>
                <asp:BoundColumn    HeaderStyle-CssClass="TableHeader20" DataField="Name" HeaderText="Player Name" ></asp:BoundColumn>
                <asp:BoundColumn    HeaderStyle-CssClass="TableHeader20" DataField="TotalGames" HeaderText="Total Plays"></asp:BoundColumn>
                <asp:BoundColumn    HeaderStyle-CssClass="TableHeader20" DataField="TotalWins" HeaderText="Wins"></asp:BoundColumn>
                <asp:BoundColumn    HeaderStyle-CssClass="hiddenColumn" ItemStyle-CssClass="hiddenColumn" FooterStyle-CssClass="hiddenColumn" DataField="PlayerID" HeaderText="PlayerID"></asp:BoundColumn>
                <asp:TemplateColumn HeaderStyle-CssClass="TableHeader15" HeaderText="Losses" ><ItemTemplate><div class="Losses"></div></ItemTemplate></asp:TemplateColumn>
                <asp:TemplateColumn HeaderStyle-CssClass="TableHeader15" HeaderText="Ratio" ><ItemTemplate><div class="Ratio" ></div></ItemTemplate></asp:TemplateColumn>
                <asp:TemplateColumn HeaderStyle-CssClass="TableHeader10"><ItemTemplate><a class="btn btn-xs btn-primary EditButton" style="text-align:center;" onclick="EditPlayer(this)">Edit</a></ItemTemplate></asp:TemplateColumn>
            </Columns>
            <FooterStyle />
        </asp:DataGrid>
    </div>

    <asp:HiddenField ID="hfPlayerStats" runat="server" ClientIDMode="Static"/>
</asp:Content>
