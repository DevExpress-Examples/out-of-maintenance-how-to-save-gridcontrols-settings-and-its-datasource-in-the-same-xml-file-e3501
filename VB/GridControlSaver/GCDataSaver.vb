Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Data
Imports DevExpress.XtraGrid
Imports System.Collections
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Xml




Namespace GridControlSaver
	Public Class GCDataSaver
		Private gridContrl As GridControl


		Public Sub New(ByVal gridContrl As GridControl)
			Me.gridContrl = gridContrl
		End Sub



		Public Sub SaveToXml(ByVal fileName As String)
			If gridContrl Is Nothing Then
				Return
			End If

			Dim f_stream As New FileStream(fileName, FileMode.Create)
			Try
				Dim str As String = "<?xml version=""1.0""?>" & Constants.vbCrLf & "<container>" & Constants.vbCrLf
				Dim buffer() As Byte = Encoding.ASCII.GetBytes(str)
				f_stream.Write(buffer, 0, buffer.Length)
				gridContrl.DefaultView.SaveLayoutToStream(f_stream)

				SaveDataSource(f_stream)

				str = "</container>"
				buffer = Encoding.ASCII.GetBytes(str)
				f_stream.Write(buffer, 0, buffer.Length)
			Finally
				f_stream.Close()
			End Try
		End Sub




		Private Sub SaveDataSource(ByVal f_stream As FileStream)
			If gridContrl Is Nothing OrElse gridContrl.DataSource Is Nothing Then
				Return
			End If

			Dim ms As New MemoryStream()

			Try
				Dim xml_doc As New XmlDocument()

				Dim xml_serial As New XmlSerializer(gridContrl.DataSource.GetType())

				xml_serial.Serialize(ms, gridContrl.DataSource)
				ms.Position = 0
				xml_doc.Load(ms)

				Dim buffer() As Byte = Encoding.ASCII.GetBytes(xml_doc.DocumentElement.OuterXml)
				f_stream.Write(buffer, 0, buffer.Length)
			Catch
			Finally
				ms.Close()
			End Try
		End Sub



		Public Sub RestoreFromXml(ByVal fileName As String, ByVal dataSourceType As Type)
			If gridContrl Is Nothing Then
				Return
			End If

			Dim xml_doc As New XmlDocument()
			Dim m_stream As New MemoryStream()
			Try
				xml_doc.Load(fileName)
				Dim node_list As XmlNodeList = xml_doc.DocumentElement.ChildNodes
				Dim buffer() As Byte
				For i As Integer = 0 To node_list.Count - 1
					buffer = Encoding.ASCII.GetBytes(node_list(i).OuterXml)

					m_stream.Write(buffer, 0, buffer.Length)

					If i = 0 Then
						m_stream.Position = 0
						gridContrl.DefaultView.RestoreLayoutFromStream(m_stream)
						m_stream.SetLength(0)
					End If
				Next i

				If m_stream.Length > 0 Then
					m_stream.Position = 0
					Dim xml_serial As New XmlSerializer(dataSourceType)
					gridContrl.DataSource = xml_serial.Deserialize(m_stream)
				End If
			Catch
			Finally
				m_stream.Close()
			End Try
		End Sub
	End Class
End Namespace
