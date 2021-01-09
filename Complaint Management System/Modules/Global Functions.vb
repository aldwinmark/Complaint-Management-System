Imports MySql.Data.MySqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module Global_Functions

    Public Function CSQ(ByVal str)
        If IsDBNull(str) Then str = ""
        CSQ = Replace(str, "'", "''")

        'Function CSQ(byVal str)
        'If IsNull(str) Then str = ""
        'CSQ = Replace(str, "'", "''")
        'End Function

        'myvar = "Bob's Diner"

        'Sql = "INSERT INTO tablename (myvar, myvar2) VALUES ('" & CSQ(myvar) & "','" & CSQ(myvar2) & "')"
        'rs = Conn.Execute(Sql)

    End Function

    Public Sub GetGlobalBG(ByVal frm As Form)

        frm.BackgroundImage = Image.FromFile(Application.StartupPath & "\bg.jpg")

    End Sub

    Public Sub listvwColorChange(ByVal lstvw As ListView)
        Dim x As Integer
        'Dynamic back color of listview
        For x = 0 To lstvw.Items.Count - 1
            If x Mod 2 <> 0 Then
                lstvw.Items(x).BackColor = Color.AliceBlue
                'Me.lstvwTimedata.Items(x).ForeColor = Color.Blue
            End If
        Next
    End Sub

    Public Function getFilterField(ByVal cmbx As ComboBox) As String

        If cmbx.Text = "SR#" Then
            getFilterField = "ID"
        ElseIf cmbx.Text = "Priority" Then
            getFilterField = "Priority"
        ElseIf cmbx.Text = "Department" Then
            getFilterField = "Department_ID"
        ElseIf cmbx.Text = "Name" Then
            getFilterField = "Name"
        ElseIf cmbx.Text = "Address" Then
            getFilterField = "Address"
        ElseIf cmbx.Text = "Contact#" Then
            getFilterField = "ContactNo"
        ElseIf cmbx.Text = "Nature" Then
            getFilterField = "NatureOfComplaint"
        ElseIf cmbx.Text = "Received by" Then
            getFilterField = "ReceivedBy"
        ElseIf cmbx.Text = "Type" Then
            getFilterField = "Type"
        Else
            getFilterField = ""
        End If

        Return getFilterField

    End Function

    Public Function getEmployeePos(ByVal Name As String) As String

        Dim SQL As String
        SQL = "SELECT * FROM tblEmployee WHERE Employee_Name='" & Name & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            getEmployeePos = r("Position")
        Else
            getEmployeePos = ""
        End If
        r.Close()

        Return getEmployeePos

    End Function

    Public Sub printComplaintEntry(ByVal strSendTo As String,
        ByVal strServiceNo As String,
        ByVal strPriority As String,
        ByVal strNatureOfComplaint As String,
        ByVal strComplaintType As String,
        ByVal strName As String,
        ByVal strAddress As String,
        ByVal strContactNo As String,
        ByVal strEmail As String,
        ByVal strAccountNo As String,
        ByVal strAcountName As String,
        ByVal strMeterNo As String,
        ByVal strActionDesired As String,
        ByVal strComplaintReceived As String,
        ByVal strComplaintReceivedPos As String, ByVal strDatetime As DateTime, ByVal strFU As String, ByVal strFUDate As String)

        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        'Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        'Left Side************************************************
        Dim SendTo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ServiceNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Priority As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim NatureOfComplaint As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ComplaintType As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Name As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Address As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ContactNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Email As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AccountNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AcountName As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim MeterNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ActionDesired As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ReceiptDate As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ReceiptTime As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim ComplaintReceived As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ComplaintReceivedPos As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim FollowUp As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim FollowUpDate As CrystalDecisions.CrystalReports.Engine.TextObject
        '*******************************************************************
        'Right Side**************************************************
        Dim SendTo2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ServiceNo2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Priority2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim NatureOfComplaint2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ComplaintType2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Name2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Address2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ContactNo2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Email2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AccountNo2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AcountName2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim MeterNo2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ActionDesired2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ReceiptDate2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ReceiptTime2 As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim ComplaintReceived2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ComplaintReceivedPos2 As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim FollowUp2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim FollowUpDate2 As CrystalDecisions.CrystalReports.Engine.TextObject
        '****************************************************************
        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim repDoc

        repDoc = New crptComplaintEntry

        'Left Side*************************
        SendTo = repDoc.ReportDefinition.ReportObjects.Item("txtSendTo")
        ServiceNo = repDoc.ReportDefinition.ReportObjects.Item("txtServiceNo")
        Priority = repDoc.ReportDefinition.ReportObjects.Item("txtPriority")
        NatureOfComplaint = repDoc.ReportDefinition.ReportObjects.Item("txtNatureOfComplaint")
        ComplaintType = repDoc.ReportDefinition.ReportObjects.Item("txtComplaintType")
        Name = repDoc.ReportDefinition.ReportObjects.Item("txtName")
        Address = repDoc.ReportDefinition.ReportObjects.Item("txtAddress")
        ContactNo = repDoc.ReportDefinition.ReportObjects.Item("txtContactNo")
        Email = repDoc.ReportDefinition.ReportObjects.Item("txtEmail")
        AccountNo = repDoc.ReportDefinition.ReportObjects.Item("txtAccountNo")
        AcountName = repDoc.ReportDefinition.ReportObjects.Item("txtAccountName")
        MeterNo = repDoc.ReportDefinition.ReportObjects.Item("txtMeterNo")
        ActionDesired = repDoc.ReportDefinition.ReportObjects.Item("txtAction_Desired")
        ReceiptDate = repDoc.ReportDefinition.ReportObjects.Item("txtDate")
        ReceiptTime = repDoc.ReportDefinition.ReportObjects.Item("txtTime")

        ComplaintReceived = repDoc.ReportDefinition.ReportObjects.Item("txtReceivedby")
        ComplaintReceivedPos = repDoc.ReportDefinition.ReportObjects.Item("txtReceivedbyPos")

        FollowUp = repDoc.ReportDefinition.ReportObjects.Item("txtFU")
        FollowUpDate = repDoc.ReportDefinition.ReportObjects.Item("txtFUDate")
        '******************************

        'Right Side*************************
        SendTo2 = repDoc.ReportDefinition.ReportObjects.Item("txtSendTo2")
        ServiceNo2 = repDoc.ReportDefinition.ReportObjects.Item("txtServiceNo2")
        Priority2 = repDoc.ReportDefinition.ReportObjects.Item("txtPriority2")
        NatureOfComplaint2 = repDoc.ReportDefinition.ReportObjects.Item("txtNatureOfComplaint2")
        ComplaintType2 = repDoc.ReportDefinition.ReportObjects.Item("txtComplaintType2")
        Name2 = repDoc.ReportDefinition.ReportObjects.Item("txtName2")
        Address2 = repDoc.ReportDefinition.ReportObjects.Item("txtAddress2")
        ContactNo2 = repDoc.ReportDefinition.ReportObjects.Item("txtContactNo2")
        Email2 = repDoc.ReportDefinition.ReportObjects.Item("txtEmail2")
        AccountNo2 = repDoc.ReportDefinition.ReportObjects.Item("txtAccountNo2")
        AcountName2 = repDoc.ReportDefinition.ReportObjects.Item("txtAccountName2")
        MeterNo2 = repDoc.ReportDefinition.ReportObjects.Item("txtMeterNo2")
        ActionDesired2 = repDoc.ReportDefinition.ReportObjects.Item("txtAction_Desired2")
        ReceiptDate2 = repDoc.ReportDefinition.ReportObjects.Item("txtDate2")
        ReceiptTime2 = repDoc.ReportDefinition.ReportObjects.Item("txtTime2")

        ComplaintReceived2 = repDoc.ReportDefinition.ReportObjects.Item("txtReceivedby2")
        ComplaintReceivedPos2 = repDoc.ReportDefinition.ReportObjects.Item("txtReceivedbyPos2")

        FollowUp2 = repDoc.ReportDefinition.ReportObjects.Item("txtFU2")
        FollowUpDate2 = repDoc.ReportDefinition.ReportObjects.Item("txtFUDate2")
        '******************************

        'Left Side***************
        SendTo.Text = strSendTo
        ServiceNo.Text = strServiceNo
        Priority.Text = strPriority
        NatureOfComplaint.Text = strNatureOfComplaint
        ComplaintType.Text = strComplaintType
        Name.Text = strName
        Address.Text = strAddress
        ContactNo.Text = strContactNo
        Email.Text = strEmail
        AccountNo.Text = strAccountNo
        AcountName.Text = strAcountName
        MeterNo.Text = strMeterNo
        ActionDesired.Text = strActionDesired
        ReceiptDate.Text = strDatetime.ToString("MM/dd/yy")
        ReceiptTime.Text = strDatetime.ToString("hh:mm tt")

        ComplaintReceived.Text = strComplaintReceived
        'position of complaint receiver is to be decided!
        'strComplaintReceivedPos = "Consumers Welfare Desk Officer"
        ComplaintReceivedPos.Text = strComplaintReceivedPos
        FollowUp.Text = strFU
        FollowUpDate.Text = strFUDate
        '***********************

        'Right Side***************
        SendTo2.Text = strSendTo
        ServiceNo2.Text = strServiceNo
        Priority2.Text = strPriority
        NatureOfComplaint2.Text = strNatureOfComplaint
        ComplaintType2.Text = strComplaintType
        Name2.Text = strName
        Address2.Text = strAddress
        ContactNo2.Text = strContactNo
        Email2.Text = strEmail
        AccountNo2.Text = strAccountNo
        AcountName2.Text = strAcountName
        MeterNo2.Text = strMeterNo
        ActionDesired2.Text = strActionDesired
        ReceiptDate2.Text = strDatetime.ToString("MM/dd/yy")
        ReceiptTime2.Text = strDatetime.ToString("hh:mm tt")

        ComplaintReceived2.Text = strComplaintReceived
        'position of complaint receiver is to be decided!
        'strComplaintReceivedPos = "Consumers Welfare Desk Officer"
        ComplaintReceivedPos2.Text = strComplaintReceivedPos

        FollowUp2.Text = strFU
        FollowUpDate2.Text = strFUDate
        '***********************

        'For Each myTable In repDoc.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    myLogin.ConnectionInfo.ServerName = ServerName
        '    myLogin.ConnectionInfo.DatabaseName = DatabaseName
        '    myLogin.ConnectionInfo.UserID = UserID
        '    myLogin.ConnectionInfo.Password = Password
        '    myTable.ApplyLogOnInfo(myLogin)
        'Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
        Next
        frmvwComplaintEntry.crptvwComplaintEntry.ReportSource = repDoc
        frmvwComplaintEntry.crptvwComplaintEntry.SelectionFormula = "{tblComplaints1.ID}=" & CInt(strServiceNo) & ""
        frmvwComplaintEntry.ShowDialog()

    End Sub

    Public Sub printComplaintReceipt(ByVal strServiceNo As String,
        ByVal strName As String,
        ByVal strAddress As String,
        ByVal strDateReceipt As String,
        ByVal strNatureOfComplaint As String,
        ByVal strActionTaken As String,
        ByVal strDateActionTaken As String,
        ByVal strActionTakenBy As String)

        Dim ServiceNo As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Name As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Address As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateReceipt As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim NatureOfComplaint As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ActionTaken As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateActionTaken As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ActionTakenBy As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim repDoc

        repDoc = New crptComplaintReceipt

        ServiceNo = repDoc.ReportDefinition.ReportObjects.Item("txtServiceNo")
        Name = repDoc.ReportDefinition.ReportObjects.Item("txtName")
        Address = repDoc.ReportDefinition.ReportObjects.Item("txtAddress")
        DateReceipt = repDoc.ReportDefinition.ReportObjects.Item("txtDateReceipt")
        NatureOfComplaint = repDoc.ReportDefinition.ReportObjects.Item("txtNatureOfComplaint")
        ActionTaken = repDoc.ReportDefinition.ReportObjects.Item("txtActionTaken")
        DateActionTaken = repDoc.ReportDefinition.ReportObjects.Item("txtDateActionTaken")
        ActionTakenBy = repDoc.ReportDefinition.ReportObjects.Item("txtActionTaken")


        ServiceNo.Text = strServiceNo
        NatureOfComplaint.Text = strNatureOfComplaint
        Name.Text = strName
        Address.Text = strAddress

        ServiceNo.Text = strServiceNo
        Name.Text = strName
        Address.Text = strAddress
        DateReceipt.Text = strDateReceipt
        NatureOfComplaint.Text = strNatureOfComplaint
        ActionTaken.Text = strActionTaken
        DateActionTaken.Text = strDateActionTaken
        ActionTakenBy.Text = strActionTakenBy

        'For Each myTable In repDoc.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    myLogin.ConnectionInfo.ServerName = ServerName
        '    myLogin.ConnectionInfo.DatabaseName = DatabaseName
        '    myLogin.ConnectionInfo.UserID = UserID
        '    'myLogin.ConnectionInfo.Password = Password

        '    myTable.ApplyLogOnInfo(myLogin)
        'Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
        Next
        frmvwComplaintReceipt.crptvwComplaintReceipt.ReportSource = repDoc

        frmvwComplaintReceipt.ShowDialog()

    End Sub

    Public Function GetcrptDBPath() As String

        Dim oRead As System.IO.StreamReader

        oRead = IO.File.OpenText(Application.StartupPath & "\crptPath.txt")
        GetcrptDBPath = oRead.ReadToEnd()

        Return GetcrptDBPath

    End Function

End Module
