namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string numero;
        private string modelo;
        private string imei;
        private int memoria;

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        protected string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        protected string Imei
        {
            get { return imei; }
            set { imei = value; }
        }

        protected int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
