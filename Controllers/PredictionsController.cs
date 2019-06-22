using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Tesis
{
    public class PredictionsController : Controller
    {
        BindingList<Prediction> listaPredicciones = new BindingList<Prediction>();

        public PredictionsController(){
            //Load Data
            Prediction p = new Prediction();
            p.Id=1;
            p.CompanyName="Facebook";
            p.CurrentPrice=19.5;
            p.PredictedPrice=19.2;
            p.Suggestion="SELL";
            p.Accuracy=91.5;
            listaPredicciones.Add(p);
        }
        public ActionResult Index()
        {
            return View(listaPredicciones);
        }
    }
}