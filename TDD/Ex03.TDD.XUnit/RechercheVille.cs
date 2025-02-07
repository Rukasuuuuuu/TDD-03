using Ex03.TDD;
namespace Ex03.TDD.XUnit
{
    public class RechercheVille
    {
        public RechercheVille(List<string> villes)
        {
            _villes = villes;
        }
        private List<string> _villes = new()
    {
        "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver","Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok","Hong Kong", "Dubaï", "Rome", "Istanbul"};

        public List<string> Rechercher(string mot)
        {
            throw new NotImplementedException();
        }


    }
}