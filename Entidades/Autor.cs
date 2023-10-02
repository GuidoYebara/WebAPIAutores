namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int id {get; set;}
        public string nombre {get; set;}
        
        public Autor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

    }


}