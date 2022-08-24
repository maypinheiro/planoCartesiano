namespace PlanoCartesiano

{
    public class Quadrante3 : IQuadrante
    {
        public string ValidaQuadrante(int num1, int num2)
        {
            return (num1 < 0 && num2 < 0) ? "Terceiro Quadrante" : string.Empty;
        }
    }


}