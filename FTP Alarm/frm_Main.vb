'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports Xceed.Ftp
Imports Devil7.Automation.FTPAlarm.libZPlay
Imports DevExpress.XtraEditors.Controls

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports System.IO
Imports System.Threading
Imports System.Net.Mail

Public Class frm_Main

    WithEvents FTP As FtpClient

    Dim OldList As List(Of String)
    Dim AudioPlayer As ZPlay
    Dim AlarmThread As Threading.Thread

    Dim Loaded As Boolean = False

    Dim FTPMessages As New List(Of String)

#Region "Logging"
    Private ReadOnly LogFile As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Logs", "Log_" & Now.ToString("ddMMyyyy_hhmmss") & ".txt")

    Enum LogType As Integer
        Info = 0
        Warn = 1
        Err = 2
        FTP = 3
    End Enum

    Public Sub Write2Console(ByVal Text As String, ByVal Color As Color)
        If InvokeRequired Then
            Invoke(Sub() Write2Console(Text, Color))
        Else
            txt_Console.SelectionColor = Color
            txt_Console.AppendText(Text)
            PostMessage(txt_Console.Handle, WM_VSCROLL, CType(SB_BOTTOM, IntPtr), CType(IntPtr.Zero, IntPtr))
        End If
    End Sub

    Sub Log(ByVal Type As LogType, ByVal Message As String)
        Dim LogFolder As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Logs")
        If Not My.Computer.FileSystem.DirectoryExists(LogFolder) Then My.Computer.FileSystem.CreateDirectory(LogFolder)
        Dim Type_ As String = "I"
        Dim Color As Color = Color.Green
        Select Case Type
            Case LogType.Info
                Type_ = "I"
                Color = Color.Green
            Case LogType.Warn
                Type_ = "W"
                Color = Color.Yellow
            Case LogType.Err
                Type_ = "E"
                Color = Color.Red
            Case LogType.FTP
                Type_ = "F"
                Color = Color.Blue
        End Select

        Dim S As String = String.Format("{2}{0}{3}{0}{4}{1}", vbTab, vbNewLine, Now.ToString("dd-MM-yyyy_hh:mm:ss"), Type_, Message)
        My.Computer.FileSystem.WriteAllText(LogFile, S, True)
        Write2Console(S, Color)
    End Sub

    Sub LogInfo(ByVal Message As String)
        Log(LogType.Info, Message)
    End Sub

    Sub LogWarn(ByVal Message As String)
        Log(LogType.Warn, Message)
    End Sub

    Sub LogError(ByVal Message As String)
        Log(LogType.Err, Message)
    End Sub

    Sub LogFTP(ByVal Message As String)
        Log(LogType.FTP, Message)
    End Sub

    Sub LogError(ByVal Tag As String, ByVal Exception As Exception)
        Log(LogType.Err, Tag & " : " & Exception.Message)
    End Sub
#End Region

#Region "Subs"

    Sub LoadSettings()
        Try
            LogInfo("Loading Settings...")
            SettingsManager.LoadSettings()

            Me.txt_FTPServer.EditValue = Encryption.Decrypt(SettingsManager.Settings.ServerAddress)
            Me.txt_Port.EditValue = SettingsManager.Settings.Port
            Me.txt_Username.EditValue = Encryption.Decrypt(SettingsManager.Settings.Username)
            Me.txt_Password.EditValue = Encryption.Decrypt(SettingsManager.Settings.Password)

            Me.toggle_Email.IsOn = SettingsManager.Settings.EmailNotification
            Me.toggle_Ringtone.IsOn = SettingsManager.Settings.RingtoneNotification
            Me.toggle_Voice.IsOn = SettingsManager.Settings.VoiceNotification

            Me.txt_From.EditValue = SettingsManager.Settings.EmailFromAddress
            Me.txt_To.EditValue = SettingsManager.Settings.EmailToAddresses
            Me.txt_EmailMessage.EditValue = SettingsManager.Settings.MailMessage

            If SettingsManager.Settings.Voice <> "" Then Me.cmb_Voice.EditValue = SettingsManager.Settings.Voice
            Me.txt_VoiceMessage.EditValue = SettingsManager.Settings.VoiceMessage
            Me.txt_Loop.Value = SettingsManager.Settings.VoiceMessageLoop

            Me.txt_RingTone.EditValue = SettingsManager.Settings.Ringtone

            Me.txt_Hour.Value = SettingsManager.Settings.IntervalHour
            Me.txt_Minutes.Value = SettingsManager.Settings.IntervalMinutes
            Me.txt_MaxDepth.Value = SettingsManager.Settings.MaxDepth
            Me.cb_IncludeFiles.Checked = SettingsManager.Settings.IncludeFiles

            If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(My.Application.Info.Title) Is Nothing Then
                Me.toggle_AutoStartApp.IsOn = False
            Else
                Me.toggle_AutoStartApp.IsOn = True
            End If
        Catch ex As Exception
            LogError("LoadSettings", ex)
        End Try
    End Sub

    Function GetList() As List(Of String)
        Try
            LogInfo("Fetching List...")
            If FTP.Connected Then FTP.Disconnect()
            FTP.Connect(Encryption.Decrypt(SettingsManager.Settings.ServerAddress), SettingsManager.Settings.Port)

            Dim Username As String = Encryption.Decrypt(SettingsManager.Settings.Username)
            Dim Password As String = Encryption.Decrypt(SettingsManager.Settings.Password)
            If Username <> "" AndAlso Password <> "" Then
                FTP.Login(Username, Password)
            Else
                FTP.Login()
            End If

            Dim Files As New List(Of String)

            List(FTP, "/", Files, 0, txt_MaxDepth.Value)

            FTP.Disconnect()

            Return Files
        Catch ex As Exception
            LogError("GetList", ex)
            Return Nothing
        End Try
    End Function

    Sub List(ByVal FTPClient As FtpClient, ByVal Folder As String, ByRef Files As List(Of String), ByVal Depth As Integer, ByVal MaxDepth As Integer)

        Depth += 1

        FTPClient.ChangeCurrentFolder(Folder)

        Dim List_ As FtpItemInfoList = FTPClient.GetFolderContents
        For Each i As FtpItemInfo In List_
            Select Case i.Type
                Case FtpItemType.File
                    If SettingsManager.Settings.IncludeFiles Then Files.Add(i.Name)
                Case FtpItemType.Folder
                    Files.Add(i.Name)
                    If Depth <> MaxDepth Then
                        List(FTPClient, Folder & "/" & i.Name, Files, Depth, MaxDepth)
                    End If
            End Select
        Next

    End Sub

    Sub DisableControls()
        txt_Hour.Enabled = False
        txt_Minutes.Enabled = False
        txt_MaxDepth.Enabled = False
        cb_IncludeFiles.Enabled = False
        btn_SetAlarm.Enabled = False
        tp_Settings.Enabled = False
        btn_StopAlarm.Enabled = True
    End Sub

    Sub EnableControls()
        txt_Hour.Enabled = True
        txt_Minutes.Enabled = True
        txt_MaxDepth.Enabled = True
        cb_IncludeFiles.Enabled = True
        btn_SetAlarm.Enabled = True
        tp_Settings.Enabled = True
        tp_About.Enabled = True
        btn_StopAlarm.Enabled = False
    End Sub

    Function ConnectionAvailable() As Boolean
        Return My.Computer.Network.Ping(Encryption.Decrypt(SettingsManager.Settings.ServerAddress))
    End Function

#End Region

#Region "Events - Settings"

    Private Sub txt_FTPServer_EditValueChanged(sender As Object, e As EventArgs) Handles txt_FTPServer.EditValueChanged
        SettingsManager.Settings.ServerAddress = Encryption.Encrypt(txt_FTPServer.EditValue)
    End Sub

    Private Sub txt_Port_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Port.EditValueChanged
        Try
            SettingsManager.Settings.Port = txt_Port.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Username_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Username.EditValueChanged
        SettingsManager.Settings.Username = Encryption.Encrypt(txt_Username.EditValue)
    End Sub

    Private Sub txt_Password_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Password.EditValueChanged
        SettingsManager.Settings.Password = Encryption.Encrypt(txt_Password.EditValue)
    End Sub

    Private Sub toggle_Ringtone_Toggled(sender As Object, e As EventArgs) Handles toggle_Ringtone.Toggled
        SettingsManager.Settings.RingtoneNotification = toggle_Ringtone.IsOn
    End Sub

    Private Sub toggle_Voice_Toggled(sender As Object, e As EventArgs) Handles toggle_Voice.Toggled
        SettingsManager.Settings.VoiceNotification = toggle_Voice.IsOn
    End Sub

    Private Sub toggle_Email_Toggled(sender As Object, e As EventArgs) Handles toggle_Email.Toggled
        SettingsManager.Settings.EmailNotification = toggle_Email.IsOn
    End Sub

    Private Sub txt_From_EditValueChanged(sender As Object, e As EventArgs) Handles txt_From.EditValueChanged
        SettingsManager.Settings.EmailFromAddress = txt_From.EditValue
    End Sub

    Private Sub txt_To_EditValueChanged(sender As Object, e As EventArgs) Handles txt_To.EditValueChanged
        SettingsManager.Settings.EmailToAddresses = txt_To.EditValue
    End Sub

    Private Sub cmb_Voice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Voice.SelectedIndexChanged
        SettingsManager.Settings.Voice = cmb_Voice.EditValue
        Speech_Manager.Voice = cmb_Voice.EditValue
    End Sub

    Private Sub txt_RingTone_EditValueChanged(sender As Object, e As EventArgs) Handles txt_RingTone.EditValueChanged
        SettingsManager.Settings.Ringtone = txt_RingTone.EditValue
    End Sub

    Private Sub txt_Hour_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Hour.EditValueChanged
        SettingsManager.Settings.IntervalHour = txt_Hour.Value
    End Sub

    Private Sub txt_Minutes_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Minutes.EditValueChanged
        SettingsManager.Settings.IntervalMinutes = txt_Minutes.Value
    End Sub

    Private Sub txt_MaxDepth_EditValueChanged(sender As Object, e As EventArgs) Handles txt_MaxDepth.EditValueChanged
        SettingsManager.Settings.MaxDepth = txt_MaxDepth.Value
    End Sub

    Private Sub txt_EmailMessage_EditValueChanged(sender As Object, e As EventArgs) Handles txt_EmailMessage.EditValueChanged
        SettingsManager.Settings.MailMessage = txt_EmailMessage.EditValue
    End Sub

    Private Sub txt_VoiceMessage_EditValueChanged(sender As Object, e As EventArgs) Handles txt_VoiceMessage.EditValueChanged
        SettingsManager.Settings.VoiceMessage = txt_VoiceMessage.EditValue
    End Sub

    Private Sub txt_Loop_ValueChanged(sender As Object, e As EventArgs) Handles txt_Loop.ValueChanged
        SettingsManager.Settings.VoiceMessageLoop = txt_Loop.Value
    End Sub

    Private Sub cb_IncludeFiles_CheckedChanged(sender As Object, e As EventArgs) Handles cb_IncludeFiles.CheckedChanged
        SettingsManager.Settings.IncludeFiles = cb_IncludeFiles.Checked
    End Sub

    Private Sub toggle_AutoSetAlarm_Toggled(sender As Object, e As EventArgs) Handles toggle_AutoSetAlarm.Toggled
        SettingsManager.Settings.AutoSetAlarm = toggle_AutoSetAlarm.IsOn
    End Sub

    Private Sub toggle_AutoStartApp_Toggled(sender As Object, e As EventArgs) Handles toggle_AutoStartApp.Toggled
        If Loaded Then
            If toggle_AutoStartApp.IsOn Then
                Try
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(My.Application.Info.Title, Application.ExecutablePath)
                Catch ex As Exception
                    toggle_AutoStartApp.IsOn = False
                End Try
            Else
                If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(My.Application.Info.Title) IsNot Nothing Then
                    Try
                        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(My.Application.Info.Title)
                    Catch ex As Exception
                        toggle_AutoStartApp.IsOn = True
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub txt_RingTone_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_RingTone.ButtonClick
        If OpenAudio.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fi As New IO.FileInfo(OpenAudio.FileName)
            lbl_Ringtone.Text = fi.Name
            My.Computer.FileSystem.CopyFile(OpenAudio.FileName, IO.Path.Combine(Application.StartupPath, IO.Path.GetFileName(OpenAudio.FileName)))
        End If
    End Sub

    Private Sub btn_TestEmail_Click(sender As Object, e As EventArgs) Handles btn_TestEmail.Click
        TestEmail()
    End Sub

    Private Sub btn_TestVoice_Click(sender As Object, e As EventArgs) Handles btn_TestVoice.Click
        Speech_Manager.Start("This is the testing sentence for test voice synthesise. And the test has completed")
    End Sub

    Private Sub btn_ResetRingtone_Click(sender As Object, e As EventArgs) Handles btn_ResetRingtone.Click
        txt_RingTone.Text = "Default"
    End Sub

    Private Sub btn_Play_Click(sender As Object, e As EventArgs) Handles btn_Play.Click
        Dim AudioFile As String = IO.Path.Combine(Application.StartupPath, txt_RingTone.Text)
        If My.Computer.FileSystem.FileExists(AudioFile) Then
            My.Computer.Audio.Play(AudioFile, AudioPlayMode.WaitToComplete)
        Else
            My.Computer.Audio.Play(IO.Path.Combine(Application.StartupPath, "Ringtone.wav"), AudioPlayMode.WaitToComplete)
        End If
    End Sub

#End Region

#Region "Events - Alarm"

    Private Sub Timer_Tick_Tick(sender As Object, e As EventArgs) Handles Timer_Tick.Tick
        If txt_Elapsed.Value = (((txt_Hour.Value * 60) + txt_Minutes.Value) * 60) Then
            txt_LastChecked.Text = Now.ToString("dd/MM/yyyy hh:mm:ss tt")
            txt_Elapsed.Value = 0
            Worker_Alarm.RunWorkerAsync()
            Timer_Tick.Stop()
        Else
            txt_Elapsed.Value += 1
        End If
    End Sub

    Private Sub Worker_Alarm_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_Alarm.DoWork
        LogInfo("Checking FTP for Changes... Checking Connection...")
        If ConnectionAvailable() Then
            LogInfo("Connection Available... Checking FTP...")
            Dim NewList As List(Of String) = GetList()

            If NewList IsNot Nothing Then
                Me.Invoke(Sub()
                              txt_CurrentCount.Text = NewList.Count
                              txt_PreviousCount.Text = OldList.Count
                          End Sub)
                Dim C1 As IEnumerable(Of String) = NewList.Except(OldList)
                Dim C2 As IEnumerable(Of String) = OldList.Except(NewList)
                If C1.Count > 0 Or C2.Count > 0 Then
                    LogWarn("Changed Detected... Triggering Events...")
                    AudioPlayer = New ZPlay
                    AlarmThread = New Threading.Thread(AddressOf TriggerAlarm)
                    AlarmThread.Start()
                Else
                    LogWarn("No Changes...")
                    OldList = NewList
                    Invoke(Sub() Timer_Tick.Start())
                End If
            End If
        Else
            LogWarn("No Connection Available. Aborting...")
            Timer_Tick.Start()
        End If

    End Sub

    Sub TriggerAlarm()
        Try
            LogInfo("Triggering Alarm...")
            Me.Invoke(Sub()
                          Me.Show()
                          Me.BringToFront()
                          Me.Focus()
                      End Sub)

            ' Email Notification
            If SettingsManager.Settings.EmailNotification Then
                Dim th1 As New Threading.Thread(AddressOf EmailNotification)
                th1.Start()
            End If

            ' Voice Notification
            If SettingsManager.Settings.VoiceNotification Then
                Dim S As String = ""
                For i As Integer = 1 To SettingsManager.Settings.VoiceMessageLoop
                    S &= SettingsManager.Settings.VoiceMessage & " "
                Next
                Speech_Manager.Start(S.Trim)
                Threading.Thread.Sleep(2000)
                Do Until Speech_Manager.isSpeaking = False
                    Threading.Thread.Sleep(1000)
                Loop
            End If

            ' Ringtone Notification
            If SettingsManager.Settings.RingtoneNotification AndAlso AudioPlayer IsNot Nothing Then
                Dim AudioFile As String = IO.Path.Combine(Application.StartupPath, txt_RingTone.Text)
                If My.Computer.FileSystem.FileExists(AudioFile) Then
                    AudioPlayer.OpenFile(AudioFile, TStreamFormat.sfAutodetect)
                Else
                    AudioPlayer.OpenFile(IO.Path.Combine(Application.StartupPath, "Ringtone.wav"), TStreamFormat.sfAutodetect)
                End If
                Do Until 1 = 0
                    Dim t As New TStreamStatus
                    AudioPlayer.GetStatus(t)
                    If t.fPlay = False Then
                        AudioPlayer.StartPlayback()
                    End If
                Loop
            End If
        Catch ex As Exception
            LogError("TriggerAlarm", ex)
        End Try
    End Sub

    Private Sub btn_SetAlarm_Click(sender As Object, e As EventArgs) Handles btn_SetAlarm.Click
        If ConnectionAvailable() Then
            Worker_SetAlarm.RunWorkerAsync()
        Else
            MsgBox("Unable to connect with given server/host.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_StopAlarm_Click(sender As Object, e As EventArgs) Handles btn_StopAlarm.Click
        LogInfo("Stopping Alarm...")
        If Worker_SetAlarm.IsBusy Then Worker_SetAlarm.CancelAsync()
        If Worker_Alarm.IsBusy Then Worker_SetAlarm.CancelAsync()
        If AudioPlayer IsNot Nothing Then AudioPlayer.StopPlayback()
        AudioPlayer = Nothing
        If AlarmThread IsNot Nothing Then AlarmThread.Abort()
        If Speech_Manager.isSpeaking Then
            Speech_Manager.StopAll()
        End If
        txt_Elapsed.Value = 0
        txt_LastChecked.Text = "-"
        Timer_Tick.Stop()
        WaitDialog.Close()
        EnableControls()
    End Sub

    Private Sub Worker_SetAlarm_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_SetAlarm.DoWork
        LogInfo("Setting Alarm...")
        Me.Invoke(Sub()
                      WaitDialog.Show(Me)
                      DisableControls()
                      btn_StopAlarm.Enabled = False
                      tp_About.Enabled = False
                  End Sub)
        OldList = GetList()
        If OldList IsNot Nothing Then
            LogInfo("Files Found. Alarm will be set.")
            Me.Invoke(Sub()
                          Timer_Tick.Start()
                          btn_StopAlarm.Enabled = True
                          tp_About.Enabled = True
                          txt_CurrentCount.Text = OldList.Count
                          txt_PreviousCount.Text = OldList.Count
                      End Sub)
        Else
            LogError("Unable to fetch initial list. Alarm will not be set!")
            Me.Invoke(Sub()
                          EnableControls()
                      End Sub)
        End If
        Me.Invoke(Sub()
                      WaitDialog.Close()
                  End Sub)
    End Sub

#End Region

#Region "Email"

    Sub EmailNotification()

        SendMail(SettingsManager.Settings.EmailFromAddress & "@gmail.com", "Devil7 - FTP Alarm", SettingsManager.Settings.EmailToAddresses, "FTP Email Alert", SettingsManager.Settings.MailMessage)

    End Sub

    Sub TestEmail()

        If SendMail(SettingsManager.Settings.EmailFromAddress & "@gmail.com", "Devil7 - FTP Alarm", SettingsManager.Settings.EmailToAddresses, "Email Alert - Test", "This is the email send from Devil7 - FTP Alarm for testing.") = True Then
            MsgBox("Test mail successfully send. :-)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done...!")
        Else
            MsgBox("Test mail failed to sent. :-\", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error...!")
        End If

    End Sub

    Sub GetToAddresses(ByVal EmailIds As String, ByRef mail As AE.Net.Mail.MailMessage)

        If EmailIds.Contains(";") Then
            Dim r As String = ""
            Dim s As String() = Split(EmailIds, ";")
            For Each i As String In s
                mail.To.Add(New MailAddress(i))
            Next
        Else
            mail.To.Add(New MailAddress(EmailIds))
        End If

    End Sub

    Public Function SendMail(ByVal FromMail As String, ByVal FromName As String, ByVal ToAddressess As String, ByVal Subject As String, ByVal Body As String)

        Try
            Dim msg = New AE.Net.Mail.MailMessage() With {.Subject = Subject, .Body = Body, .From = New MailAddress(FromMail, FromName)}
            GetToAddresses(ToAddressess, msg)
            msg.ReplyTo.Add(msg.From)
            Dim msgStr = New StringWriter()
            msg.Save(msgStr)
            Dim credential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = LicenseKeys.GetGmailCredentials.ClientID, .ClientSecret = LicenseKeys.GetGmailCredentials.ClientSecret}, {GmailService.Scope.MailGoogleCom}, FromMail, CancellationToken.None).Result
            Dim service As New GmailService(New BaseClientService.Initializer() With {.HttpClientInitializer = credential, .ApplicationName = "Devil7 - FTP Alarm"})
            Dim result As Message = service.Users.Messages.Send(New Message() With {.Raw = Base64UrlEncode(msgStr.ToString())}, "me").Execute()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function Base64UrlEncode(input As String) As String
        Dim inputBytes = System.Text.Encoding.UTF8.GetBytes(input)
        Return Convert.ToBase64String(inputBytes).Replace("+"c, "-"c).Replace("/"c, "_"c).Replace("=", "")
    End Function

#End Region

#Region "FTP Events"

    Private Sub FTP_CommandSent(sender As Object, e As CommandSentEventArgs) Handles FTP.CommandSent
        FTPMessages.Add("Command Sent - """ & e.Command & """")
    End Sub

    Private Sub FTP_ReplyReceived(sender As Object, e As ReplyReceivedEventArgs) Handles FTP.ReplyReceived
        For i As Integer = 0 To e.Reply.Lines.Count - 1
            FTPMessages.Add(String.Format("Reply from FTP : {0} - Line {1} - ""{2}""", e.Reply.ReplyCode, i + 1, e.Reply.Lines(i)))
        Next
    End Sub

    Private Sub Timer_MessageListener_Tick(sender As Object, e As EventArgs) Handles Timer_MessageListener.Tick
        If FTPMessages.Count > 0 Then
            LogFTP(FTPMessages(0))
            FTPMessages.RemoveAt(0)
        End If
    End Sub

#End Region

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Licenser.LicenseKey = LicenseKeys.GetXceedFTPKey ' Well I Wish I Could Push the Key to Git. But I Can't... So Specify Your Own Key Here :p
        FTP = New FtpClient
        Dim Voices As String() = Speech_Manager.GetVoices
        If Voices.Count > 0 Then
            cmb_Voice.Properties.Items.AddRange(Voices)
            cmb_Voice.SelectedItem = Voices(0)
        End If
        LoadSettings()
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SettingsManager.SaveSettings()
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Loaded = True
        If SettingsManager.Settings.AutoSetAlarm Then
            btn_SetAlarm.PerformClick()
        End If
    End Sub

    Private Sub lbl_LogFolder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_LogFolder.LinkClicked
        Dim LogFolder As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Logs")
        If My.Computer.FileSystem.DirectoryExists(LogFolder) Then
            Process.Start(LogFolder)
        Else
            MsgBox("Logs Folder Doesn't Exist for Current User.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_Feedback_Click(sender As Object, e As EventArgs) Handles btn_Feedback.Click
        Dim d As New frm_Feedback
        d.ShowDialog()
        Me.BringToFront()
        Me.Focus()
    End Sub
End Class
