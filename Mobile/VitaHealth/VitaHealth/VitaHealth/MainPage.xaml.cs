using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VitaHealth
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnLogin(object sender, EventArgs args)
        {
            //Ao clicar no botao, cria uma requisicao a API
            HttpWebRequest webRequest;

            string requestParams = "{'email': '" + Email.Text + "', 'senha': '" + Senha.Text + "' }";

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
                        LabelResposta.TextColor = Color.DarkSeaGreen;
                        LabelResposta.Text = "Resposta: " + Json;
                    }
                }

            }
            catch (Exception erro)
            {
                //Caso a aplicação retorne algum status code de erro (400, 401, 403), retorna o erro na aplicação
                LabelResposta.TextColor = Color.Red;
                LabelResposta.Text = "Resposta: " + erro.Message;
            }
        }
    }
}