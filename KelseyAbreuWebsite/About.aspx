<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="KelseyAbreuWebsite.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <canvas id="WheelImageCanvas" width="600" height="600">

    </canvas>

    <script>
        var canvas = document.getElementById('WheelImageCanvas');
        var context = canvas.getContext('2d');
        var imageObj = new Image();
        var imageObj2 = new Image();
        var CanvasMidWidth = $("#WheelImageCanvas").width()/2;
        var CanvasMidHeight = $("#WheelImageCanvas").height() / 2;
        var ImageWidth = 50;
        var ImageHeight = 50;
        var CanvasPadding = .80;

        function toRadians(angle) {
            return angle * (Math.PI / 180);
        }

        function toDegrees(angle) {
            return angle * (180 / Math.PI);
        }
        imageObj2.onload = function () {
            context.drawImage(imageObj2, 0, 0, 600, 600);
        }
        imageObj2.src = "/Images/unit-circle.png";

        imageObj.onload = function () {
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(0)) * CanvasPadding - ImageWidth/2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(0)) * CanvasPadding - ImageHeight/2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(180)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(180)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(90)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(90)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(270)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(270)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(45)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(45)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(135)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(135)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(225)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(225)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
            context.drawImage(imageObj, CanvasMidWidth + CanvasMidWidth * Math.cos(toRadians(315)) * CanvasPadding - ImageWidth / 2, CanvasMidHeight - CanvasMidHeight * Math.sin(toRadians(315)) * CanvasPadding - ImageHeight / 2, ImageWidth, ImageHeight);
        }
        imageObj.src = "/Images/darth-vader.jpg";

    </script>
</asp:Content>
