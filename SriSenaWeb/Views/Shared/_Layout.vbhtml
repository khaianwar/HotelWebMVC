<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>@ViewData("Title") - Sri Sena Hotel</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width" />
    @Styles.Render("~/style/master")
    @Scripts.Render("~/scripts/master")
</head>
<body>
    <div id="menu">
        <ul>
            <li id="tab0" class="l1">@Html.ActionLink("Home", "Index", "Home")</li>
            <li id="tab1" class="l1">@Html.ActionLink("About Us", "About", "Home")</li>
            <li class="l2"></li>
            <li class="l3">@Html.ActionLink("Location", "Location", "Home")</li>
            <li class="l3">@Html.ActionLink("Facebook", "Facebook", "Home")</li>
            <li id="tab2" class="l1">@Html.ActionLink("Room Rates", "Room", "Home")</li>
            <li class="l2"></li>
            <li class="l3">@Html.ActionLink("Availability", "RoomVacant", "Home")</li>
            <li class="l3">@Html.ActionLink("Standard Room", "RoomStandard", "Home")</li>
            <li class="l3">@Html.ActionLink("Deluxe Room", "RoomDeluxe", "Home")</li>
            <li class="l3">@Html.ActionLink("Superior Deluxe Room", "RoomSupDeluxe", "Home")</li>
            <li class="l3">@Html.ActionLink("Family Suite", "RoomFamily", "Home")</li>
            <li id="tab3" class="l1">@Html.ActionLink("Studio Recording", "Studio", "Home")</li>
            <li class="l2"></li>
            <li class="l3">@Html.ActionLink("Samples", "StudioSample", "Home")</li>
            <li id="tab4" class="l1">@Html.ActionLink("Vendors", "Vendor", "Home")</li>
            <li class="l2"></li>
            <li class="l3">@Html.ActionLink("Fashion", "VendorFashion", "Home")</li>
            <li class="l3">@Html.ActionLink("Food & Beverages", "VendorFood", "Home")</li>
            <li id="tab5" class="l1">@Html.ActionLink("Contact Us", "Contact", "Home")</li>
            <li class="l2"></li>
            <li class="l3">@Html.ActionLink("Enquiry Form", "Enquiry", "Home")</li>
        </ul>
    </div>
    <div class="wrapper">
        <div class="header">
        </div>
        <div id="mainContent" class="pagecontent">
            <div class="bodycontent landingbodycontent">
                <div class="">
                    @RenderBody()
                </div>
            </div>
        </div>
    </div>
</body>
</html>
