<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label21 = New Label()
        ConfirmCheckBox = New CheckBox()
        RegisterBtn = New Button()
        Label20 = New Label()
        EmailAddressTxtBox = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        PhoneNumberTxtBox = New TextBox()
        CivilStatusTxtBox = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        BirthDatePicker = New DateTimePicker()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        BarangayComboBox = New ComboBox()
        Label12 = New Label()
        MunicipalityComboBox = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        CurrentAddressTxtBox = New TextBox()
        Label8 = New Label()
        AgeTxtBox = New TextBox()
        Label7 = New Label()
        SexTxtBox = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        MiddleNameLbl = New Label()
        FirstNameLbl = New Label()
        SurnameTxtBox = New TextBox()
        MiddleNameTxtBox = New TextBox()
        FirstNameTxtBox = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(ConfirmCheckBox)
        Panel1.Controls.Add(RegisterBtn)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(EmailAddressTxtBox)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(PhoneNumberTxtBox)
        Panel1.Controls.Add(CivilStatusTxtBox)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(BirthDatePicker)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(BarangayComboBox)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(MunicipalityComboBox)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(CurrentAddressTxtBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(AgeTxtBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(SexTxtBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(MiddleNameLbl)
        Panel1.Controls.Add(FirstNameLbl)
        Panel1.Controls.Add(SurnameTxtBox)
        Panel1.Controls.Add(MiddleNameTxtBox)
        Panel1.Controls.Add(FirstNameTxtBox)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1085, 528)
        Panel1.TabIndex = 1
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.DarkRed
        Label21.Location = New Point(354, 474)
        Label21.Name = "Label21"
        Label21.Size = New Size(65, 20)
        Label21.TabIndex = 35
        Label21.Text = "Required"
        ' 
        ' ConfirmCheckBox
        ' 
        ConfirmCheckBox.AutoSize = True
        ConfirmCheckBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ConfirmCheckBox.Location = New Point(338, 447)
        ConfirmCheckBox.Name = "ConfirmCheckBox"
        ConfirmCheckBox.Size = New Size(496, 27)
        ConfirmCheckBox.TabIndex = 34
        ConfirmCheckBox.Text = "I confirm that all the details above are correct and accurate"
        ConfirmCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.BackColor = Color.ForestGreen
        RegisterBtn.FlatAppearance.BorderColor = Color.SeaGreen
        RegisterBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegisterBtn.ForeColor = SystemColors.Control
        RegisterBtn.Location = New Point(838, 438)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(228, 64)
        RegisterBtn.TabIndex = 33
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label20.Location = New Point(598, 141)
        Label20.Name = "Label20"
        Label20.Size = New Size(105, 20)
        Label20.TabIndex = 32
        Label20.Text = "Email address"
        ' 
        ' EmailAddressTxtBox
        ' 
        EmailAddressTxtBox.Location = New Point(707, 138)
        EmailAddressTxtBox.Name = "EmailAddressTxtBox"
        EmailAddressTxtBox.Size = New Size(248, 27)
        EmailAddressTxtBox.TabIndex = 31
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.DarkRed
        Label18.Location = New Point(707, 108)
        Label18.Name = "Label18"
        Label18.Size = New Size(65, 20)
        Label18.TabIndex = 30
        Label18.Text = "Required"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label19.Location = New Point(593, 84)
        Label19.Name = "Label19"
        Label19.Size = New Size(112, 20)
        Label19.TabIndex = 29
        Label19.Text = "Phone number"
        ' 
        ' PhoneNumberTxtBox
        ' 
        PhoneNumberTxtBox.Location = New Point(707, 80)
        PhoneNumberTxtBox.Name = "PhoneNumberTxtBox"
        PhoneNumberTxtBox.Size = New Size(248, 27)
        PhoneNumberTxtBox.TabIndex = 28
        ' 
        ' CivilStatusTxtBox
        ' 
        CivilStatusTxtBox.Location = New Point(121, 306)
        CivilStatusTxtBox.Name = "CivilStatusTxtBox"
        CivilStatusTxtBox.Size = New Size(109, 27)
        CivilStatusTxtBox.TabIndex = 27
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label17.Location = New Point(31, 309)
        Label17.Name = "Label17"
        Label17.Size = New Size(85, 20)
        Label17.TabIndex = 26
        Label17.Text = "Civil status"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.DarkRed
        Label16.Location = New Point(118, 274)
        Label16.Name = "Label16"
        Label16.Size = New Size(65, 20)
        Label16.TabIndex = 25
        Label16.Text = "Required"
        ' 
        ' BirthDatePicker
        ' 
        BirthDatePicker.Location = New Point(121, 244)
        BirthDatePicker.Name = "BirthDatePicker"
        BirthDatePicker.Size = New Size(250, 27)
        BirthDatePicker.TabIndex = 24
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label15.Location = New Point(37, 247)
        Label15.Name = "Label15"
        Label15.Size = New Size(79, 20)
        Label15.TabIndex = 22
        Label15.Text = "Birth date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(588, 22)
        Label14.Name = "Label14"
        Label14.Size = New Size(204, 28)
        Label14.TabIndex = 21
        Label14.Text = "Contact Information"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(22, 22)
        Label13.Name = "Label13"
        Label13.Size = New Size(164, 28)
        Label13.TabIndex = 20
        Label13.Text = "Personal Details"
        ' 
        ' BarangayComboBox
        ' 
        BarangayComboBox.FormattingEnabled = True
        BarangayComboBox.Location = New Point(838, 308)
        BarangayComboBox.Name = "BarangayComboBox"
        BarangayComboBox.Size = New Size(140, 28)
        BarangayComboBox.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(764, 311)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 20)
        Label12.TabIndex = 18
        Label12.Text = "Barangay"
        ' 
        ' MunicipalityComboBox
        ' 
        MunicipalityComboBox.FormattingEnabled = True
        MunicipalityComboBox.Location = New Point(576, 309)
        MunicipalityComboBox.Name = "MunicipalityComboBox"
        MunicipalityComboBox.Size = New Size(157, 28)
        MunicipalityComboBox.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(475, 312)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 20)
        Label11.TabIndex = 16
        Label11.Text = "Municipality"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkRed
        Label10.Location = New Point(573, 274)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 20)
        Label10.TabIndex = 15
        Label10.Text = "Required"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(450, 247)
        Label9.Name = "Label9"
        Label9.Size = New Size(123, 20)
        Label9.TabIndex = 14
        Label9.Text = "Current Address"
        ' 
        ' CurrentAddressTxtBox
        ' 
        CurrentAddressTxtBox.Location = New Point(575, 244)
        CurrentAddressTxtBox.Name = "CurrentAddressTxtBox"
        CurrentAddressTxtBox.Size = New Size(462, 27)
        CurrentAddressTxtBox.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkRed
        Label8.Location = New Point(431, 168)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 20)
        Label8.TabIndex = 12
        Label8.Text = "Required"
        ' 
        ' AgeTxtBox
        ' 
        AgeTxtBox.Location = New Point(431, 82)
        AgeTxtBox.Name = "AgeTxtBox"
        AgeTxtBox.Size = New Size(109, 27)
        AgeTxtBox.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(392, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 10
        Label7.Text = "Age"
        ' 
        ' SexTxtBox
        ' 
        SexTxtBox.FormattingEnabled = True
        SexTxtBox.Location = New Point(431, 137)
        SexTxtBox.Name = "SexTxtBox"
        SexTxtBox.Size = New Size(109, 28)
        SexTxtBox.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(390, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 20)
        Label6.TabIndex = 8
        Label6.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkRed
        Label5.Location = New Point(120, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 7
        Label5.Text = "Required"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkRed
        Label4.Location = New Point(120, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 6
        Label4.Text = "Required"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(47, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 5
        Label3.Text = "Surname"
        ' 
        ' MiddleNameLbl
        ' 
        MiddleNameLbl.AutoSize = True
        MiddleNameLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        MiddleNameLbl.Location = New Point(19, 137)
        MiddleNameLbl.Name = "MiddleNameLbl"
        MiddleNameLbl.Size = New Size(100, 20)
        MiddleNameLbl.TabIndex = 4
        MiddleNameLbl.Text = "Middle name"
        ' 
        ' FirstNameLbl
        ' 
        FirstNameLbl.AutoSize = True
        FirstNameLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FirstNameLbl.Location = New Point(37, 82)
        FirstNameLbl.Name = "FirstNameLbl"
        FirstNameLbl.Size = New Size(83, 20)
        FirstNameLbl.TabIndex = 3
        FirstNameLbl.Text = "First name"
        ' 
        ' SurnameTxtBox
        ' 
        SurnameTxtBox.Location = New Point(120, 188)
        SurnameTxtBox.Name = "SurnameTxtBox"
        SurnameTxtBox.Size = New Size(248, 27)
        SurnameTxtBox.TabIndex = 2
        ' 
        ' MiddleNameTxtBox
        ' 
        MiddleNameTxtBox.Location = New Point(120, 136)
        MiddleNameTxtBox.Name = "MiddleNameTxtBox"
        MiddleNameTxtBox.Size = New Size(248, 27)
        MiddleNameTxtBox.TabIndex = 1
        ' 
        ' FirstNameTxtBox
        ' 
        FirstNameTxtBox.Location = New Point(120, 81)
        FirstNameTxtBox.Name = "FirstNameTxtBox"
        FirstNameTxtBox.Size = New Size(248, 27)
        FirstNameTxtBox.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1110, 555)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FirstNameLbl As Label
    Friend WithEvents SurnameTxtBox As TextBox
    Friend WithEvents MiddleNameTxtBox As TextBox
    Friend WithEvents FirstNameTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MiddleNameLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AgeTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SexTxtBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CurrentAddressTxtBox As TextBox
    Friend WithEvents BarangayComboBox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MunicipalityComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BirthDatePicker As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PhoneNumberTxtBox As TextBox
    Friend WithEvents CivilStatusTxtBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents EmailAddressTxtBox As TextBox
    Friend WithEvents ConfirmCheckBox As CheckBox
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents Label21 As Label

End Class
