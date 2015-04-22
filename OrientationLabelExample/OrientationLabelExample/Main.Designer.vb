<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.OrientationLabel1 = New OrientationLabelExample.OrientationLabel()
        Me.SuspendLayout()
        '
        'OrientationLabel1
        '
        Me.OrientationLabel1.BackColor = System.Drawing.Color.Transparent
        Me.OrientationLabel1.Location = New System.Drawing.Point(65, 50)
        Me.OrientationLabel1.Name = "OrientationLabel1"
        Me.OrientationLabel1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.OrientationLabel1.Size = New System.Drawing.Size(20, 100)
        Me.OrientationLabel1.TabIndex = 0
        Me.OrientationLabel1.Text = "OrientationLabel1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.OrientationLabel1)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrientationLabel1 As OrientationLabelExample.OrientationLabel

End Class
