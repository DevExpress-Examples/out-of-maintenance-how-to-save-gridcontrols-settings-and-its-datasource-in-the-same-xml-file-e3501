Imports Microsoft.VisualBasic
Imports System
Namespace GridControlSaver
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridContrlSource = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.gridContrlDest = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.gridContrlSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridContrlDest, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridContrlSource
			' 
			Me.gridContrlSource.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridContrlSource.Location = New System.Drawing.Point(12, 27)
			Me.gridContrlSource.MainView = Me.gridView1
			Me.gridContrlSource.Name = "gridContrlSource"
			Me.gridContrlSource.Size = New System.Drawing.Size(370, 218)
			Me.gridContrlSource.TabIndex = 0
			Me.gridContrlSource.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridContrlSource
			Me.gridView1.Name = "gridView1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton1.Location = New System.Drawing.Point(601, 265)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Save"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton2.Location = New System.Drawing.Point(682, 265)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Restore"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Location = New System.Drawing.Point(12, 251)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(94, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "File for storing data"
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.DefaultExt = "*.xml"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 8)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(54, 13)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "Source grid"
			' 
			' gridContrlDest
			' 
			Me.gridContrlDest.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridContrlDest.Location = New System.Drawing.Point(388, 27)
			Me.gridContrlDest.MainView = Me.gridView2
			Me.gridContrlDest.Name = "gridContrlDest"
			Me.gridContrlDest.Size = New System.Drawing.Size(369, 218)
			Me.gridContrlDest.TabIndex = 6
			Me.gridContrlDest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridContrlDest
			Me.gridView2.Name = "gridView2"
			' 
			' labelControl3
			' 
			Me.labelControl3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl3.Location = New System.Drawing.Point(388, 8)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(75, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Destination grid"
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonEdit1.Location = New System.Drawing.Point(12, 267)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(583, 20)
			Me.buttonEdit1.TabIndex = 8
'			Me.buttonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonClick);
			' 
			' FormMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(770, 295)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.gridContrlDest)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gridContrlSource)
			Me.Name = "FormMain"
			Me.Text = "Main form"
			CType(Me.gridContrlSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridContrlDest, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridContrlSource As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private gridContrlDest As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
	End Class
End Namespace

