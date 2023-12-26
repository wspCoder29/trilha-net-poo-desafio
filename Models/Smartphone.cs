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

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Imei
        {
            get { return imei; }
            set { imei = value; }
        }

        public int Memoria
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
