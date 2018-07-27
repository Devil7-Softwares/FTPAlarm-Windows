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

Imports System.Speech.Synthesis
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Public Class Speech : Inherits Component

#Region "Variables"

    Private p_objSynth As New SpeechSynthesizer

#End Region

#Region "Properties"

    Property Voice As String

    Property Volume As Integer
        Get
            Return p_objSynth.Volume
        End Get
        Set(ByVal value As Integer)
            p_objSynth.Volume = value
        End Set
    End Property

    Property Rate As Integer
        Get
            Return p_objSynth.Rate
        End Get
        Set(ByVal value As Integer)
            p_objSynth.Rate = value
        End Set
    End Property

    ReadOnly Property isSpeaking As Boolean
        Get
            If p_objSynth.State = SynthesizerState.Speaking Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

#End Region

#Region "Functions/Subs"

    Function GetVoices() As String()
        Dim l As New List(Of String)
        Dim objvoices As ReadOnlyCollection(Of InstalledVoice) = p_objSynth.GetInstalledVoices(Globalization.CultureInfo.InstalledUICulture)
        Dim objvoiceInformation As VoiceInfo = objvoices(0).VoiceInfo
        For Each tmpvoice As InstalledVoice In objvoices
            objvoiceInformation = tmpvoice.VoiceInfo
            l.Add(objvoiceInformation.Name.ToString)
        Next
        Return l.ToArray
    End Function

    Sub Start(ByVal Command As String)
        p_objSynth.SelectVoice(Voice)
        p_objSynth.SpeakAsync(Command)
    End Sub

    Sub StopAll()
        p_objSynth.SpeakAsyncCancelAll()
    End Sub

#End Region

End Class
