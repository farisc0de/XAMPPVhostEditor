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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 128)
        Button1.Name = "Button1"
        Button1.Size = New Size(325, 23)
        Button1.TabIndex = 0
        Button1.Text = "Create Site"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(325, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(289, 23)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Select folder....."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 3
        Label1.Text = "Website Path"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 4
        Label2.Text = "Website Url"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(400, 160)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(10, 10)
        TextBox3.TabIndex = 5
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(307, 75)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 23)
        Button2.TabIndex = 6
        Button2.Text = "....."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(14, 104)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(124, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Laravel Applicaton"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(346, 157)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create a website"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox

End Class
