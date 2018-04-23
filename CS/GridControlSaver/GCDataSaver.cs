using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using DevExpress.XtraGrid;
using System.Collections;
using System.Xml.Serialization;
using System.Reflection;
using System.Xml;




namespace GridControlSaver
{
    public class GCDataSaver
    {
        private GridControl gridContrl;


        public GCDataSaver(GridControl gridContrl)
        {
            this.gridContrl = gridContrl;
        }



        public void SaveToXml(string fileName)
        {
            if (gridContrl == null) return;

            FileStream f_stream = new FileStream(fileName, FileMode.Create);
            try
            {
                string str = "<?xml version=\"1.0\"?>\r\n<container>\r\n";
                byte[] buffer = Encoding.ASCII.GetBytes(str);
                f_stream.Write(buffer, 0, buffer.Length);
                gridContrl.DefaultView.SaveLayoutToStream(f_stream);

                SaveDataSource(f_stream);

                str = "</container>";
                buffer = Encoding.ASCII.GetBytes(str);
                f_stream.Write(buffer, 0, buffer.Length);
            }
            finally
            {
                f_stream.Close();
            }
        }




        private void SaveDataSource(FileStream f_stream)
        {
            if (gridContrl == null || gridContrl.DataSource == null) return;

            MemoryStream ms = new MemoryStream();
            
            try
            {
                XmlDocument xml_doc = new XmlDocument();

                XmlSerializer xml_serial = new XmlSerializer(gridContrl.DataSource.GetType());

                xml_serial.Serialize(ms, gridContrl.DataSource);
                ms.Position = 0;
                xml_doc.Load(ms);
            
                byte[] buffer = Encoding.ASCII.GetBytes(xml_doc.DocumentElement.OuterXml);
                f_stream.Write(buffer, 0, buffer.Length);
            }
            catch
            {
            }
            finally
            {
                ms.Close();
            }
        }



        public void RestoreFromXml(string fileName, Type dataSourceType)
        {
            if (gridContrl == null) return;

            XmlDocument xml_doc = new XmlDocument();
            MemoryStream m_stream = new MemoryStream();
            try
            {
                xml_doc.Load(fileName);
                XmlNodeList node_list = xml_doc.DocumentElement.ChildNodes;
                byte[] buffer;
                for (int i = 0; i < node_list.Count; i++)
                {
                    buffer = Encoding.ASCII.GetBytes(node_list[i].OuterXml);

                    m_stream.Write(buffer, 0, buffer.Length);

                    if (i == 0)
                    {
                        m_stream.Position = 0;
                        gridContrl.DefaultView.RestoreLayoutFromStream(m_stream);
                        m_stream.SetLength(0);
                    }
                }

                if (m_stream.Length > 0)
                {
                    m_stream.Position = 0;
                    XmlSerializer xml_serial = new XmlSerializer(dataSourceType);
                    gridContrl.DataSource = xml_serial.Deserialize(m_stream);
                }
            }
            catch
            {
            }
            finally
            {
                m_stream.Close();
            }
        }
    }
}
