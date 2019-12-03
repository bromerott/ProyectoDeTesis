using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ASP.NET_Tesis
{
    public class PredictionsController : Controller
    {
        BindingList<Prediction> listaPredicciones = new BindingList<Prediction>();
        string[] companies = new string[]{"WMT","GOOGL","AMZN","DB","IBM"};
        public PredictionsController(){
            //Load Data
            
            int i=0;
            foreach (string ticker in companies){
                Prediction p = new Prediction();
                i++;
                p.Id=i;
                p.CompanyName=ticker;
                //Get Current Price from Yahoo Finance
                BindingList<Double> precios = getPriceFromTicker(ticker);
                Double currentPrice = precios[precios.Count-1];
                p.CurrentPrice=currentPrice;
                //Get Prediction from Web Server
                p.PredictedPrice=getPrediction(ticker,precios);
                if (p.CurrentPrice>p.PredictedPrice){
                    p.Suggestion="SELL";
                }else{
                    p.Suggestion="BUY";
                }
                listaPredicciones.Add(p);
            }
        }
        static Double getPrediction(String ticker,BindingList<Double> historico){
            var client = new RestClient("http://3.220.201.212:5000/stockPrediction/getNextFromHistory");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type","application/json");
            JObject body = new JObject();
            body.Add("ticker",ticker);
            body.Add("api-key","MASTER");
            JArray hist = new JArray(historico);
            body.Add("historico",hist);
            request.AddParameter("applicationi/json; charset=utf-8",body.ToString(),ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            Console.WriteLine(body);
            IRestResponse response = client.Execute(request);
            Console.WriteLine("Respuesta:");
            Console.Write(response);
            var jObject = JObject.Parse(response.Content);
            Double prediction = Math.Round(Convert.ToDouble(jObject["prediction"]),2);
            return prediction;
        }
        static BindingList<Double> getPriceFromTicker(String ticker){
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long paststamp = timestamp-17280000;
            BindingList<Double> listaPrecios = new BindingList<Double>();
            var client = new RestClient("https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-historical-data?frequency=1d&filter=split&period1="+paststamp+"&period2="+timestamp+"&symbol="+ticker);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "b60679804emsh991305fe38a551cp16403djsn4d7ce7e9ab5b");
            IRestResponse response = client.Execute(request);
            var jObject = JObject.Parse(response.Content);
            var prices = jObject["prices"];
            for(int i =0;i<61;i++){
                listaPrecios.Add(Math.Round(Convert.ToDouble(prices[i]["close"]),2));
            }
            return listaPrecios;
        }


        public ActionResult Index()
        {
            return View(listaPredicciones);
        }
    }
}