using System;

namespace ProjetoFisica
{
    public class Formulas
    {
        public double Posicao_Final_X { get; set; }
        public double Posicao_Inicial_X { get; set; }

        public double Posicao_Final_Y { get; set; }
        public double Posicao_Inicial_Y { get; set; }

        public double Velocidade { get; set; }

        public double Tempo { get; set; }

        public double Aceleracao { get; set; }


        // Y = YO + VOT + 1/2AT²

        public double CalculaPosicao_Final_Y(double Posicao_Inicial_Y, double Velocidade, double Tempo, double Aceleracao)
        {
            return Posicao_Inicial_Y + Velocidade * Tempo + (Aceleracao * Math.Pow(Tempo, 2) / 2);
        }

        public double CalculaPosicao_Inicial_Y(double Posicao_Final_Y, double Velocidade, double Tempo, double Aceleracao)
        {
            return Posicao_Final_Y - Velocidade * Tempo + (Aceleracao * Math.Pow(Tempo, 2) / 2);
        }

        public double CalculaVelocidade(double Posicao_Final_Y, double Posicao_Inicial_Y, double Tempo, double Aceleracao)
        {
            return -(Posicao_Inicial_Y - Posicao_Final_Y + (Aceleracao / 2) * (Tempo * Tempo)) / Tempo;
        }

        public double CalculaTempo(double Posicao_Final_Y, double Posicao_Inicial_Y)
        {
            return Math.Sqrt((-Posicao_Final_Y + Posicao_Inicial_Y) / 5);
        }

       
        // X = XO + VOT
        public double CalculaPosicao_Final_X(double Posicao_Inicial_X, double Velocidade, double Tempo)
        {
            this.Posicao_Final_X = Posicao_Inicial_X + Velocidade * Tempo;
            return this.Posicao_Final_X;
        }

    }
}
