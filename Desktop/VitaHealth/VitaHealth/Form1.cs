using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaHealth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ao clicar no botao, cria uma requisicao a API
            HttpWebRequest webRequest;

            string requestParams = "{'email': '"+InputEmail.Text+"', 'senha': '"+InputSenha.Text+"' }";

            webRequest = (HttpWebRequest)WebRequest.Create("http://192.168.15.123:5000/api/Login");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            
            try
            {
                //Se a resposta conter um status code 200, é retornado o token e exibido na aplicação
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                        string Json = rdr.ReadToEnd();
                        LabelResposta.ForeColor = Color.DarkSeaGreen;
                        LabelResposta.Text = "Resposta: " + Json;
                    }
                }

            }
            catch (Exception erro)
            {
                //Caso a aplicação retorne algum status code de erro (400, 401, 403), retorna o erro na aplicação
                LabelResposta.ForeColor = Color.Red;
                LabelResposta.Text = "Resposta: " + erro.Message;
            }

        }

        private void InputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
