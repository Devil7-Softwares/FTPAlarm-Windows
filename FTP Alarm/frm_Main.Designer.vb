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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.MainPane = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tp_Alarm = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grp_FTPConsole = New DevExpress.XtraEditors.GroupControl()
        Me.txt_Console = New System.Windows.Forms.RichTextBox()
        Me.cb_IncludeFiles = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_MaxDepth = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_MaxDepth = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Minutes = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Minutes = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Hour = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Hour = New DevExpress.XtraEditors.LabelControl()
        Me.btn_StopAlarm = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_SetAlarm = New DevExpress.XtraEditors.SimpleButton()
        Me.grp_Status = New DevExpress.XtraEditors.GroupControl()
        Me.txt_Elapsed = New Devil7.Automation.FTPAlarm.TimeLabel()
        Me.txt_CurrentCount = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PreviousCount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_CurrentCount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_PreviousCount = New DevExpress.XtraEditors.LabelControl()
        Me.txt_LastChecked = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_LastChecked = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AlarmInterval = New DevExpress.XtraEditors.LabelControl()
        Me.tp_Settings = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grp_Ringtone = New DevExpress.XtraEditors.GroupControl()
        Me.btn_ResetRingtone = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Play = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_RingTone = New DevExpress.XtraEditors.ButtonEdit()
        Me.lbl_Ringtone = New DevExpress.XtraEditors.LabelControl()
        Me.grp_Voice = New DevExpress.XtraEditors.GroupControl()
        Me.btn_TestVoice = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Voice = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Voice = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grp_Email = New DevExpress.XtraEditors.GroupControl()
        Me.txt_To = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_To = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Gmail = New DevExpress.XtraEditors.LabelControl()
        Me.btn_TestEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_From = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_From = New DevExpress.XtraEditors.LabelControl()
        Me.grp_Notifications = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_Voice1 = New DevExpress.XtraEditors.LabelControl()
        Me.toggle_Voice = New DevExpress.XtraEditors.ToggleSwitch()
        Me.toggle_Email = New DevExpress.XtraEditors.ToggleSwitch()
        Me.toggle_Ringtone = New DevExpress.XtraEditors.ToggleSwitch()
        Me.lbl_Ringtone1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Email = New DevExpress.XtraEditors.LabelControl()
        Me.grp_Credentials = New DevExpress.XtraEditors.GroupControl()
        Me.table_FTPMain = New System.Windows.Forms.TableLayoutPanel()
        Me.table_FTPSub_2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Colon3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Colon4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Username = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.table_FTPSub_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_FTPServer = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Port = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Colon1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Colon2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_FTPServer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Port = New DevExpress.XtraEditors.TextEdit()
        Me.tp_About = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.About = New Devil7.Automation.FTPAlarm.About()
        Me.Timer_Tick = New System.Windows.Forms.Timer(Me.components)
        Me.Worker_Alarm = New System.ComponentModel.BackgroundWorker()
        CType(Me.MainPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPane.SuspendLayout()
        Me.tp_Alarm.SuspendLayout()
        CType(Me.grp_FTPConsole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_FTPConsole.SuspendLayout()
        CType(Me.cb_IncludeFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaxDepth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Minutes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Hour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Status.SuspendLayout()
        Me.tp_Settings.SuspendLayout()
        CType(Me.grp_Ringtone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Ringtone.SuspendLayout()
        CType(Me.txt_RingTone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Voice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Voice.SuspendLayout()
        CType(Me.cmb_Voice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Email, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Email.SuspendLayout()
        CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Notifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Notifications.SuspendLayout()
        CType(Me.toggle_Voice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_Ringtone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Credentials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Credentials.SuspendLayout()
        Me.table_FTPMain.SuspendLayout()
        Me.table_FTPSub_2.SuspendLayout()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_FTPSub_1.SuspendLayout()
        CType(Me.txt_FTPServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Port.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_About.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPane
        '
        Me.MainPane.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
        Me.MainPane.Controls.Add(Me.tp_Alarm)
        Me.MainPane.Controls.Add(Me.tp_Settings)
        Me.MainPane.Controls.Add(Me.tp_About)
        Me.MainPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPane.Location = New System.Drawing.Point(0, 0)
        Me.MainPane.Name = "MainPane"
        Me.MainPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tp_Alarm, Me.tp_Settings, Me.tp_About})
        Me.MainPane.RegularSize = New System.Drawing.Size(451, 322)
        Me.MainPane.SelectedPage = Me.tp_Alarm
        Me.MainPane.Size = New System.Drawing.Size(451, 322)
        Me.MainPane.TabIndex = 1
        '
        'tp_Alarm
        '
        Me.tp_Alarm.Caption = "Alarm"
        Me.tp_Alarm.Controls.Add(Me.grp_FTPConsole)
        Me.tp_Alarm.Controls.Add(Me.cb_IncludeFiles)
        Me.tp_Alarm.Controls.Add(Me.txt_MaxDepth)
        Me.tp_Alarm.Controls.Add(Me.lbl_MaxDepth)
        Me.tp_Alarm.Controls.Add(Me.txt_Minutes)
        Me.tp_Alarm.Controls.Add(Me.lbl_Minutes)
        Me.tp_Alarm.Controls.Add(Me.txt_Hour)
        Me.tp_Alarm.Controls.Add(Me.lbl_Hour)
        Me.tp_Alarm.Controls.Add(Me.btn_StopAlarm)
        Me.tp_Alarm.Controls.Add(Me.btn_SetAlarm)
        Me.tp_Alarm.Controls.Add(Me.grp_Status)
        Me.tp_Alarm.Controls.Add(Me.lbl_AlarmInterval)
        Me.tp_Alarm.Name = "tp_Alarm"
        Me.tp_Alarm.Size = New System.Drawing.Size(451, 295)
        '
        'grp_FTPConsole
        '
        Me.grp_FTPConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_FTPConsole.Controls.Add(Me.txt_Console)
        Me.grp_FTPConsole.Location = New System.Drawing.Point(12, 164)
        Me.grp_FTPConsole.Name = "grp_FTPConsole"
        Me.grp_FTPConsole.Size = New System.Drawing.Size(429, 120)
        Me.grp_FTPConsole.TabIndex = 10
        Me.grp_FTPConsole.Text = "Console"
        '
        'txt_Console
        '
        Me.txt_Console.BackColor = System.Drawing.Color.Black
        Me.txt_Console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Console.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Console.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Console.Location = New System.Drawing.Point(2, 20)
        Me.txt_Console.Name = "txt_Console"
        Me.txt_Console.ReadOnly = True
        Me.txt_Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txt_Console.Size = New System.Drawing.Size(425, 98)
        Me.txt_Console.TabIndex = 0
        Me.txt_Console.Text = ""
        '
        'cb_IncludeFiles
        '
        Me.cb_IncludeFiles.Location = New System.Drawing.Point(160, 44)
        Me.cb_IncludeFiles.Name = "cb_IncludeFiles"
        Me.cb_IncludeFiles.Properties.Caption = "Include Files"
        Me.cb_IncludeFiles.Size = New System.Drawing.Size(95, 19)
        Me.cb_IncludeFiles.TabIndex = 9
        '
        'txt_MaxDepth
        '
        Me.txt_MaxDepth.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MaxDepth.Location = New System.Drawing.Point(93, 43)
        Me.txt_MaxDepth.Name = "txt_MaxDepth"
        Me.txt_MaxDepth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_MaxDepth.Properties.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MaxDepth.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MaxDepth.Size = New System.Drawing.Size(61, 20)
        Me.txt_MaxDepth.TabIndex = 8
        '
        'lbl_MaxDepth
        '
        Me.lbl_MaxDepth.Location = New System.Drawing.Point(28, 46)
        Me.lbl_MaxDepth.Name = "lbl_MaxDepth"
        Me.lbl_MaxDepth.Size = New System.Drawing.Size(59, 13)
        Me.lbl_MaxDepth.TabIndex = 7
        Me.lbl_MaxDepth.Text = "Max Depth :"
        '
        'txt_Minutes
        '
        Me.txt_Minutes.EditValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txt_Minutes.Location = New System.Drawing.Point(189, 17)
        Me.txt_Minutes.Name = "txt_Minutes"
        Me.txt_Minutes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Minutes.Properties.MaxValue = New Decimal(New Integer() {59, 0, 0, 0})
        Me.txt_Minutes.Size = New System.Drawing.Size(52, 20)
        Me.txt_Minutes.TabIndex = 6
        '
        'lbl_Minutes
        '
        Me.lbl_Minutes.Location = New System.Drawing.Point(247, 20)
        Me.lbl_Minutes.Name = "lbl_Minutes"
        Me.lbl_Minutes.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Minutes.TabIndex = 5
        Me.lbl_Minutes.Text = "Minutes"
        '
        'txt_Hour
        '
        Me.txt_Hour.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Hour.Location = New System.Drawing.Point(93, 17)
        Me.txt_Hour.Name = "txt_Hour"
        Me.txt_Hour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Hour.Size = New System.Drawing.Size(61, 20)
        Me.txt_Hour.TabIndex = 6
        '
        'lbl_Hour
        '
        Me.lbl_Hour.Location = New System.Drawing.Point(160, 20)
        Me.lbl_Hour.Name = "lbl_Hour"
        Me.lbl_Hour.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Hour.TabIndex = 5
        Me.lbl_Hour.Text = "Hour"
        '
        'btn_StopAlarm
        '
        Me.btn_StopAlarm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_StopAlarm.Enabled = False
        Me.btn_StopAlarm.ImageOptions.Image = Global.Devil7.Automation.FTPAlarm.My.Resources.Resources.abort
        Me.btn_StopAlarm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_StopAlarm.Location = New System.Drawing.Point(373, 17)
        Me.btn_StopAlarm.Name = "btn_StopAlarm"
        Me.btn_StopAlarm.Size = New System.Drawing.Size(68, 63)
        Me.btn_StopAlarm.TabIndex = 3
        Me.btn_StopAlarm.Text = "Stop Alarm"
        '
        'btn_SetAlarm
        '
        Me.btn_SetAlarm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SetAlarm.ImageOptions.Image = Global.Devil7.Automation.FTPAlarm.My.Resources.Resources.alarm
        Me.btn_SetAlarm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_SetAlarm.Location = New System.Drawing.Point(299, 17)
        Me.btn_SetAlarm.Name = "btn_SetAlarm"
        Me.btn_SetAlarm.Size = New System.Drawing.Size(68, 63)
        Me.btn_SetAlarm.TabIndex = 3
        Me.btn_SetAlarm.Text = "Set Alarm"
        '
        'grp_Status
        '
        Me.grp_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Status.Controls.Add(Me.txt_Elapsed)
        Me.grp_Status.Controls.Add(Me.txt_CurrentCount)
        Me.grp_Status.Controls.Add(Me.txt_PreviousCount)
        Me.grp_Status.Controls.Add(Me.lbl_CurrentCount)
        Me.grp_Status.Controls.Add(Me.lbl_PreviousCount)
        Me.grp_Status.Controls.Add(Me.txt_LastChecked)
        Me.grp_Status.Controls.Add(Me.lbl_LastChecked)
        Me.grp_Status.Location = New System.Drawing.Point(12, 86)
        Me.grp_Status.Name = "grp_Status"
        Me.grp_Status.Size = New System.Drawing.Size(429, 72)
        Me.grp_Status.TabIndex = 2
        Me.grp_Status.Text = "Status"
        '
        'txt_Elapsed
        '
        Me.txt_Elapsed.AutoSize = True
        Me.txt_Elapsed.Caption = "Interval (Elapsed)"
        Me.txt_Elapsed.Location = New System.Drawing.Point(12, 27)
        Me.txt_Elapsed.Name = "txt_Elapsed"
        Me.txt_Elapsed.Size = New System.Drawing.Size(147, 13)
        Me.txt_Elapsed.TabIndex = 8
        Me.txt_Elapsed.Text = "Interval (Elapsed) : 00:00:00"
        Me.txt_Elapsed.Value = CType(0, Long)
        '
        'txt_CurrentCount
        '
        Me.txt_CurrentCount.Location = New System.Drawing.Point(340, 48)
        Me.txt_CurrentCount.Name = "txt_CurrentCount"
        Me.txt_CurrentCount.Size = New System.Drawing.Size(6, 13)
        Me.txt_CurrentCount.TabIndex = 6
        Me.txt_CurrentCount.Text = "0"
        '
        'txt_PreviousCount
        '
        Me.txt_PreviousCount.Location = New System.Drawing.Point(340, 27)
        Me.txt_PreviousCount.Name = "txt_PreviousCount"
        Me.txt_PreviousCount.Size = New System.Drawing.Size(6, 13)
        Me.txt_PreviousCount.TabIndex = 6
        Me.txt_PreviousCount.Text = "0"
        '
        'lbl_CurrentCount
        '
        Me.lbl_CurrentCount.Location = New System.Drawing.Point(258, 48)
        Me.lbl_CurrentCount.Name = "lbl_CurrentCount"
        Me.lbl_CurrentCount.Size = New System.Drawing.Size(76, 13)
        Me.lbl_CurrentCount.TabIndex = 5
        Me.lbl_CurrentCount.Text = "Current Count :"
        '
        'lbl_PreviousCount
        '
        Me.lbl_PreviousCount.Location = New System.Drawing.Point(254, 27)
        Me.lbl_PreviousCount.Name = "lbl_PreviousCount"
        Me.lbl_PreviousCount.Size = New System.Drawing.Size(80, 13)
        Me.lbl_PreviousCount.TabIndex = 5
        Me.lbl_PreviousCount.Text = "Previous Count :"
        '
        'txt_LastChecked
        '
        Me.txt_LastChecked.Location = New System.Drawing.Point(114, 48)
        Me.txt_LastChecked.Name = "txt_LastChecked"
        Me.txt_LastChecked.Size = New System.Drawing.Size(4, 13)
        Me.txt_LastChecked.TabIndex = 3
        Me.txt_LastChecked.Text = "-"
        '
        'lbl_LastChecked
        '
        Me.lbl_LastChecked.Location = New System.Drawing.Point(37, 48)
        Me.lbl_LastChecked.Name = "lbl_LastChecked"
        Me.lbl_LastChecked.Size = New System.Drawing.Size(71, 13)
        Me.lbl_LastChecked.TabIndex = 2
        Me.lbl_LastChecked.Text = "Last Checked :"
        '
        'lbl_AlarmInterval
        '
        Me.lbl_AlarmInterval.Location = New System.Drawing.Point(12, 20)
        Me.lbl_AlarmInterval.Name = "lbl_AlarmInterval"
        Me.lbl_AlarmInterval.Size = New System.Drawing.Size(75, 13)
        Me.lbl_AlarmInterval.TabIndex = 0
        Me.lbl_AlarmInterval.Text = "Alarm Interval :"
        '
        'tp_Settings
        '
        Me.tp_Settings.AutoScroll = True
        Me.tp_Settings.Caption = "Settings"
        Me.tp_Settings.Controls.Add(Me.grp_Ringtone)
        Me.tp_Settings.Controls.Add(Me.grp_Voice)
        Me.tp_Settings.Controls.Add(Me.grp_Email)
        Me.tp_Settings.Controls.Add(Me.grp_Notifications)
        Me.tp_Settings.Controls.Add(Me.grp_Credentials)
        Me.tp_Settings.Name = "tp_Settings"
        Me.tp_Settings.Size = New System.Drawing.Size(451, 295)
        '
        'grp_Ringtone
        '
        Me.grp_Ringtone.Controls.Add(Me.btn_ResetRingtone)
        Me.grp_Ringtone.Controls.Add(Me.btn_Play)
        Me.grp_Ringtone.Controls.Add(Me.txt_RingTone)
        Me.grp_Ringtone.Controls.Add(Me.lbl_Ringtone)
        Me.grp_Ringtone.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Ringtone.Location = New System.Drawing.Point(0, 293)
        Me.grp_Ringtone.Name = "grp_Ringtone"
        Me.grp_Ringtone.Size = New System.Drawing.Size(434, 75)
        Me.grp_Ringtone.TabIndex = 3
        Me.grp_Ringtone.Text = "Ringtone"
        '
        'btn_ResetRingtone
        '
        Me.btn_ResetRingtone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ResetRingtone.Location = New System.Drawing.Point(257, 47)
        Me.btn_ResetRingtone.Name = "btn_ResetRingtone"
        Me.btn_ResetRingtone.Size = New System.Drawing.Size(94, 23)
        Me.btn_ResetRingtone.TabIndex = 3
        Me.btn_ResetRingtone.Text = "Reset to Default"
        '
        'btn_Play
        '
        Me.btn_Play.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Play.Location = New System.Drawing.Point(354, 47)
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.Size = New System.Drawing.Size(75, 23)
        Me.btn_Play.TabIndex = 2
        Me.btn_Play.Text = "Play"
        '
        'txt_RingTone
        '
        Me.txt_RingTone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RingTone.EditValue = "Default"
        Me.txt_RingTone.Location = New System.Drawing.Point(108, 23)
        Me.txt_RingTone.Name = "txt_RingTone"
        Me.txt_RingTone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_RingTone.Size = New System.Drawing.Size(321, 20)
        Me.txt_RingTone.TabIndex = 1
        '
        'lbl_Ringtone
        '
        Me.lbl_Ringtone.Location = New System.Drawing.Point(8, 26)
        Me.lbl_Ringtone.Name = "lbl_Ringtone"
        Me.lbl_Ringtone.Size = New System.Drawing.Size(94, 13)
        Me.lbl_Ringtone.TabIndex = 0
        Me.lbl_Ringtone.Text = "Selected Ringtone :"
        '
        'grp_Voice
        '
        Me.grp_Voice.Controls.Add(Me.btn_TestVoice)
        Me.grp_Voice.Controls.Add(Me.lbl_Voice)
        Me.grp_Voice.Controls.Add(Me.cmb_Voice)
        Me.grp_Voice.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Voice.Location = New System.Drawing.Point(0, 242)
        Me.grp_Voice.Name = "grp_Voice"
        Me.grp_Voice.Size = New System.Drawing.Size(434, 51)
        Me.grp_Voice.TabIndex = 2
        Me.grp_Voice.Text = "Voice Alert"
        '
        'btn_TestVoice
        '
        Me.btn_TestVoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_TestVoice.Location = New System.Drawing.Point(354, 23)
        Me.btn_TestVoice.Name = "btn_TestVoice"
        Me.btn_TestVoice.Size = New System.Drawing.Size(75, 23)
        Me.btn_TestVoice.TabIndex = 2
        Me.btn_TestVoice.Text = "Test"
        '
        'lbl_Voice
        '
        Me.lbl_Voice.Location = New System.Drawing.Point(8, 28)
        Me.lbl_Voice.Name = "lbl_Voice"
        Me.lbl_Voice.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Voice.TabIndex = 1
        Me.lbl_Voice.Text = "Voice :"
        '
        'cmb_Voice
        '
        Me.cmb_Voice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Voice.Location = New System.Drawing.Point(45, 25)
        Me.cmb_Voice.Name = "cmb_Voice"
        Me.cmb_Voice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Voice.Size = New System.Drawing.Size(303, 20)
        Me.cmb_Voice.TabIndex = 0
        '
        'grp_Email
        '
        Me.grp_Email.Controls.Add(Me.txt_To)
        Me.grp_Email.Controls.Add(Me.lbl_To)
        Me.grp_Email.Controls.Add(Me.lbl_Gmail)
        Me.grp_Email.Controls.Add(Me.btn_TestEmail)
        Me.grp_Email.Controls.Add(Me.txt_From)
        Me.grp_Email.Controls.Add(Me.lbl_From)
        Me.grp_Email.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Email.Location = New System.Drawing.Point(0, 164)
        Me.grp_Email.Name = "grp_Email"
        Me.grp_Email.Size = New System.Drawing.Size(434, 78)
        Me.grp_Email.TabIndex = 1
        Me.grp_Email.Text = "Email"
        '
        'txt_To
        '
        Me.txt_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_To.EditValue = "someone1@gmail.com;someone2@mail.com"
        Me.txt_To.Location = New System.Drawing.Point(45, 52)
        Me.txt_To.Name = "txt_To"
        Me.txt_To.Size = New System.Drawing.Size(303, 20)
        Me.txt_To.TabIndex = 5
        '
        'lbl_To
        '
        Me.lbl_To.Location = New System.Drawing.Point(20, 55)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(19, 13)
        Me.lbl_To.TabIndex = 4
        Me.lbl_To.Text = "To :"
        '
        'lbl_Gmail
        '
        Me.lbl_Gmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Gmail.Location = New System.Drawing.Point(291, 29)
        Me.lbl_Gmail.Name = "lbl_Gmail"
        Me.lbl_Gmail.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Gmail.TabIndex = 3
        Me.lbl_Gmail.Text = "@gmail.com"
        '
        'btn_TestEmail
        '
        Me.btn_TestEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_TestEmail.Location = New System.Drawing.Point(354, 24)
        Me.btn_TestEmail.Name = "btn_TestEmail"
        Me.btn_TestEmail.Size = New System.Drawing.Size(75, 48)
        Me.btn_TestEmail.TabIndex = 2
        Me.btn_TestEmail.Text = "Test / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Authendicate"
        '
        'txt_From
        '
        Me.txt_From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_From.EditValue = "someone"
        Me.txt_From.Location = New System.Drawing.Point(45, 26)
        Me.txt_From.Name = "txt_From"
        Me.txt_From.Size = New System.Drawing.Size(240, 20)
        Me.txt_From.TabIndex = 1
        '
        'lbl_From
        '
        Me.lbl_From.Location = New System.Drawing.Point(8, 29)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(31, 13)
        Me.lbl_From.TabIndex = 0
        Me.lbl_From.Text = "From :"
        '
        'grp_Notifications
        '
        Me.grp_Notifications.Controls.Add(Me.lbl_Voice1)
        Me.grp_Notifications.Controls.Add(Me.toggle_Voice)
        Me.grp_Notifications.Controls.Add(Me.toggle_Email)
        Me.grp_Notifications.Controls.Add(Me.toggle_Ringtone)
        Me.grp_Notifications.Controls.Add(Me.lbl_Ringtone1)
        Me.grp_Notifications.Controls.Add(Me.lbl_Email)
        Me.grp_Notifications.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Notifications.Location = New System.Drawing.Point(0, 77)
        Me.grp_Notifications.Name = "grp_Notifications"
        Me.grp_Notifications.Size = New System.Drawing.Size(434, 87)
        Me.grp_Notifications.TabIndex = 5
        Me.grp_Notifications.Text = "Notifications"
        '
        'lbl_Voice1
        '
        Me.lbl_Voice1.Location = New System.Drawing.Point(228, 28)
        Me.lbl_Voice1.Name = "lbl_Voice1"
        Me.lbl_Voice1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Voice1.TabIndex = 5
        Me.lbl_Voice1.Text = "Voice :"
        '
        'toggle_Voice
        '
        Me.toggle_Voice.Location = New System.Drawing.Point(266, 23)
        Me.toggle_Voice.Name = "toggle_Voice"
        Me.toggle_Voice.Properties.OffText = "Off"
        Me.toggle_Voice.Properties.OnText = "On"
        Me.toggle_Voice.Size = New System.Drawing.Size(95, 24)
        Me.toggle_Voice.TabIndex = 4
        '
        'toggle_Email
        '
        Me.toggle_Email.Location = New System.Drawing.Point(71, 53)
        Me.toggle_Email.Name = "toggle_Email"
        Me.toggle_Email.Properties.OffText = "Off"
        Me.toggle_Email.Properties.OnText = "On"
        Me.toggle_Email.Size = New System.Drawing.Size(95, 24)
        Me.toggle_Email.TabIndex = 3
        '
        'toggle_Ringtone
        '
        Me.toggle_Ringtone.Location = New System.Drawing.Point(71, 23)
        Me.toggle_Ringtone.Name = "toggle_Ringtone"
        Me.toggle_Ringtone.Properties.OffText = "Off"
        Me.toggle_Ringtone.Properties.OnText = "On"
        Me.toggle_Ringtone.Size = New System.Drawing.Size(95, 24)
        Me.toggle_Ringtone.TabIndex = 2
        '
        'lbl_Ringtone1
        '
        Me.lbl_Ringtone1.Location = New System.Drawing.Point(15, 28)
        Me.lbl_Ringtone1.Name = "lbl_Ringtone1"
        Me.lbl_Ringtone1.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Ringtone1.TabIndex = 1
        Me.lbl_Ringtone1.Text = "Ringtone :"
        '
        'lbl_Email
        '
        Me.lbl_Email.Location = New System.Drawing.Point(34, 58)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Email.TabIndex = 0
        Me.lbl_Email.Text = "Email :"
        '
        'grp_Credentials
        '
        Me.grp_Credentials.Controls.Add(Me.table_FTPMain)
        Me.grp_Credentials.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Credentials.Location = New System.Drawing.Point(0, 0)
        Me.grp_Credentials.Name = "grp_Credentials"
        Me.grp_Credentials.Size = New System.Drawing.Size(434, 77)
        Me.grp_Credentials.TabIndex = 0
        Me.grp_Credentials.Text = "FTP Server"
        '
        'table_FTPMain
        '
        Me.table_FTPMain.ColumnCount = 2
        Me.table_FTPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPMain.Controls.Add(Me.table_FTPSub_2, 1, 0)
        Me.table_FTPMain.Controls.Add(Me.table_FTPSub_1, 0, 0)
        Me.table_FTPMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_FTPMain.Location = New System.Drawing.Point(2, 20)
        Me.table_FTPMain.Name = "table_FTPMain"
        Me.table_FTPMain.RowCount = 1
        Me.table_FTPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_FTPMain.Size = New System.Drawing.Size(430, 55)
        Me.table_FTPMain.TabIndex = 0
        '
        'table_FTPSub_2
        '
        Me.table_FTPSub_2.ColumnCount = 3
        Me.table_FTPSub_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.table_FTPSub_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.table_FTPSub_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_FTPSub_2.Controls.Add(Me.lbl_Username, 0, 0)
        Me.table_FTPSub_2.Controls.Add(Me.lbl_Password, 0, 1)
        Me.table_FTPSub_2.Controls.Add(Me.lbl_Colon3, 1, 0)
        Me.table_FTPSub_2.Controls.Add(Me.lbl_Colon4, 1, 1)
        Me.table_FTPSub_2.Controls.Add(Me.txt_Username, 2, 0)
        Me.table_FTPSub_2.Controls.Add(Me.txt_Password, 2, 1)
        Me.table_FTPSub_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_FTPSub_2.Location = New System.Drawing.Point(218, 3)
        Me.table_FTPSub_2.Name = "table_FTPSub_2"
        Me.table_FTPSub_2.RowCount = 2
        Me.table_FTPSub_2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPSub_2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPSub_2.Size = New System.Drawing.Size(209, 49)
        Me.table_FTPSub_2.TabIndex = 1
        '
        'lbl_Username
        '
        Me.lbl_Username.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username"
        '
        'lbl_Password
        '
        Me.lbl_Password.Location = New System.Drawing.Point(3, 27)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Password.TabIndex = 1
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Colon3
        '
        Me.lbl_Colon3.Location = New System.Drawing.Point(57, 3)
        Me.lbl_Colon3.Name = "lbl_Colon3"
        Me.lbl_Colon3.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Colon3.TabIndex = 2
        Me.lbl_Colon3.Text = ":"
        '
        'lbl_Colon4
        '
        Me.lbl_Colon4.Location = New System.Drawing.Point(57, 27)
        Me.lbl_Colon4.Name = "lbl_Colon4"
        Me.lbl_Colon4.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Colon4.TabIndex = 2
        Me.lbl_Colon4.Text = ":"
        '
        'txt_Username
        '
        Me.txt_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Username.Location = New System.Drawing.Point(65, 3)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(141, 20)
        Me.txt_Username.TabIndex = 3
        '
        'txt_Password
        '
        Me.txt_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Password.Location = New System.Drawing.Point(65, 27)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(141, 20)
        Me.txt_Password.TabIndex = 3
        '
        'table_FTPSub_1
        '
        Me.table_FTPSub_1.ColumnCount = 3
        Me.table_FTPSub_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.table_FTPSub_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.table_FTPSub_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_FTPSub_1.Controls.Add(Me.lbl_FTPServer, 0, 0)
        Me.table_FTPSub_1.Controls.Add(Me.lbl_Port, 0, 1)
        Me.table_FTPSub_1.Controls.Add(Me.lbl_Colon1, 1, 0)
        Me.table_FTPSub_1.Controls.Add(Me.lbl_Colon2, 1, 1)
        Me.table_FTPSub_1.Controls.Add(Me.txt_FTPServer, 2, 0)
        Me.table_FTPSub_1.Controls.Add(Me.txt_Port, 2, 1)
        Me.table_FTPSub_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_FTPSub_1.Location = New System.Drawing.Point(3, 3)
        Me.table_FTPSub_1.Name = "table_FTPSub_1"
        Me.table_FTPSub_1.RowCount = 2
        Me.table_FTPSub_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPSub_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_FTPSub_1.Size = New System.Drawing.Size(209, 49)
        Me.table_FTPSub_1.TabIndex = 0
        '
        'lbl_FTPServer
        '
        Me.lbl_FTPServer.Location = New System.Drawing.Point(3, 3)
        Me.lbl_FTPServer.Name = "lbl_FTPServer"
        Me.lbl_FTPServer.Size = New System.Drawing.Size(79, 13)
        Me.lbl_FTPServer.TabIndex = 0
        Me.lbl_FTPServer.Text = "FTP Server/Host"
        '
        'lbl_Port
        '
        Me.lbl_Port.Location = New System.Drawing.Point(3, 27)
        Me.lbl_Port.Name = "lbl_Port"
        Me.lbl_Port.Size = New System.Drawing.Size(20, 13)
        Me.lbl_Port.TabIndex = 1
        Me.lbl_Port.Text = "Port"
        '
        'lbl_Colon1
        '
        Me.lbl_Colon1.Location = New System.Drawing.Point(92, 3)
        Me.lbl_Colon1.Name = "lbl_Colon1"
        Me.lbl_Colon1.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Colon1.TabIndex = 2
        Me.lbl_Colon1.Text = ":"
        '
        'lbl_Colon2
        '
        Me.lbl_Colon2.Location = New System.Drawing.Point(92, 27)
        Me.lbl_Colon2.Name = "lbl_Colon2"
        Me.lbl_Colon2.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Colon2.TabIndex = 2
        Me.lbl_Colon2.Text = ":"
        '
        'txt_FTPServer
        '
        Me.txt_FTPServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_FTPServer.EditValue = "127.0.0.1"
        Me.txt_FTPServer.Location = New System.Drawing.Point(100, 3)
        Me.txt_FTPServer.Name = "txt_FTPServer"
        Me.txt_FTPServer.Size = New System.Drawing.Size(106, 20)
        Me.txt_FTPServer.TabIndex = 3
        '
        'txt_Port
        '
        Me.txt_Port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Port.EditValue = "21"
        Me.txt_Port.Location = New System.Drawing.Point(100, 27)
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(106, 20)
        Me.txt_Port.TabIndex = 4
        '
        'tp_About
        '
        Me.tp_About.AutoScroll = True
        Me.tp_About.Caption = "About"
        Me.tp_About.Controls.Add(Me.About)
        Me.tp_About.Name = "tp_About"
        Me.tp_About.Size = New System.Drawing.Size(451, 295)
        '
        'About
        '
        Me.About.Dock = System.Windows.Forms.DockStyle.Top
        Me.About.Location = New System.Drawing.Point(0, 0)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(451, 483)
        Me.About.TabIndex = 0
        '
        'Timer_Tick
        '
        Me.Timer_Tick.Interval = 1000
        '
        'Worker_Alarm
        '
        Me.Worker_Alarm.WorkerSupportsCancellation = True
        '
        'frm_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(451, 322)
        Me.Controls.Add(Me.MainPane)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.Text = "Devil7 - FTP Alarm"
        CType(Me.MainPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPane.ResumeLayout(False)
        Me.tp_Alarm.ResumeLayout(False)
        Me.tp_Alarm.PerformLayout()
        CType(Me.grp_FTPConsole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_FTPConsole.ResumeLayout(False)
        CType(Me.cb_IncludeFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaxDepth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Minutes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Hour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Status.ResumeLayout(False)
        Me.grp_Status.PerformLayout()
        Me.tp_Settings.ResumeLayout(False)
        CType(Me.grp_Ringtone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Ringtone.ResumeLayout(False)
        Me.grp_Ringtone.PerformLayout()
        CType(Me.txt_RingTone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Voice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Voice.ResumeLayout(False)
        Me.grp_Voice.PerformLayout()
        CType(Me.cmb_Voice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Email, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Email.ResumeLayout(False)
        Me.grp_Email.PerformLayout()
        CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Notifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Notifications.ResumeLayout(False)
        Me.grp_Notifications.PerformLayout()
        CType(Me.toggle_Voice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_Ringtone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Credentials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Credentials.ResumeLayout(False)
        Me.table_FTPMain.ResumeLayout(False)
        Me.table_FTPSub_2.ResumeLayout(False)
        Me.table_FTPSub_2.PerformLayout()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_FTPSub_1.ResumeLayout(False)
        Me.table_FTPSub_1.PerformLayout()
        CType(Me.txt_FTPServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Port.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_About.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPane As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tp_Alarm As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grp_FTPConsole As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_Console As RichTextBox
    Friend WithEvents cb_IncludeFiles As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_MaxDepth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_MaxDepth As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Minutes As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_Minutes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Hour As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_Hour As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_StopAlarm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_SetAlarm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grp_Status As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_CurrentCount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PreviousCount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_CurrentCount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_PreviousCount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_LastChecked As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_LastChecked As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AlarmInterval As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tp_Settings As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grp_Ringtone As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_ResetRingtone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Play As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_RingTone As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl_Ringtone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grp_Voice As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_TestVoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Voice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Voice As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grp_Email As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_To As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_To As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Gmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_TestEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_From As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_From As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grp_Notifications As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_Voice1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toggle_Voice As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents toggle_Email As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents toggle_Ringtone As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents lbl_Ringtone1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Email As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grp_Credentials As DevExpress.XtraEditors.GroupControl
    Friend WithEvents table_FTPMain As TableLayoutPanel
    Friend WithEvents table_FTPSub_2 As TableLayoutPanel
    Friend WithEvents lbl_Username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Colon3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Colon4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents table_FTPSub_1 As TableLayoutPanel
    Friend WithEvents lbl_FTPServer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Port As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Colon1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Colon2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_FTPServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Port As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tp_About As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents About As About
    Friend WithEvents txt_Elapsed As TimeLabel
    Friend WithEvents Timer_Tick As Timer
    Friend WithEvents Worker_Alarm As System.ComponentModel.BackgroundWorker
End Class
