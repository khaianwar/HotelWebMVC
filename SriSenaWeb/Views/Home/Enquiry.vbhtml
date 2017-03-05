@Code
    ViewData("Title") = "Enquiry Form"
End Code
<h1>@ViewData("Message")</h1>
@Using Html.BeginForm("Feedback", "Home", Nothing, FormMethod.Post)
    @Html.AntiForgeryToken()
    @<table>
        <tr>
            <td style="color: #FF0000;width: 5px;">
                *
            </td>
            <td style="width: 130px;"}>
                Name
            </td>
            <td style="width: 10px;"}>
                :
            </td>
            <td>
                @Html.TextBox("Name", "", New With {.style = "width: 300px;"})
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                Company Name
            </td>
            <td>
                :
            </td>
            <td>
                @Html.TextBox("Company", "", New With {.style = "width: 300px;"})
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                City
            </td>
            <td>
                :
            </td>
            <td>
                @Html.TextBox("City", "", New With {.style = "width: 300px;"})
            </td>
        </tr>
        <tr>
            <td style="color: #FF0000;">
                *
            </td>
            <td>
                Email Address
            </td>
            <td>
                :
            </td>
            <td>
                @Html.TextBox("Email", "", New With {.style = "width: 300px;"})
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                Contact Number
            </td>
            <td>
                :
            </td>
            <td>
                @Html.TextBox("ContactNo", "", New With {.style = "width: 300px;"})
            </td>
        </tr>
        <tr style="vertical-align: top">
            <td style="color: #FF0000;">
                *
            </td>
            <td>
                Feedback
            </td>
            <td>
                :
            </td>
            <td>
                @Html.TextArea("Feedback", "", New With {.style = "width: 302px;height: 60px;resize:none;"})
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td style="float: right;">
                <input id="btnClear" type="button" value="Clear" />
                <input id="btnSubmit" type="button" value="Submit" />
                <input id="btnSend" style="display: none;" type="submit" value="Submit" />
            </td>
        </tr>
    </table>
End Using
<script language="javascript" type="text/javascript" >
    $(document).ready(function () {
        $("#btnClear").click(function () {
            $("#Name").val("");
            $("#Company").val("");
            $("#City").val("");
            $("#Email").val("");
            $("#ContactNo").val("");
            $("#Feedback").val("");
        });
        $("#btnSubmit").click(function () {
            if ($("#Name").val().trim() == '') {
                alert('Please fill in your name.');
            }
            else if ($("#Email").val().trim() == '') {
                alert('Please fill in your email address.');
            }
            else if ($("#Feedback").val().trim() == '') {
                alert('Please fill in your feedback.');
            }
            else {
                alert('Thank you ' + $("#Name").val().trim() + '.\n\nYour feedback is highly appreciated.');
                $("#btnSend").click();
            }
        });
    });
</script>