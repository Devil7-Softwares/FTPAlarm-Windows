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

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            e.BringToForeground = True
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim LogFolder As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Logs")
            If Not My.Computer.FileSystem.DirectoryExists(LogFolder) Then My.Computer.FileSystem.CreateDirectory(LogFolder)
            Dim CrashLog As String = IO.Path.Combine(LogFolder, String.Format("CrashLog_{0}.txt", Now.ToString("ddMMyyyy_hhmmss")))
            Try
                Dim Message As String = String.Format("Exception Message : {1}{0}Exception Stack Trace : {2}{0}Exception Source : {3}{0}", vbNewLine, e.Exception.Message, e.Exception.StackTrace, e.Exception.Source)
                My.Computer.FileSystem.WriteAllText(CrashLog, Message, True)
                MsgBox("Unhandled Exception Occured... Please Check Logs for Details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            Catch ex As Exception

            End Try
        End Sub

    End Class
End Namespace
