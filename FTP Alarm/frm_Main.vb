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

Public Class frm_Main

#Region "Subs"

    Sub LoadSettings()

        SettingsManager.LoadSettings()

        Me.txt_FTPServer.EditValue = SettingsManager.Settings.ServerAddress
        Me.txt_Port.EditValue = SettingsManager.Settings.Port
        Me.txt_Username.EditValue = SettingsManager.Settings.Username
        Me.txt_Password.EditValue = SettingsManager.Settings.Password

        Me.toggle_Email.IsOn = SettingsManager.Settings.EmailNotification
        Me.toggle_Ringtone.IsOn = SettingsManager.Settings.RingtoneNotification
        Me.toggle_Voice.IsOn = SettingsManager.Settings.VoiceNotification

        Me.txt_From.EditValue = SettingsManager.Settings.EmailFromAddress
        Me.txt_To.EditValue = SettingsManager.Settings.EmailToAddresses

        Me.cmb_Voice.EditValue = SettingsManager.Settings.Voice

        Me.txt_RingTone.EditValue = SettingsManager.Settings.Ringtone

        Me.txt_Hour.Value = SettingsManager.Settings.IntervalHour
        Me.txt_Minutes.Value = SettingsManager.Settings.IntervalMinutes
        Me.cb_IncludeFiles.Checked = SettingsManager.Settings.IncludeFiles

    End Sub

#End Region

#Region "Events - Settings"

    Private Sub txt_FTPServer_EditValueChanged(sender As Object, e As EventArgs) Handles txt_FTPServer.EditValueChanged
        SettingsManager.Settings.ServerAddress = txt_FTPServer.EditValue
    End Sub

    Private Sub txt_Port_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Port.EditValueChanged
        SettingsManager.Settings.Port = txt_Port.EditValue
    End Sub

    Private Sub txt_Username_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Username.EditValueChanged
        SettingsManager.Settings.Username = txt_Username.EditValue
    End Sub

    Private Sub txt_Password_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Password.EditValueChanged
        SettingsManager.Settings.Password = txt_Password.EditValue
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

    Private Sub cb_IncludeFiles_CheckedChanged(sender As Object, e As EventArgs) Handles cb_IncludeFiles.CheckedChanged
        SettingsManager.Settings.IncludeFiles = cb_IncludeFiles.Checked
    End Sub

#End Region

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SettingsManager.SaveSettings()
    End Sub

End Class
