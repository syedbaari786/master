﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisBwTwoCoOrdinates
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
        Me.BtnFindDistance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFindDistance
        '
        Me.BtnFindDistance.Location = New System.Drawing.Point(324, 169)
        Me.BtnFindDistance.Name = "BtnFindDistance"
        Me.BtnFindDistance.Size = New System.Drawing.Size(128, 71)
        Me.BtnFindDistance.TabIndex = 0
        Me.BtnFindDistance.Text = "Find Distance"
        Me.BtnFindDistance.UseVisualStyleBackColor = True
        '
        'FrmDisBwTwoCoOrdinates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnFindDistance)
        Me.Name = "FrmDisBwTwoCoOrdinates"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFindDistance As Button
End Class
