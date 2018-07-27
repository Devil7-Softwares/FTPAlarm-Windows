﻿'=========================================================================='
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

Imports System.Xml.Serialization

Module SettingsManager

    Dim ConfigFile As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Devil7", "FTP Alarm", "Settings.config")

    Property Settings As New Settings

    Sub LoadSettings()

        Try
            Dim S As New XmlSerializer(GetType(Settings))

            If My.Computer.FileSystem.FileExists(ConfigFile) Then
                Using FS As New IO.FileStream(ConfigFile, IO.FileMode.Open)
                    Dim tmp = S.Deserialize(FS)
                    If tmp IsNot Nothing Then
                        Settings = tmp
                    End If
                End Using
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub SaveSettings()

        Try
            Dim S As New XmlSerializer(GetType(Settings))

            Dim FI As New IO.FileInfo(ConfigFile)

            If Not My.Computer.FileSystem.DirectoryExists(FI.Directory.FullName) Then
                FI.Directory.Create()
            End If

            Using FS As New IO.FileStream(ConfigFile, IO.FileMode.Create)
                S.Serialize(FS, Settings)
            End Using
        Catch ex As Exception

        End Try

    End Sub

End Module