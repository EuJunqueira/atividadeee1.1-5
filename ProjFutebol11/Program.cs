using System;

namespace ProjFutebol11
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Cruzeiro");
            time1.contratarJogador(new Jogador("Fabio       ", 37, 99, 1 ));
            time1.contratarJogador(new Jogador("Egidio      ", 30, 5,  2 ));
            time1.contratarJogador(new Jogador("Dede        ", 33, 90, 3 ));
            time1.contratarJogador(new Jogador("Leo         ", 32, 85, 4 ));
            time1.contratarJogador(new Jogador("Edilson     ", 35, 10, 5) );
            time1.contratarJogador(new Jogador("Lucas       ", 27, 80, 6 ));
            time1.contratarJogador(new Jogador("Robinho     ", 31, 82, 7 ));
            time1.contratarJogador(new Jogador("Thiago      ", 36, 91, 8 ));
            time1.contratarJogador(new Jogador("Arrascaeta  ", 26, 95, 9 ));
            time1.contratarJogador(new Jogador("Rafinha     ", 35, 75, 10));
            time1.contratarJogador(new Jogador("Rafael      ", 34, 83, 11));
            time1.contratarJogador(new Jogador("Barcos      ", 40, 75, 12));

            Time time2 = new Time("CruzeiroLENDAS");
            time2.contratarJogador(new Jogador("Dida        ", 20, 99, 1 ));
            time2.contratarJogador(new Jogador("Nelinho     ", 21, 91, 2 ));
            time2.contratarJogador(new Jogador("Sorin       ", 22, 92, 3 ));
            time2.contratarJogador(new Jogador("Perfumo     ", 23, 93, 4 ));
            time2.contratarJogador(new Jogador("Luisao      ", 24, 94, 5 ));
            time2.contratarJogador(new Jogador("Dirceu      ", 27, 95, 6 ));
            time2.contratarJogador(new Jogador("Piazza      ", 31, 96, 7 ));
            time2.contratarJogador(new Jogador("Palinha     ", 18, 97, 8 ));
            time2.contratarJogador(new Jogador("Joaozinho   ", 26, 98, 9 ));
            time2.contratarJogador(new Jogador("Alex        ", 34, 99, 10));
            time2.contratarJogador(new Jogador("Tostao      ", 36, 99, 11));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();

            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores();

            Console.ReadKey();


        }
    }
}

