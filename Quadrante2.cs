namespace PlanoCartesiano

{
    public class Quadrante2 : IQuadrante
    {
        public string ValidaQuadrante(int num1, int num2)
        {
            return (num1 < 0 && num2 > 0) ? "Segundo Quadrante" : string.Empty;
        }
    }


}