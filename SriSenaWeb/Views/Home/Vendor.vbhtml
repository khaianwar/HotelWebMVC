@Code
    ViewData("Title") = "Vendors"
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
                <img src="/Images/vendors.jpg" alt="" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>
                        @Html.ActionLink("Fashion Vendors", "VendorFashion", "Home")
                    </li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>
                        @Html.ActionLink("Food & Beverage Vendors", "VendorFood", "Home")
                    </li>
                </ul>
            </td>
        </tr>
    </table>
</div>
