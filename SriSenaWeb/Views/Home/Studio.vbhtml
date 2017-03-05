@Code
    ViewData("Title") = "Studio Recording"
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
            <td>
                <img src="/Images/studioRecording.jpg" alt="" />
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
                        @Html.ActionLink("Recording Samples", "StudioSample", "Home")
                    </li>
                </ul>
            </td>
        </tr>
    </table>
</div>
