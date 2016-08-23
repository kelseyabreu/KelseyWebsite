<%@ Page Title="The Niggaz" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TheNiggaz.aspx.cs" Inherits="KelseyAbreuWebsite.TheNiggaz" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">
    <h1 style="text-align:center;">The Niggas</h1>
    
    <div class="selector">
        <img id="SelectedImage" src="Images/TheNiggaz/img1.jpg" alt="Submit" width="140" height="140" style="border-radius:25px;">

        <ul>
          <li>
            <input id="img1" type="checkbox">
            <label for="img1" class="imgLabels"><img src="Images/TheNiggaz/img1.jpg" class="circleImg img1 imgClass"/></label>
          </li>
          <li>
            <input id="img2" type="checkbox">
            <label for="img2" class="imgLabels"><img src="Images/TheNiggaz/img2.jpg" class="circleImg img2 imgClass" /></label>
          </li>
          <li>
            <input id="img3" type="checkbox">
            <label for="img3" class="imgLabels"><img src="Images/TheNiggaz/img3.jpg" class="circleImg img3 imgClass"/></label>
          </li>
          <li>
            <input id="img4" type="checkbox">
            <label for="img4" class="imgLabels"><img src="Images/TheNiggaz/img4.jpg" class="circleImg img4 imgClass"/></label>
          </li>
          <li>
            <input id="img5" type="checkbox">
            <label for="img5" class="imgLabels"><img src="Images/TheNiggaz/img5.jpg" class="circleImg img5 imgClass"/></label>
          </li>
          <li>
            <input id="img6" type="checkbox">
            <label for="img6" class="imgLabels"><img src="Images/TheNiggaz/img6.jpg" class="circleImg img6 imgClass"/></label>
          </li>
          <li>
            <input id="img7" type="checkbox">
            <label for="img7" class="imgLabels"><img src="Images/TheNiggaz/img7.jpg" class="circleImg img7 imgClass"/></label>
          </li>
          <li>
            <input id="img8" type="checkbox">
            <label for="img8" class="imgLabels"><img src="Images/TheNiggaz/img8.jpg" class="circleImg img8 imgClass" /></label>
          </li>
        </ul>
    </div>
        <script>
            $(document).ready(function () {
                $('.selector button').click(function (e) {
                    toggleOptions($(this).parent());
                });

                setTimeout(function () { toggleOptions('.selector'); }, 100);

                $(".circleImg").click(function () {
                    $("#SelectedImage").attr('src', $(this).attr('src'));
                });

                $(".divFooter").hide();
            });
            var nbOptions = 8; // number of mah niggas
            var angleStart = -360; // start angle

            // jquery rotate animation
            function rotate(li, d) {
                $({ d: angleStart }).animate({ d: d }, {
                    step: function (now) {
                        $(li)
                          .css({ transform: 'rotate(' + now + 'deg)' })
                          .find('label')
                           .css({ transform: 'rotate(' + (-now) + 'deg)' });
                    }, duration: 0
                });
            }

            // show / hide the options
            function toggleOptions(imgWrapper) {
                $(imgWrapper).toggleClass('open');
                var li = $(imgWrapper).find('li');
                var deg = $(imgWrapper).hasClass('half') ? 180 / (li.length - 1) : 360 / li.length;
                for (var i = 0; i < li.length; i++) {
                    var d = $(imgWrapper).hasClass('half') ? (i * deg) - 90 : i * deg;
                    $(imgWrapper).hasClass('open') ? rotate(li[i], d) : rotate(li[i], angleStart);
                }
            }
    </script>
</asp:content>
