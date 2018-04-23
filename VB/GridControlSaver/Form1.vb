Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace GridControlSaver
	Partial Public Class FormMain
		Inherits Form
		Private dtListSource As DataTable
		Private dataSaverSource As GCDataSaver
		Private dataSaverDest As GCDataSaver


		Public Sub New()
			InitializeComponent()

			dtListSource = New DataTable("MyTable")
			dtListSource.Columns.AddRange(New DataColumn() { New DataColumn("Col1"), New DataColumn("Col2") })
			For i As Integer = 0 To 9
				dtListSource.Rows.Add(New String() { "Col1_" & i.ToString(), "Col1_" & i.ToString() })
			Next i

			gridContrlSource.DataSource = dtListSource

			dataSaverSource = New GCDataSaver(gridContrlSource)
			dataSaverDest = New GCDataSaver(gridContrlDest)
		End Sub



		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			If buttonEdit1.Text = String.Empty Then
				MessageBox.Show("You should specify name of file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If

			dataSaverSource.SaveToXml(buttonEdit1.Text)
		End Sub



		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			If buttonEdit1.Text = String.Empty Then
				MessageBox.Show("You should specify name of file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If

			dataSaverDest.RestoreFromXml(buttonEdit1.Text, dtListSource.GetType())
		End Sub



		Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
			If saveFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

			buttonEdit1.EditValue = saveFileDialog1.FileName
		End Sub
	End Class
End Namespace