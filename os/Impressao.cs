using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace os
{
    public static class Impressao
    {
        public static void OrdemServico(string nome_empresa, string telefone_empresa,
                                        string celular_empresa, string email_empresa,
                                        string nome_cliente, string cpf_cliente,
                                        string endereco_cliente, string bairro_cliente,
                                        string cidade_cliente, string telefone_cliente,
                                        string celular_cliente, string data_entrada,
                                        bool retorno_entrada, string senha_entrada,
                                        string defeito_relatado, string observacoes_entrada, string equipamento_entrada,
                                        string marca_entrada, string modelo_entrada,
                                        string data_saida, string tecnico_saida, string defeito_saida,
                                        string servico_saida, string pecas_saida, bool finalizado_saida,
                                        string precoserv_saida, string precopeca_saida, string total_saida)
        {
            //Cria documento
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(50, 50, 30, 30);

            //Cria arquivo físico
            PdfWriter arquivo = PdfWriter.GetInstance(doc, new FileStream(Directory.GetCurrentDirectory() + "//OS.pdf", FileMode.Create));

            //Abre documento
            doc.Open();

            //Fontes
            var fontTimes = FontFactory.GetFont(FontFactory.TIMES, 12, 000);
            var fontTimesBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12, 000);

            //Cria logo no documento
            iTextSharp.text.Image imagem = iTextSharp.text.Image.GetInstance‪(Directory.GetCurrentDirectory() + "//logo.png");
            imagem.Alignment = iTextSharp.text.Image.UNDERLYING;
            imagem.ScalePercent(6000 / imagem.Width);
            doc.Add(imagem);

            //Cabeçalho
            Paragraph cabecalho = new Paragraph(string.Format("   ORDEM DE SERVIÇO\n   " + nome_empresa + "\n   " + telefone_empresa + " | " + celular_empresa + " | " + email_empresa), fontTimesBold);
            cabecalho.Alignment = Element.TITLE;
            doc.Add(cabecalho);
            doc.Add(new Paragraph(" "));

            //Cliente
            doc.Add(new Paragraph(" "));
            PdfPTable cliente = new PdfPTable(1);
            cliente.WidthPercentage = 100;

            cliente.AddCell("\n Cliente: " + nome_cliente + " | CPF: " + cpf_cliente +
                            "\n\n Endereço: " + endereco_cliente +
                            "\n\n Bairro: " + bairro_cliente + " | Cidade: " + cidade_cliente + "" +
                            "\n\n Telefone: " + telefone_cliente + " | Celular: " + celular_cliente + "\n ");
            doc.Add(cliente);

            //Entrada
            doc.Add(new Paragraph(" "));
            PdfPTable entrada = new PdfPTable(1);
            entrada.WidthPercentage = 100;

            entrada.AddCell("\nData de Entrada: " + data_entrada + " | Retorno: " + ((retorno_entrada == true? "Sim":"Não")) +
                            "\n\nSenha: " + (senha_entrada == ""? "Padrão\n              .   .   .\n              .   .   .\n              .   .   ." : senha_entrada) +
                            "\n\nDefeito Relatado: " + defeito_relatado +
                            "\n\nObservações: " + observacoes_entrada +
                            "\n\nEquipamento: " + equipamento_entrada + " | Marca: " + marca_entrada + " | Modelo: " + modelo_entrada + "\n ");
            doc.Add(entrada);

            //Saída
            doc.Add(new Paragraph(" "));
            PdfPTable saida = new PdfPTable(1);
            saida.WidthPercentage = 100;

            if (finalizado_saida)
            {
                saida.AddCell("\nData de Saída: " + data_saida + " | Técnico: " + tecnico_saida +
                          "\n\nDefeito Constatado: " + (defeito_saida == "" ? "\n\n\n\n " : defeito_saida) +
                          "\n\nServiço Executado: " + (servico_saida == "" ? "\n\n\n\n " : servico_saida) +
                          "\n\nPeças Utilizadas: " + (pecas_saida == "" ? "\n\n\n\n " : pecas_saida) +
                          "\n\nPreço Serviço: " + (precoserv_saida == "" || precoserv_saida == "0,00" ? "                   " : precoserv_saida) + " | Preço Peças: " + (precopeca_saida == "" || precopeca_saida == "0,00"? "                   " : precopeca_saida) + " | Total: " + (total_saida == "" || total_saida == "0,00" ? "                " : total_saida) + "\n ");
            }
            else
            {
                saida.AddCell("\nData de Saída:                   " + " | Técnico: " +
                          "\n\nDefeito Constatado: " + (defeito_saida == "" ? "\n\n\n\n " : defeito_saida) +
                          "\n\nServiço Executado: " + (servico_saida == "" ? "\n\n\n\n " : servico_saida) +
                          "\n\nPeças Utilizadas: " + (pecas_saida == "" ? "\n\n\n\n " : pecas_saida) +
                          "\n\nPreço Serviço: " + (precoserv_saida == "" || precoserv_saida == "0,00"? "                   " : precoserv_saida) + " | Preço Peças: " + (precopeca_saida == "" || precopeca_saida == "0,00"? "                   " : precopeca_saida) + " | Total: " + (total_saida == "" | total_saida == "0,00" ? "                " : total_saida) + "\n ");
            }

            doc.Add(saida);

            if (!finalizado_saida)
            {
                //Via de entrada
                doc.NewPage();

                //Título
                Paragraph titulo = new Paragraph(string.Format("TERMO DE SERVIÇO"), fontTimesBold);
                titulo.Alignment = Element.TITLE;
                doc.Add(titulo);

                doc.Add(new Paragraph(" "));
                doc.Add(cliente);
                doc.Add(new Paragraph(" "));

                //Termo
                Paragraph termo = new Paragraph(string.Format("1 | Em aparelhos no qual os defeitos relatados impossibilitem testes prévios, será realizada uma análise completa e, caso seja identificado novos defeitos, será informado ao cliente." +
                                                              "\n2 | O fornecimento da senha do aparelho não é obrigatório, porém, nesses casos, alguns testes não poderão ser realizados." +
                                                              "\n3 | A garantia do serviço é contada a partir da data da entrega/retirada do aparelho." +
                                                              "\n4 | Aparelhos molhados (oxidados) não tem garantia." +
                                                              "\n5 | Os serviços de software realizados (remoção de senha, instalação e atualização de sistema, etc.) são feitos sob autorização do cliente, no qual garante que solicita o serviço em razão de ter perdido/esquecido a senha ou afins, se responsabilizando legalmente pelo aparelho." +
                                                              ""), fontTimes);
                termo.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(termo);

                Paragraph assinatura = new Paragraph(string.Format("\n________________________________" + "                                    ________________________________" +
                                                                   "\nLoja                                                                                           Cliente"), fontTimesBold);
                assinatura.Alignment = Element.TITLE;
                doc.Add(assinatura);

                //Pontilhado
                Paragraph pontilhado = new Paragraph(string.Format("---------------------------------------------------------------------------------------------------------------------------"), fontTimes);
                pontilhado.Alignment = Element.TITLE;
                doc.Add(pontilhado);

                //2ª via termo
                doc.Add(titulo);
                doc.Add(new Paragraph(" "));
                doc.Add(cliente);
                doc.Add(new Paragraph(" "));
                doc.Add(termo);
                doc.Add(assinatura);
            }

            if (finalizado_saida)
            {
                //Via de entrada
                doc.NewPage();

                //Título
                Paragraph titulo = new Paragraph(string.Format("VIA DE RETIRADA"), fontTimesBold);
                titulo.Alignment = Element.TITLE;
                doc.Add(titulo);

                doc.Add(new Paragraph(" "));
                doc.Add(cliente);
                doc.Add(new Paragraph(" "));
                doc.Add(saida);
                doc.Add(new Paragraph(" "));

                //Termo
                Paragraph termo = new Paragraph(string.Format("1 | Afirmo receber o aparelho testado e em perfeito estado de funcionamento." +
                                                              "\n2 | A garantia do serviço é contada a partir da data da entrega/retirada do aparelho." +
                                                              "\n3 | Aparelhos molhados (oxidados), com indício de queda, lacre de garantia rompido ou defeitos não relacionados ao serviço executado não tem garantia." +
                                                              "\n4 | Tempo de garantia: ________________________________________________________________ " + 
                                                              "\n"), fontTimes);
                termo.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(termo);

                Paragraph assinatura = new Paragraph(string.Format("\n________________________________" + "                                    ________________________________" +
                                                                   "\nLoja                                                                                           Cliente"), fontTimesBold);
                assinatura.Alignment = Element.TITLE;
                doc.Add(assinatura);
            }


            // Fecha o documento
            doc.Close();

            //Mostra o documento
            string diretorio = Directory.GetCurrentDirectory() + "//OS.pdf";
            try
            {
                System.Diagnostics.Process.Start("SumatraPDF.exe", diretorio);
            }
            catch
            {
                try
                {
                    System.Diagnostics.Process.Start(diretorio);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao imprimir, tente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}