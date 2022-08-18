namespace Enumeracoes.Entities
{
    internal class Departament
    {
        public string Name { get; private set; }

        public Departament() {
        }

        public Departament(string name) {
            Name = name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
