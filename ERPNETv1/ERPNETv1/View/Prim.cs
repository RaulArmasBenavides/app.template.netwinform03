using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace admSoftware
{
    public partial class Prim : Form
    {
        int contador = 0;
        String nombPC;
        String syst;
        public Prim()
        {
            InitializeComponent();
            this.CenterToScreen();
            SoftwareEnSistema();
            InformacionGeneral();
        }
        private void SoftwareEnSistema()
        {
            Object nombre;
            Object path;
            String snombre;
            String spath;
            RegistryKey MiReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            string[] subkeys = MiReg.GetSubKeyNames();

            DataTable datGridView1 = new DataTable();
            datGridView1.Columns.Add("Nombre");
            datGridView1.Columns.Add("Direccion/Path");
            foreach (string subkey in subkeys)
            {
                MiReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + subkey);
                nombre = MiReg.GetValue("DisplayName");
                if (nombre == null)
                {
                    snombre = subkey.ToString();
                }
                else
                {
                    snombre = nombre.ToString();
                }
                path = MiReg.GetValue("InstallLocation");
                if (path == null)
                {
                    path = MiReg.GetValue("InstallSource");
                    if (path == null)
                    {
                        path = MiReg.GetValue("Inno Setup: App Path");
                        if (path == null)
                        {
                            path = MiReg.GetValue("InstallDir");

                            if (path == null)
                            {
                                path = MiReg.GetValue("DisplayIcon");
                                if (path == null)
                                {
                                    spath = "Null";
                                }
                                else
                                {
                                    spath = path.ToString();
                                }
                            }
                            else
                            {
                                spath = path.ToString();
                            }
                        }
                        else
                        {
                            spath = path.ToString();
                        }
                    }
                    else
                    {
                        spath = path.ToString();
                    }
                }
                else
                {
                    spath = path.ToString();
                }

                DataRow row = datGridView1.NewRow();
                row["Nombre"] = snombre;
                row["Direccion/Path"] = spath;
                datGridView1.Rows.Add(row);
            }

            foreach (DataRow Drow in datGridView1.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = Drow["Nombre"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["Direccion/Path"].ToString();
            }
        }

        public void InformacionGeneral()
        {
            Object nomPC = new Object();
            Object sy = new Object(); ;
            RegistryKey MiReg = Registry.CurrentUser.OpenSubKey("Volatile Environment");
            nomPC = MiReg.GetValue("USERDOMAIN");
            MiReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
            sy = MiReg.GetValue("ProductName");
            nombPC = nomPC.ToString();
            syst = sy.ToString();
            richTextBox1.Text = nombPC;
            richTextBox2.Text = syst;
        }

        public void GenerarPDF()
        {
            FileStream fs = new FileStream("Reporte.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.NewPage();
            doc.Add(new Paragraph("Generado con admSoftware. Software por Juan Pablo Guerrero Leal. Matricula 1674335\n\n"));
            doc.Add(new Paragraph("A continuacion se presenta en forma de tabla el listado de software instalados en el sistema y sus respectivas rutas.\n\n"));
            doc.Add(new Paragraph(""));


            PdfPTable table1 = new PdfPTable(1);
            table1.DefaultCell.Border = 0;
            table1.WidthPercentage = 80;
            table1.DefaultCell.BorderWidth = 2;
            table1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


            PdfPCell cell11 = new PdfPCell();
            cell11.Colspan = 1;
            cell11.AddElement(new Paragraph("Nombre PC: " + nombPC));

            cell11.AddElement(new Paragraph("S.O.: " + syst));
            cell11.VerticalAlignment = Element.ALIGN_CENTER;
            cell11.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell12 = new PdfPCell();


            cell12.VerticalAlignment = Element.ALIGN_CENTER;
            cell12.HorizontalAlignment = Element.ALIGN_CENTER;


            table1.AddCell(cell11);

            table1.AddCell(cell12);


            PdfPTable table2 = new PdfPTable(2);

            PdfPCell cell21 = new PdfPCell();

            cell21.AddElement(new Paragraph("Nombre"));

            PdfPCell cell22 = new PdfPCell();

            cell22.AddElement(new Paragraph("Direccion/Path"));



            table2.AddCell(cell21);

            table2.AddCell(cell22);

            Object nombre;
            Object path;
            String snombre;
            String spath;
            RegistryKey MiReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            string[] subkeys = MiReg.GetSubKeyNames();
            foreach (string subkey in subkeys)
            {
                MiReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + subkey);
                nombre = MiReg.GetValue("DisplayName");
                if (nombre == null)
                {
                    snombre = subkey.ToString();
                }
                else
                {
                    snombre = nombre.ToString();
                }
                path = MiReg.GetValue("InstallLocation");
                if (path == null)
                {
                    path = MiReg.GetValue("InstallSource");
                    if (path == null)
                    {
                        path = MiReg.GetValue("Inno Setup: App Path");
                        if (path == null)
                        {
                            path = MiReg.GetValue("InstallDir");

                            if (path == null)
                            {
                                path = MiReg.GetValue("DisplayIcon");
                                if (path == null)
                                {
                                    spath = "Null";
                                }
                                else
                                {
                                    spath = path.ToString();
                                }
                            }
                            else
                            {
                                spath = path.ToString();
                            }
                        }
                        else
                        {
                            spath = path.ToString();
                        }
                    }
                    else
                    {
                        spath = path.ToString();
                    }
                }
                else
                {
                    spath = path.ToString();
                }
                PdfPCell cell = new PdfPCell();
                cell.AddElement(new Paragraph(snombre));
                cell.FixedHeight = 50.0f;
                PdfPCell cell2 = new PdfPCell();
                cell2.AddElement(new Paragraph(spath));
                cell2.FixedHeight = 50.0f;
                table2.AddCell(cell);
                table2.AddCell(cell2);

            }

            doc.Add(table1);
            doc.Add(table2);
            Paragraph parrafo1 = new Paragraph("\n\n\n\nFirme aqui de enterado:\n\n\n\n");
            parrafo1.Alignment = Element.ALIGN_LEFT;
            doc.Add(parrafo1);
            Paragraph parrafo2 = new Paragraph("____________________");
            doc.Add(parrafo2);
            parrafo2.Alignment = Element.ALIGN_LEFT;

            doc.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                GenerarPDF();
                textBox5.Text = "Archivo Generado. Encuentralo en la carpeta raiz. ";
                contador++;
                string pdfPath = Path.Combine(Application.StartupPath, "Reporte.pdf");
                Process.Start(pdfPath);
            }
            else
            {
                textBox5.Text = "El archivo ya ha sido generado.";
            }


        }
    }
}
