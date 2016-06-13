using System;

namespace ProjetoFisica
{
    public class Formulas
    {
        #region Propriedades
        public double Posicao_Final_X { get; set; }
        public double Posicao_Inicial_X { get; set; }

        public double Posicao_Final_Y { get; set; }
        public double Posicao_Inicial_Y { get; set; }

        public double Velocidade { get; set; }

        public double Tempo { get; set; }

        public const double Aceleracao = -10;
        #endregion

        #region Y = YO + VOT + 1/2AT²
        public double CalculaPosicao_Final_Y()
        {
            return Posicao_Inicial_Y + Velocidade * Tempo + (Aceleracao * Math.Pow(Tempo, 2) / 2);
        }

        public double CalculaPosicao_Inicial_Y()
        {
            return Posicao_Final_Y - Velocidade * Tempo + (Aceleracao * Math.Pow(Tempo, 2) / 2);
        }

        public double CalculaVelocidade()
        {
            return -(Posicao_Inicial_Y - Posicao_Final_Y + (Aceleracao / 2) * Math.Pow(Tempo, 2)) / Tempo;
        }

        public double CalculaTempo()
        {
            return Math.Sqrt((-Posicao_Final_Y + Posicao_Inicial_Y) / 5);
        }
        #endregion

        #region X = XO + VOT
        public double CalculaPosicao_Final_X()
        {
            return Posicao_Inicial_X + Velocidade * Tempo;
        }

        public double CalculaPosicao_Inicial_X()
        {
            return Posicao_Final_X - Velocidade * Tempo;
        }

        public double Calcula_Velocidade()
        {
           return (Posicao_Final_X - Posicao_Inicial_X) / Tempo;
        }

        public double Calcula_Tempo()
        {
            return (Posicao_Final_X - Posicao_Inicial_X) / Velocidade;
        }
        #endregion
    }
}
