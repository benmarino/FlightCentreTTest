<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlightCentreTTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <main>

    <div class="row">
        <a href="Scripts/">Scripts/</a>
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">
            <h2 id="gettingStartedTitle">Flight Centre Tech Test</h2>
            <asp:Literal ID="litFlightCount" runat="server" />
            <p><asp:TextBox MaxLength="100" runat="server" ID="txtFlightInput" />
                
                <asp:RequiredFieldValidator ErrorMessage="Please enter a flight count" ControlToValidate="txtFlightInput" ID="rfvTextInput" runat="server" />
                <asp:Button ID="btnGetFlightCount" Text="How many Flights?" runat="server" OnClick="btnGetFlightCount_Click" />

            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </section>
     
    </div>
</main>
</asp:Content>
