Imports System.ComponentModel

Public Class OrientationLabel

    Private _orientation As System.Windows.Forms.Orientation = Windows.Forms.Orientation.Vertical
    Public Property Orientation() As System.Windows.Forms.Orientation
        Get
            Return _orientation
        End Get
        Set(ByVal value As System.Windows.Forms.Orientation)
            _orientation = value
            ' the orientation has changed, refresh the control (redraw)
            Me.Refresh()
        End Set
    End Property

    Private _text As String = ""
    <EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always), Browsable(True),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Bindable(True)>
    Public Overrides Property Text() As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
            ' Text has changed therefore we must refresh the control (redraw)
            Me.Refresh()
        End Set
    End Property

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.Selectable, False)
        MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        ' regardless of the orientation we always want to set the drawing mode to be high quality
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality


        ' i am using using blocks so i dont have to worry about disposing of the brush
        ' i am also painting the background with the backcolour, which by default of this control is transparent
        Using backGroundBrush As New SolidBrush(MyBase.BackColor)
            e.Graphics.FillRectangle(backGroundBrush, 0, 0, e.Graphics.VisibleClipBounds.Width, e.Graphics.VisibleClipBounds.Height)
        End Using

        If _orientation = Windows.Forms.Orientation.Horizontal Then

            ' painting the foreground of the control, using the foreground colour of the control so that it is still customisable.
            Using foreGroundBrush As New SolidBrush(MyBase.ForeColor)
                e.Graphics.DrawString(Me.Text, Me.Font, foreGroundBrush, e.Graphics.VisibleClipBounds.Left, e.Graphics.VisibleClipBounds.Top + 2)
            End Using

            e.Graphics.Flush()

        ElseIf _orientation = Windows.Forms.Orientation.Vertical Then

            e.Graphics.TranslateTransform(0, Me.Height)
            e.Graphics.RotateTransform(90)

            ' painting the foreground of the control, using the foreground colour of the control so that it is still customisable.
            Using foreGroundBrush As New SolidBrush(MyBase.ForeColor)
                e.Graphics.DrawString(Me.Text, Me.Font, foreGroundBrush, e.Graphics.VisibleClipBounds.Left, e.Graphics.VisibleClipBounds.Top + 2)
            End Using

            e.Graphics.ResetTransform()
            e.Graphics.Flush()

        End If

    End Sub

End Class



