@Code
    ViewData("Title") = "Room Rates"
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
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="tableHeader">
                Room Type
            </td>
            <td class="tableHeader">
                Rate (RM)
            </td>
        </tr>
        <tr>
            <td style="border: 1px solid black">
                @Html.ActionLink("Standard Room", "RoomStandard", "Home")
            </td>
            <td style="text-align: center;border: 1px solid black">
                -
            </td>
        </tr>
        <tr>
            <td style="border: 1px solid black">
                @Html.ActionLink("Deluxe Room", "RoomDeluxe", "Home")
            </td>
            <td style="text-align: center;border: 1px solid black">
                -
            </td>
        </tr>
        <tr>
            <td style="border: 1px solid black">
                @Html.ActionLink("Superior Deluxe Room", "RoomSupDeluxe", "Home")
            </td>
            <td style="text-align: center;border: 1px solid black">
                -
            </td>
        </tr>
        <tr>
            <td style="border: 1px solid black">
                @Html.ActionLink("Family Suite", "RoomFamily", "Home")
            </td>
            <td style="text-align: center;border: 1px solid black">
                -
            </td>
        </tr>
    </table>
</div>
