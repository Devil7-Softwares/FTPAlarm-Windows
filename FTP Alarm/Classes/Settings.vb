'==========================================================================
'
'                   (C) Copyright 2018 Devil7 Softwares.
' 
'      This file is part of 'Devil7 - College Management System' designed
' for Government Arts College (Autonomous), Coimbatore, Tamilnadu, India.
'
'      Licensed under the Apache License, Version 2.0 (the "License");
' you may Not use this file except in compliance with the License. You
' may obtain a copy of the License at
' 
'           http://www.apache.org/licenses/LICENSE-2.0
' 
'      Unless required by applicable law Or agreed to in writing, software
' distributed under the License Is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES Or CONDITIONS OF ANY KIND, either express Or implied.
' See the License for the specific language governing permissions And
' limitations under the License.
' 
' Contributors:
'     Dineshkumar T
'==========================================================================

Public Class Settings

    Property ServerAddress As String = "127.0.0.1"
    Property Port As Integer = 21
    Property Username As String = ""
    Property Password As String = ""
    Property IntervalHour As Integer = 0
    Property IntervalMinutes As Integer = 10
    Property RingtoneNotification As Boolean = True
    Property VoiceNotification As Boolean = True
    Property EmailNotification As Boolean = False
    Property EmailFromAddress As String = "someone"
    Property EmailToAddresses As String = "someone1@gmail.com;someone2@yahoo.com"
    Property Voice As String = ""
    Property Ringtone As String = "Default"
    Property IncludeFiles As Boolean = False
    Property MaxDepth As Integer = 2
    Property VoiceMessage As String = "Alert. A New file has been created. Alert. A New File has been created."
    Property VoiceMessageLoop As Integer = 0

End Class
