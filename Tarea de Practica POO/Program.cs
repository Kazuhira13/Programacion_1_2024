// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Bar obar = new Bar();
        Persona oMesero = new Mesero("kaz");
        Persona oCantinero = new Cantinero("Connor");
        Persona oCliente = new cliente("evelyn");
        obar.Entrar(oMesero);
        obar.Entrar(oCantinero);
        obar.Entrar(oCliente);

    }
    // Nota: cuando estaba haciendo lo poo hice varios archivos asi que lo junte todo en uno para no  armar mucho lio con otros archivos
    //uso de abstraccion Y uso de herecnias de la clase persona para las demas.
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public Persona(string Nombre)
        {
            this.Nombre = Nombre;

        }
        public abstract void Accion();
    }


    public class Cantinero : Persona
    {
        public Cantinero(string Nombre) : base(Nombre) { }
        public override void Accion()
        {
            Console.WriteLine("Cantinero:Hace bebidas");
        }
    }
    public class Mesero : Persona
    {
        public Mesero(string Nombre) : base(Nombre) { }

        public override void Accion()
        {
            Console.WriteLine("Mesero: Atiende Mesas");
        }
    }
    public class cliente : Persona
    {
        public cliente(string Nombre) : base(Nombre) { }
        public override void Accion()
        {
            Console.WriteLine("Client: Toma las bebidas");
        }
    }
    public class Bar
    {
        //Encapsulamiento
        private List<Persona> listPersona = new List<Persona>();

        public void Entrar(Persona opersona)
        {
            listPersona.Add(opersona);
            //polimorfismo
            opersona.Accion();
        }
    }
}
