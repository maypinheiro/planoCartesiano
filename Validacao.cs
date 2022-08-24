namespace PlanoCartesiano

{
    public class Validacao
    {
        public bool EZero(int[] numeros)
        {
            return (numeros[0] == 0) ? true : (numeros[1] == 0) ? true : false;
        }
    }


}