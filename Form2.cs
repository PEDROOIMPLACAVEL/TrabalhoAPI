using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransJSON(txt10.Text);
        }
        private async void TransJSON(string nome)
        {
            Uri A = new Uri("https://www.google.com");
            webView21.Source = A;
            string resp = nome;
            string aUrl = $"https://restcountries.com/v3.1/translation/{resp}";

            using HttpClient client = new HttpClient();
            try
            {
                //faznedo a conexão e a desserialização Inicial
                HttpResponseMessage response = await client.GetAsync(aUrl);
                response.EnsureSuccessStatusCode();

                string resposta = await response.Content.ReadAsStringAsync();
                JArray paises = JArray.Parse(resposta);
                var paises2 = paises[0];


                //desserializando e atribuindo valores oriundos do JSON
                var y = paises2["languages"]?.First?.ToString() ?? "Sem língua oficial";
                y = "{" + y + "}";
                JObject x = JObject.Parse(y);
                var nomee = paises2["translations"]["por"]["official"].ToString();
                var lingua = (string)x.Properties().First().Value;
                var moeda = paises2["currencies"]?.First?.First["name"]?.ToString() ?? "Sem moeda oficial";
                var capital = paises2["capital"]?.FirstOrDefault()?.ToString() ?? "Sem capital";
                var região = paises2["region"]?.ToString() ?? "Sem região";
                var nacionalidade = paises2["demonyms"]?.First?.First.ToString();
                var população = paises2["population"].ToString();
                string mapa = paises2["maps"]["openStreetMaps"]?.ToString();
                var fusohor = paises2["timezones"];
                txt1.Text = "Lingua: " + lingua;
                txt2.Text = "Moeda: " + moeda;
                txt3.Text = "Capital :" + capital;
                txt4.Text = "Região: " + região;
                txt5.Text = "Nacionalidade: " + nacionalidade;
                txt6.Text = "População: " + população;
                txt7.Text = "Fuso(s) Horário(s): " + fusohor;
                txt9.Text = "Nome: " + nomee;
                listBox1.Items.Add(txt9.Text);
                listBox1.Items.Add(txt1.Text);
                listBox1.Items.Add(txt2.Text);
                listBox1.Items.Add(txt3.Text);
                listBox1.Items.Add(txt4.Text);
                listBox1.Items.Add(txt5.Text);
                listBox1.Items.Add(txt6.Text);
                listBox1.Items.Add(txt7.Text);
                listBox1.Items.Add(txt8.Text);


                //IMAGEM
                string flagUrl = paises2["flags"]["png"]?.ToString();
                if (!string.IsNullOrEmpty(flagUrl))
                {
                    using HttpClient cliente = new HttpClient();
                    using HttpResponseMessage flagResponse = await cliente.GetAsync(flagUrl);
                    flagResponse.EnsureSuccessStatusCode();
                    using var stream = await flagResponse.Content.ReadAsStreamAsync();

                    imagem.Image = System.Drawing.Image.FromStream(stream);
                }
                string flaggUrl = paises2["coatOfArms"]["png"]?.ToString();
                if (!string.IsNullOrEmpty(flaggUrl))
                {
                    using HttpClient cliente1 = new HttpClient();
                    using HttpResponseMessage flaggResponse = await cliente1.GetAsync(flaggUrl);
                    flaggResponse.EnsureSuccessStatusCode();
                    using var stream1 = await flaggResponse.Content.ReadAsStreamAsync();

                    imagem2.Image = System.Drawing.Image.FromStream(stream1);
                }
                else MessageBox.Show("URL da bandeira está vazia ou nula.");


                if (!string.IsNullOrEmpty(mapa))
                {
                    Uri uri = new Uri(mapa);
                    webView21.Source = uri;
                }
            }
            catch (HttpRequestException e)
            {
                txt7.Text = e.Message;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagem2_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
