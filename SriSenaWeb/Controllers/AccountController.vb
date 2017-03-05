Imports System.Diagnostics.CodeAnalysis
Imports System.Security.Principal
Imports System.Transactions
Imports System.Web.Routing
Imports DotNetOpenAuth.AspNet
Imports Microsoft.Web.WebPages.OAuth
Imports WebMatrix.WebData

<Authorize()> _
<InitializeSimpleMembership()> _
Public Class AccountController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Account/Login

    <AllowAnonymous()> _
    Public Function Login(ByVal returnUrl As String) As ActionResult
        ViewData("ReturnUrl") = returnUrl
        Return View()
    End Function

    '
    ' POST: /Account/Login

    <HttpPost()> _
    <AllowAnonymous()> _
    <ValidateAntiForgeryToken()> _
    Public Function Login(ByVal model As LoginModel, ByVal returnUrl As String) As ActionResult
        If ModelState.IsValid AndAlso WebSecurity.Login(model.UserName, model.Password, persistCookie:=model.RememberMe) Then
            Return RedirectToLocal(returnUrl)
        End If

        ' If we got this far, something failed, redisplay form
        ModelState.AddModelError("", "The user name or password provided is incorrect.")
        Return View(model)
    End Function

    '
    ' POST: /Account/LogOff

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Public Function LogOff() As ActionResult
        WebSecurity.Logout()

        Return RedirectToAction("Index", "Home")
    End Function

#Region "Helpers"
    Private Function RedirectToLocal(ByVal returnUrl As String) As ActionResult
        If Url.IsLocalUrl(returnUrl) Then
            Return Redirect(returnUrl)
        Else
            Return RedirectToAction("Index", "Home")
        End If
    End Function

    Public Enum ManageMessageId
        ChangePasswordSuccess
        SetPasswordSuccess
        RemoveLoginSuccess
    End Enum

    Friend Class ExternalLoginResult
        Inherits System.Web.Mvc.ActionResult

        Private ReadOnly _provider As String
        Private ReadOnly _returnUrl As String

        Public Sub New(ByVal provider As String, ByVal returnUrl As String)
            _provider = provider
            _returnUrl = returnUrl
        End Sub

        Public ReadOnly Property Provider() As String
            Get
                Return _provider
            End Get
        End Property

        Public ReadOnly Property ReturnUrl() As String
            Get
                Return _returnUrl
            End Get
        End Property

        Public Overrides Sub ExecuteResult(ByVal context As ControllerContext)
            OAuthWebSecurity.RequestAuthentication(Provider, ReturnUrl)
        End Sub
    End Class

    Public Function ErrorCodeToString(ByVal createStatus As MembershipCreateStatus) As String
        ' See http://go.microsoft.com/fwlink/?LinkID=177550 for
        ' a full list of status codes.
        Select Case createStatus
            Case MembershipCreateStatus.DuplicateUserName
                Return "User name already exists. Please enter a different user name."

            Case MembershipCreateStatus.DuplicateEmail
                Return "A user name for that e-mail address already exists. Please enter a different e-mail address."

            Case MembershipCreateStatus.InvalidPassword
                Return "The password provided is invalid. Please enter a valid password value."

            Case MembershipCreateStatus.InvalidEmail
                Return "The e-mail address provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidAnswer
                Return "The password retrieval answer provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidQuestion
                Return "The password retrieval question provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidUserName
                Return "The user name provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.ProviderError
                Return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator."

            Case MembershipCreateStatus.UserRejected
                Return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator."

            Case Else
                Return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator."
        End Select
    End Function
#End Region

End Class
