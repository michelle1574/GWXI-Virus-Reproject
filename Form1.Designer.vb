<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        DownloadProgress = New ProgressBar()
        PrepareProgress = New ProgressBar()
        InstallProgress = New ProgressBar()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DownloadTimer = New Timer(components)
        PrepareTimer = New Timer(components)
        InstallTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(12, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 38)
        Button1.TabIndex = 0
        Button1.Text = "Get ready"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(405, 29)
        Label1.TabIndex = 1
        Label1.Text = "Your free Windows 11 Upgrade is ready!"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 19)
        Label2.TabIndex = 2
        Label2.Text = "Just a few steps and we will be ready to install."' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Enabled = False
        RadioButton1.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(12, 89)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(133, 33)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Download"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Enabled = False
        RadioButton2.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(12, 128)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(108, 33)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Prepare"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Enabled = False
        RadioButton3.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(12, 167)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(115, 33)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "Upgrade"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' DownloadProgress
        ' 
        DownloadProgress.Location = New Point(12, 206)
        DownloadProgress.Name = "DownloadProgress"
        DownloadProgress.Size = New Size(597, 23)
        DownloadProgress.TabIndex = 6
        DownloadProgress.Visible = False
        ' 
        ' PrepareProgress
        ' 
        PrepareProgress.Location = New Point(12, 235)
        PrepareProgress.Name = "PrepareProgress"
        PrepareProgress.Size = New Size(597, 23)
        PrepareProgress.TabIndex = 7
        PrepareProgress.Visible = False
        ' 
        ' InstallProgress
        ' 
        InstallProgress.Location = New Point(12, 264)
        InstallProgress.Name = "InstallProgress"
        InstallProgress.Size = New Size(597, 23)
        InstallProgress.TabIndex = 8
        InstallProgress.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(151, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 29)
        Label3.TabIndex = 9
        Label3.Text = "0%"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(126, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 29)
        Label4.TabIndex = 10
        Label4.Text = "0%"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(133, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 29)
        Label5.TabIndex = 11
        Label5.Text = "0%"' 
        ' DownloadTimer
        ' 
        DownloadTimer.Interval = 1
        ' 
        ' PrepareTimer
        ' 
        PrepareTimer.Interval = 5
        ' 
        ' InstallTimer
        ' 
        InstallTimer.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(634, 358)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(InstallProgress)
        Controls.Add(PrepareProgress)
        Controls.Add(DownloadProgress)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Get Windows 11"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents DownloadProgress As ProgressBar
    Friend WithEvents PrepareProgress As ProgressBar
    Friend WithEvents InstallProgress As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DownloadTimer As Timer
    Friend WithEvents PrepareTimer As Timer
    Friend WithEvents InstallTimer As Timer
End Class
