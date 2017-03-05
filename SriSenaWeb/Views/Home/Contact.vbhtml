@Code
    ViewData("Title") = "Contact Us"
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
            </td>
        </tr>
        <tr>
            <td class="TableHeader" colspan="2">
                Sri Sena Hotel - Kangar, Perlis
            </td>
        </tr>
        <tr>
            <td class="TableRowTitle">
                <label>
                    By Phone
                </label>
            </td>
            <td>
                04-970 5015
            </td>
        </tr>
        <tr style="vertical-align: top">
            <td class="TableRowTitle">
                <label>
                    By Mail
                </label>
            </td>
            <td>
                No. 52, Tingkat Bawah Jalan Medan Niaga Taman Seri Firdaus, 01000 Perlis
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>
                        @Html.ActionLink("Enquiry Form", "Enquiry", "Home")
                    </li>
                </ul>
            </td>
        </tr>
    </table>
</div>
