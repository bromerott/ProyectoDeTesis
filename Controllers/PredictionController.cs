using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Tesis
{
    public class PredictionController : Controller
    {
        BindingList<Prediction> listaPredicciones = new BindingList<Prediction>();
        public ActionResult Index()
        {
            return View(listaPredicciones);
        }
    }
}