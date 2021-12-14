
namespace Enum
{
    internal interface IAnimal
    {
        void Nome(string name);
        void Dono(string Dono);
        void Especie(string Especie);

    }

    class Animal: IAnimal
    {
        public string Nome { get; set; }    
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;                              
        }
        void IAnimal.Dono(string nomeDono)
        {
           this.Dono = Dono;    
        }
        void IAnimal.Especie(string Especie)
        {
            this.Especie = Especie;
        }
    }

}
