using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;

namespace SGE
{
    public partial class Relatorios : Form
    {
        List<ReportParameter> listReportParameter = new List<ReportParameter>();
        ReportViewer rv = new ReportViewer();
        DataSet1 ds = new DataSet1();
        DataTable dt;
        DataRow dr;
        Listas lista = new Listas();
        Partido partido = new Partido();
        DepEstadual dep_Estadual = new DepEstadual();
        DepFederal dep_Federal = new DepFederal();
        Senador senador = new Senador();
        Governador governador = new Governador();
        Presidente presidente = new Presidente();
        Estado estado = new Estado();
        List<DepEstadual> auxEst;
        List<DepFederal> auxFed;
        List<Senador> auxSen;
        List<Governador> auxGov;
        List<Presidente> auxPres;
        FileStream file;
        Warning[] warnings;
        string[] streamids;
        string mimeType;
        string encoding;
        string extension;
        byte[] bytePDF;
        string nomeArquivo;
        int qtdeVotos = 0;
        int votosBrancos = 0;
        int votosNulos = 0;
        int qtdeEleitores = 0;

        public Relatorios()
        {
            InitializeComponent();
            estado.CadastraEstados();
            lista.Carrega_Eleitor();

            foreach (var x in estado.estados)
            {
                ufs.Items.Add(x.Sigla);
            }

            ufs.Items.Add("BR");
            ufs.Text = ufs.Items[0].ToString();
            cargos.Text = cargos.Items[0].ToString();

        }

        private void gerar_Click(object sender, EventArgs e)
        {
            dt = ds.Candidato;

            switch (cargos.Text)
            {
                case "Deputado Estadual":
                                        
                    qtdeEleitores = 0;
                    qtdeVotos = 0;
                    votosBrancos = 0;
                    votosNulos = 0;

                    dt.Clear();
                    dt = ds.Candidato;
                    auxEst = new List<DepEstadual>();
                    lista.Carrega_Dep_Estadual();
                    lista.Carrega_Nulo_Estadual();
                    lista.Carrega_Branco_Estadual();

                    foreach (var x in lista.List_DepEstadual)
                    {
                        if (ufs.Text == x.Uf)
                        {
                            auxEst.Add(x);
                            qtdeVotos = qtdeVotos + Convert.ToInt32(x.ContaVotos);
                        }
                    }

                    foreach (var x in auxEst)
                    {
                        dr = dt.NewRow();

                        dr["Nome"] = x.Nome;
                        dr["Partido"] = x.Part.Abrev;
                        dr["Num"] = x.Num.ToString();
                        dr["Qtde_Votos"] = x.ContaVotos;

                        dt.Rows.Add(dr);

                    }

                    foreach (var x in lista.List_Eleitor)
                    {
                        if (x.Uf == ufs.Text)
                        {
                            qtdeEleitores++;
                        }
                    }

                    foreach (var x in lista.list_Nulo_D_Est)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosNulos = votosNulos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    foreach (var x in lista.list_Branco_D_Est)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosBrancos = votosBrancos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    listReportParameter.Add(new ReportParameter("UF", ufs.Text));
                    listReportParameter.Add(new ReportParameter("NomeLocal", estado.estados[ufs.SelectedIndex].Nome));
                    listReportParameter.Add(new ReportParameter("TotalEleitores", qtdeEleitores.ToString()));
                    listReportParameter.Add(new ReportParameter("TotalVotos", qtdeVotos.ToString()));
                    listReportParameter.Add(new ReportParameter("Cargo", cargos.Text));
                    listReportParameter.Add(new ReportParameter("Branco", votosBrancos.ToString()));
                    listReportParameter.Add(new ReportParameter("Nulo", votosNulos.ToString()));

                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.LocalReport.ReportEmbeddedResource = "SGE.Relatorio.rdlc";
                    rv.LocalReport.SetParameters(listReportParameter);
                    rv.LocalReport.DataSources.Add(new ReportDataSource("Candidato", dt));

                    rv.RefreshReport();

                    listReportParameter.Clear();

                    bytePDF = rv.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    file = null;
                    nomeArquivo = Directory.GetCurrentDirectory() + "\\Relatorios\\Votos Dep. Estadual_" + ufs.Text + ".pdf";
                    file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Write(bytePDF, 0, bytePDF.Length);
                    file.Close();
                    Process.Start(nomeArquivo);

                    break;


                case "Deputado Federal":
                    
                    qtdeEleitores = 0;
                    qtdeVotos = 0;
                    votosBrancos = 0;
                    votosNulos = 0;

                    dt.Clear();
                    dt = ds.Candidato;
                    auxFed = new List<DepFederal>();
                    lista.Carrega_Dep_Federal();
                    lista.Carrega_Nulo_Federal();
                    lista.Carrega_Branco_Federal();

                    foreach (var x in lista.List_DepFederal)
                    {
                        if (ufs.Text == x.Uf)
                        {
                            auxFed.Add(x);
                            qtdeVotos = qtdeVotos + Convert.ToInt32(x.ContaVotos);
                        }
                    }

                    foreach (var x in auxFed)
                    {
                        dr = dt.NewRow();

                        dr["Nome"] = x.Nome;
                        dr["Partido"] = x.Part.Abrev;
                        dr["Num"] = x.Num.ToString();
                        dr["Qtde_Votos"] = x.ContaVotos;

                        dt.Rows.Add(dr);

                    }

                    foreach (var x in lista.List_DepFederal)
                    {
                        if (x.Uf == ufs.Text)
                        {
                            qtdeEleitores++;
                        }
                    }

                    foreach (var x in lista.list_Nulo_D_Fed)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosNulos = votosNulos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    foreach (var x in lista.list_Branco_D_Fed)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosBrancos = votosBrancos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    listReportParameter.Add(new ReportParameter("UF", ufs.Text));
                    listReportParameter.Add(new ReportParameter("NomeLocal", estado.estados[ufs.SelectedIndex].Nome));
                    listReportParameter.Add(new ReportParameter("TotalEleitores", qtdeEleitores.ToString()));
                    listReportParameter.Add(new ReportParameter("TotalVotos", qtdeVotos.ToString()));
                    listReportParameter.Add(new ReportParameter("Cargo", cargos.Text));
                    listReportParameter.Add(new ReportParameter("Branco", votosBrancos.ToString()));
                    listReportParameter.Add(new ReportParameter("Nulo", votosNulos.ToString()));

                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.LocalReport.ReportEmbeddedResource = "SGE.Relatorio.rdlc";
                    rv.LocalReport.SetParameters(listReportParameter);
                    rv.LocalReport.DataSources.Add(new ReportDataSource("Candidato", dt));

                    rv.RefreshReport();

                    listReportParameter.Clear();

                    bytePDF = rv.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    file = null;
                    nomeArquivo = Directory.GetCurrentDirectory() + "\\Relatorios\\Votos Dep. Ferderal_" + ufs.Text + ".pdf";
                    file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Write(bytePDF, 0, bytePDF.Length);
                    file.Close();
                    Process.Start(nomeArquivo);

                    break;

                case "Senador":

                    qtdeEleitores = 0;
                    qtdeVotos = 0;
                    votosBrancos = 0;
                    votosNulos = 0;
              
                    dt.Clear();
                    dt = ds.Candidato;
                    auxSen = new List<Senador>();
                    lista.Carrega_Senador();
                    lista.Carrega_Nulo_Senador();
                    lista.Carrega_Branco_Senador();

                    foreach (var x in lista.List_Senador)
                    {
                        if (ufs.Text == x.Uf)
                        {
                            auxSen.Add(x);
                            qtdeVotos = qtdeVotos + Convert.ToInt32(x.ContaVotos);
                        }
                    }

                    foreach (var x in auxSen)
                    {
                        dr = dt.NewRow();

                        dr["Nome"] = x.Nome;
                        dr["Partido"] = x.Part.Abrev;
                        dr["Num"] = x.Num.ToString();
                        dr["Qtde_Votos"] = x.ContaVotos;

                        dt.Rows.Add(dr);

                    }

                    foreach (var x in lista.List_Senador)
                    {
                        if (x.Uf == ufs.Text)
                        {
                            qtdeEleitores++;
                        }
                    }

                    foreach (var x in lista.list_Nulo_Sen)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosNulos = votosNulos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    foreach (var x in lista.list_Branco_Sen)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosBrancos = votosBrancos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    listReportParameter.Add(new ReportParameter("UF", ufs.Text));
                    listReportParameter.Add(new ReportParameter("NomeLocal", estado.estados[ufs.SelectedIndex].Nome));
                    listReportParameter.Add(new ReportParameter("TotalEleitores", qtdeEleitores.ToString()));
                    listReportParameter.Add(new ReportParameter("TotalVotos", qtdeVotos.ToString()));
                    listReportParameter.Add(new ReportParameter("Cargo", cargos.Text));
                    listReportParameter.Add(new ReportParameter("Branco", votosBrancos.ToString()));
                    listReportParameter.Add(new ReportParameter("Nulo", votosNulos.ToString()));

                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.LocalReport.ReportEmbeddedResource = "SGE.Relatorio.rdlc";
                    rv.LocalReport.SetParameters(listReportParameter);
                    rv.LocalReport.DataSources.Add(new ReportDataSource("Candidato", dt));

                    rv.RefreshReport();

                    listReportParameter.Clear();

                    bytePDF = rv.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    file = null;
                    nomeArquivo = Directory.GetCurrentDirectory() + "\\Relatorios\\Votos Senador_" + ufs.Text + ".pdf";
                    file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Write(bytePDF, 0, bytePDF.Length);
                    file.Close();
                    Process.Start(nomeArquivo);

                    break;

                case "Governador":
                                        
                    qtdeEleitores = 0;
                    qtdeVotos = 0;
                    votosBrancos = 0;
                    votosNulos = 0;

                    dt.Clear();
                    dt = ds.Candidato;
                    auxGov = new List<Governador>();
                    lista.Carrega_Governador();
                    lista.Carrega_Nulo_Governador();
                    lista.Carrega_Branco_Governador();

                    foreach (var x in lista.List_Governador)
                    {
                        if (ufs.Text == x.Uf)
                        {
                            auxGov.Add(x);
                            qtdeVotos = qtdeVotos + Convert.ToInt32(x.ContaVotos);
                        }
                    }

                    foreach (var x in auxGov)
                    {
                        dr = dt.NewRow();

                        dr["Nome"] = x.Nome;
                        dr["Partido"] = x.Part.Abrev;
                        dr["Num"] = x.Num.ToString();
                        dr["Qtde_Votos"] = x.ContaVotos;

                        dt.Rows.Add(dr);

                    }

                    foreach (var x in lista.List_Governador)
                    {
                        if (x.Uf == ufs.Text)
                        {
                            qtdeEleitores++;
                        }
                    }

                    foreach (var x in lista.list_Nulo_Gov)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosNulos = votosNulos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    foreach (var x in lista.list_Branco_Gov)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosBrancos = votosBrancos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    listReportParameter.Add(new ReportParameter("UF", ufs.Text));
                    listReportParameter.Add(new ReportParameter("NomeLocal", estado.estados[ufs.SelectedIndex].Nome));
                    listReportParameter.Add(new ReportParameter("TotalEleitores", qtdeEleitores.ToString()));
                    listReportParameter.Add(new ReportParameter("TotalVotos", qtdeVotos.ToString()));
                    listReportParameter.Add(new ReportParameter("Cargo", cargos.Text));
                    listReportParameter.Add(new ReportParameter("Branco", votosBrancos.ToString()));
                    listReportParameter.Add(new ReportParameter("Nulo", votosNulos.ToString()));

                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.LocalReport.ReportEmbeddedResource = "SGE.Relatorio.rdlc";
                    rv.LocalReport.SetParameters(listReportParameter);
                    rv.LocalReport.DataSources.Add(new ReportDataSource("Candidato", dt));

                    rv.RefreshReport();

                    listReportParameter.Clear();

                    bytePDF = rv.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    file = null;
                    nomeArquivo = Directory.GetCurrentDirectory() + "\\Relatorios\\Votos Governador_" + ufs.Text + ".pdf";
                    file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Write(bytePDF, 0, bytePDF.Length);
                    file.Close();
                    Process.Start(nomeArquivo);

                    break;

                case "Presidente":
                    
                    qtdeEleitores = 0;
                    qtdeVotos = 0;
                    votosBrancos = 0;
                    votosNulos = 0;

                    dt.Clear();
                    dt = ds.Candidato;
                    string auxuf;
                    auxPres = new List<Presidente>();
                    lista.Carrega_Presidente();
                    lista.Carrega_Nulo_Presidente();
                    lista.Carrega_Branco_Presidente();

                    foreach (var x in lista.List_Presidente)
                    {
                        for (int i = 0; i < x.ContaVotos.Count(); i++)
                        {
                            auxuf = x.ContaVotos[i].Substring(0, 2);

                            if (ufs.Text == auxuf)
                            {
                                qtdeVotos = qtdeVotos + Convert.ToInt32(x.ContaVotos[i].Substring(3));
                                auxPres.Add(x);
                            }
                        }

                    }

                    for (int i = 0; i < auxPres.Count; i++)
                    {
                        dr = dt.NewRow();

                        dr["Nome"] = auxPres[i].Nome;
                        dr["Partido"] = auxPres[i].Part.Abrev;
                        dr["Num"] = auxPres[i].Num.ToString();


                        for (int w = 0; w < auxPres[i].ContaVotos.Count(); w++)
                        {
                            auxuf = auxPres[i].ContaVotos[w].Substring(0, 2);

                            if (ufs.Text == auxuf)
                            {
                                dr["Qtde_Votos"] = auxPres[i].ContaVotos[w].Substring(3);
                            }
                        }

                        dt.Rows.Add(dr);

                    }

                    foreach (var x in lista.List_Presidente)
                    {
                        if (x.Uf == ufs.Text)
                        {
                            qtdeEleitores++;
                        }
                    }

                    foreach (var x in lista.Nulo_Presidente)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosNulos = votosNulos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    foreach (var x in lista.Branco_Presidente)
                    {
                        if (ufs.Text == x.Substring(0, 2))
                        {
                            votosBrancos = votosBrancos + Convert.ToInt32(x.Substring(3));
                        }
                    }

                    listReportParameter.Add(new ReportParameter("UF", ufs.Text));
                    if (ufs.Text == "BR")
                    {
                        listReportParameter.Add(new ReportParameter("NomeLocal", "Brasil"));
                    }
                    else
                    {
                        listReportParameter.Add(new ReportParameter("NomeLocal", estado.estados[ufs.SelectedIndex].Nome));
                    }
                    listReportParameter.Add(new ReportParameter("TotalEleitores", qtdeEleitores.ToString()));
                    listReportParameter.Add(new ReportParameter("TotalVotos", qtdeVotos.ToString()));
                    listReportParameter.Add(new ReportParameter("Cargo", cargos.Text));
                    listReportParameter.Add(new ReportParameter("Branco", votosBrancos.ToString()));
                    listReportParameter.Add(new ReportParameter("Nulo", votosNulos.ToString()));

                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.LocalReport.ReportEmbeddedResource = "SGE.Relatorio.rdlc";
                    rv.LocalReport.SetParameters(listReportParameter);
                    rv.LocalReport.DataSources.Add(new ReportDataSource("Candidato", dt));

                    rv.RefreshReport();

                    listReportParameter.Clear();

                    bytePDF = rv.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    file = null;
                    nomeArquivo = Directory.GetCurrentDirectory() + "\\Relatorios\\Votos Presidente_" + ufs.Text + ".pdf";
                    file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Write(bytePDF, 0, bytePDF.Length);
                    file.Close();
                    Process.Start(nomeArquivo);

                    break;
            }
        }

        private void cargos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void cargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ufs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ufs.Text =="BR")
            {
                cargos.Text = "Presidente";
                cargos.Enabled = false;
            }
            else
            {
                cargos.Enabled = true;
            }
        }
    }
}
