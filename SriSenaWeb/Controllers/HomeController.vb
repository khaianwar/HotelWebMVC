Imports System.Net.Mail
Imports System.IO

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Home"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "About Us"

        Return View()
    End Function

    Function Location() As ActionResult
        ViewData("Message") = "Our Location"

        Return View()
    End Function

    Function Facebook() As ActionResult
        Return Redirect("https://www.facebook.com/srisenahotel/")
    End Function

    Function Room() As ActionResult
        ViewData("Message") = "Room Rates"

        Return View()
    End Function

    Function RoomVacant() As ActionResult
        ViewData("Message") = "Room Availability"

        Return View()
    End Function

    Function RoomStandard() As ActionResult
        ViewData("Message") = "Standard Room"

        Return View()
    End Function

    Function RoomDeluxe() As ActionResult
        ViewData("Message") = "Deluxe Room"

        Return View()
    End Function

    Function RoomSupDeluxe() As ActionResult
        ViewData("Message") = "Superior Deluxe Room"

        Return View()
    End Function

    Function RoomFamily() As ActionResult
        ViewData("Message") = "Family Suite"

        Return View()
    End Function

    Function Studio() As ActionResult
        ViewData("Message") = "Studio Recording"

        Return View()
    End Function

    Function StudioSample() As ActionResult
        ViewData("Message") = "Recording Samples"

        Return View()
    End Function

    Function Vendor() As ActionResult
        ViewData("Message") = "Vendors"

        Return View()
    End Function

    Function VendorFashion() As ActionResult
        ViewData("Message") = "Fashion Vendors"

        Return View()
    End Function

    Function VendorFood() As ActionResult
        ViewData("Message") = "Food & Beverage Vendors"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact Us"

        Return View()
    End Function

    Function Enquiry() As ActionResult
        ViewData("Message") = "Enquiry Form"

        Return View()
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Feedback(model As FeedbackModel) As ActionResult
        Try
            SendEmail("enquiry@SriSenaHotel.com", _
                      "srisena@SriSenaHotel.com", _
                      "Enquiry Form Submission", _
                      FeedbackToString(model))
        Catch ex As Exception

        End Try
        Return RedirectToAction("Enquiry")
    End Function

    Private Function FeedbackToString(ByVal model As FeedbackModel) As String
        Dim strOutput As String = String.Empty
        strOutput &= "Name: " & model.Name
        strOutput &= "<br />Company: " & model.Company
        strOutput &= "<br />City: " & model.City
        strOutput &= "<br />Email: " & model.Email
        strOutput &= "<br />ContactNo: " & model.ContactNo
        strOutput &= "<br />Feedback: " & model.Feedback
        Return strOutput
    End Function

    Private Sub SendEmail(ByVal fromEmail As String, ByVal toEmail As String, _
                          ByVal subject As String, ByVal message As String)
        Try
            '(1) Create the MailMessage instance
            Dim mm As New MailMessage()
            mm.From = New MailAddress(fromEmail)
            mm.To.Add(toEmail)  ' Multiple email addresses are separated with a comma character (","). 

            '(2) Assign the MailMessage's properties
            mm.Subject = subject
            mm.Body = message
            mm.IsBodyHtml = True

            mm.Headers.Add("Disposition-Notification-To", fromEmail)
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            '(3) Create the SmtpClient object
            Dim smtp As New SmtpClient
            If Not Directory.Exists(smtp.PickupDirectoryLocation) Then Directory.CreateDirectory(smtp.PickupDirectoryLocation)
            smtp.Host = "mail.beraswangimalaysia.com"
            smtp.Port = 25
            '(4) Send the MailMessage
            smtp.SendAsync(mm, mm)

        Catch ex As Exception
        End Try
    End Sub
End Class