@Code
    ViewData("Title") = "About Us"
End Code
<div>
    <table>
        <tr>
            <td>
                <h1>@ViewData("Message")</h1>
            </td>
        </tr>
        <tr>
            <td>
                <img src="/Images/mainHotel.jpg" alt="" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>
                        @Html.ActionLink("Hotel Location", "Location", "Home")
                    </li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>
                        @Html.ActionLink("Facebook Page", "Facebook", "Home")
                    </li>
                </ul>
            </td>
        </tr>
    </table>
</div>
