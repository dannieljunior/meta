namespace ApiOne.Data
{
    public class TaxaJurosDto
    {
        public TaxaJurosDto(double pTaxaJuros)
        {
            TaxaJuros = pTaxaJuros;
        }
        public double TaxaJuros { get; internal set; }
    }
}