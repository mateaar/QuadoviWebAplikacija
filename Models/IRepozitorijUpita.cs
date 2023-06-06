namespace QuadoviWebAplikacija.Models
{
    public interface IRepozitorijUpita
    {
        IEnumerable<Bicikl> PopisBicikl(); // R - read
        void Create(Bicikl bicikl); // C - insert tj create
        void Delete(Bicikl bicikl); // D - delete
        void Update(Bicikl bicikl); //U - update
        int SljedeciId();
        int KategorijaSljedeciId();
        Bicikl DohvatiBiciklSIdom(int id);

        IEnumerable<Kategorija> PopisKategorija();
        void Create(Kategorija kategorija);
        void Delete(Kategorija kategorija);
        void Update(Kategorija kategorija);

        Kategorija DohvatiKategorijuSIdom(int id);
    }
}
