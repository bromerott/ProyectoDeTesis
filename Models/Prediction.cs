namespace ASP.NET_Tesis
{
    public class Prediction{
        private int id;
        private string companyName;
        private double currentPrice;
        private double predictedPrice;
        private string suggestion;

        public string Suggestion { get => suggestion; set => suggestion = value; }
        public double PredictedPrice { get => predictedPrice; set => predictedPrice = value; }
        public double CurrentPrice { get => currentPrice; set => currentPrice = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public int Id { get => id; set => id = value; }
    }
}