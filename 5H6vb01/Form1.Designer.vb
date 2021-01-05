<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.btnSluiten = New System.Windows.Forms.Button()
        Me.btnOefenen = New System.Windows.Forms.Button()
        Me.lblBoodschap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSluiten
        '
        Me.btnSluiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSluiten.Location = New System.Drawing.Point(1017, 512)
        Me.btnSluiten.Name = "btnSluiten"
        Me.btnSluiten.Size = New System.Drawing.Size(191, 167)
        Me.btnSluiten.TabIndex = 0
        Me.btnSluiten.Text = "Sluiten"
        Me.btnSluiten.UseVisualStyleBackColor = True
        '
        'btnOefenen
        '
        Me.btnOefenen.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOefenen.Location = New System.Drawing.Point(97, 512)
        Me.btnOefenen.Name = "btnOefenen"
        Me.btnOefenen.Size = New System.Drawing.Size(878, 189)
        Me.btnOefenen.TabIndex = 1
        Me.btnOefenen.Text = "Oefenen"
        Me.btnOefenen.UseVisualStyleBackColor = True
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Font = New System.Drawing.Font("Myanmar Text", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoodschap.Location = New System.Drawing.Point(90, 66)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(0, 113)
        Me.lblBoodschap.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._5H6vb01.My.Resources.Resources.Einstein
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 774)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Controls.Add(Me.btnOefenen)
        Me.Controls.Add(Me.btnSluiten)
        Me.Name = "Form1"
        Me.Text = "Optelsommen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSluiten As Button
    Friend WithEvents btnOefenen As Button
    Friend WithEvents lblBoodschap As Label
End Class
