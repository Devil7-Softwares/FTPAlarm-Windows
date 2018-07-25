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

    End Sub

#End Region

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub



End Class
