using System;

// Abstracción
abstract class Personaje
{
    public abstract void Atacar();
    public abstract void Defenderse();
}

// Herencia
class NaveEspacial
{
    public string Nombre { get; set; }
    public int Velocidad { get; set; }
}

class CazaEstelar : NaveEspacial
{
    public void DesplegarEscudos()
    {
        // No hay Console.WriteLine aquí en la clase CazaEstelar
    }
}

// Polimorfismo
interface IFuerza
{
    void UsarFuerza();
}

class Jedi : Personaje, IFuerza
{
    public override void Atacar() { }

    public override void Defenderse() { }

    public void UsarFuerza() { }
}

class Sith : Personaje, IFuerza
{
    public override void Atacar() { }

    public override void Defenderse() { }

    public void UsarFuerza() { }
}

// Encapsulación
class Droide
{
    private string Tipo { get; set; }
    public string Funcionalidad { get; set; }

    public Droide(string tipo, string funcionalidad)
    {
        Tipo = tipo;
        Funcionalidad = funcionalidad;
    }
}

// Interfaces
interface IFaccion
{
    string ObtenerFaccion();
}

class Alianza : IFaccion
{
    public string ObtenerFaccion()
    {
        return "La Alianza Rebelde";
    }
}

class Imperio : IFaccion
{
    public string ObtenerFaccion()
    {
        return "El Imperio Galáctico";
    }
}

// Delegados
delegate void DelegadoLider(Personaje lider);

// Eventos
class BatallaEventArgs : EventArgs
{
    public string Lugar { get; set; }
    public string Resultado { get; set; }
}

class Batalla
{
    public event EventHandler<BatallaEventArgs> InicioBatalla;

    public void EmpezarBatalla(string lugar)
    {
        OnInicioBatalla(new BatallaEventArgs { Lugar = lugar, Resultado = "Indefinido" });
    }

    protected virtual void OnInicioBatalla(BatallaEventArgs e)
    {
        InicioBatalla?.Invoke(this, e);
    }
}

// Indexadores
class Galaxia
{
    private string[] planetas = { "Tatooine", "Coruscant", "Endor" };

    public string this[int i]
    {
        get { return planetas[i]; }
        set { planetas[i] = value; }
    }
}

// Propiedades
class Arma
{
    private string tipo;

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
}