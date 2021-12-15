using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDoModulo9_Cristian_Moura_Candimba
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e,f,g,h,i;

            Console.WriteLine("AVISO NAO DIGITAR 0!!!!!11");
            Console.WriteLine("Escolha o personagem \n1-Gladiador 2-Orochi 3-Shaolin");
            Console.WriteLine("Digite o numero e Clique na tecla Enter para continuar");
            a = Convert.ToInt32(Console.ReadLine());
            Personagem Lenda = new Personagem();
            
            switch (a)
            {
                case 0:
                    Console.WriteLine("living");
                    Console.ReadLine();
                    Console.WriteLine("deez nuts in your mouth");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    Lenda.nome = "Gladiador";
                    Lenda.vida = 100;
                    Lenda.defesa = 5;
                    Lenda.dano = 20;
                    break;
                case 2:
                    Console.Clear();
                    Lenda.nome = "Orochi";
                    Lenda.vida = 80;
                    Lenda.defesa = 10;
                    Lenda.dano = 25;
                    break;
                case 3:
                    Console.Clear();
                    Lenda.nome = "Shaolin";
                    Lenda.vida = 120;
                    Lenda.defesa = 15;
                    Lenda.dano = 15;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Valor colocado é fora de escala :( nos estamos muito triste com as suas ações, \n por isso iras ser executado no dia 11 de abril de 2022|");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            d = Lenda.vida;
            f = Lenda.defesa;
            Random rnd = new Random();
            Console.WriteLine(Lenda.nome);
            Console.WriteLine("Atributos:");
            Console.WriteLine("Vida:" + Lenda.vida);
            Console.WriteLine("Defesa:" + Lenda.defesa);
            Console.WriteLine("Dano:" + Lenda.dano);
            Console.WriteLine("Clique na tecla Enter para continuar");

            Console.ReadLine();
            Personagem Inimigo = new Personagem();
            Inimigo.nome = "Warden";
            Inimigo.dano = 15;
            Inimigo.vida = 60;
            Inimigo.defesa = 5;
            g = Inimigo.defesa;


            Console.Clear();
            Console.WriteLine("Nivel 1");
            Console.WriteLine("Warden");
            
            while (Inimigo.vida > 0 && Lenda.vida > 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Warden - "+ Inimigo.vida +"/60HP");
                Console.WriteLine("====================================\n \n");

                Console.WriteLine("====================================");
                Console.WriteLine(Lenda.nome + " - " + Lenda.vida + "/"+ d + "HP");
                Console.WriteLine("Selecione um ataque \n1-Ataque basico 2-Ataque rapido e bloquear parcialmente \n3-Ataque Poderoso 4-Bloquear");
                Console.WriteLine("====================================");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.Clear();
                    c = Lenda.dano - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (b == 2)
                {
                    Console.Clear();
                    c = (Lenda.dano - 5) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 5;
                }
                if (b == 3)
                {
                    Console.Clear();
                    c = (Lenda.dano + 10) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa - 10;

                }
                if (b == 4)
                {

                    Console.Clear();
                    Console.WriteLine("Passas-te o turno a Bloquear");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 10;
                   
                }
                Inimigo.defesa = g;
                e = rnd.Next(1, 4);

                if (e == 1)
                {
                    Console.Clear();
                    c = Inimigo.dano - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo Fez um ataque basico");
                    Console.WriteLine(Inimigo.nome +" causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (e == 2)
                {
                    Console.Clear();
                    c = (Inimigo.dano - 5) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque rapido e bloquear");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa + 5;
                    Console.Clear();
                }
                if (e == 3)
                {
                    Console.Clear();
                    c = (Inimigo.dano + 10) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque poderoso.");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa - 10;
                    Console.Clear();
                }
                if (e == 4)
                {

                    Console.Clear();
                    Console.WriteLine("O Inimigo usou Bloquear.");
                    Console.WriteLine("O "+ Inimigo.nome + " passou o turno a Bloquear.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Inimigo.defesa = Inimigo.defesa + 15;

                }
                Lenda.defesa = f;
            }
            Console.WriteLine("PARABENS MATAS-TE O NOBALHAO (MOURA) EZ");
            Console.ReadLine();
            Console.Clear();

            Lenda.vida = d;
            Console.WriteLine("Escolha um dos upgrades");
            Console.WriteLine("1- Vida 2-Dano 3-Defesa");
            h = Convert.ToInt32(Console.ReadLine());
            if (h == 1)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.vida = Lenda.vida + i;
                d = Lenda.vida;
                Console.ReadLine();
            }
            if (h == 2)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.dano = Lenda.dano + i;
                Console.ReadLine();
            }
            if (h == 3)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.defesa = Lenda.defesa + i;
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Nivel 2");
            Console.WriteLine("Lawbringer");

            Inimigo.nome = "Lawbringer";
            Inimigo.vida = 120;
            Inimigo.dano = 20;
            Inimigo.defesa = 10;

            while (Inimigo.vida > 0 && Lenda.vida > 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Lawbringer - " + Inimigo.vida + "/120HP");
                Console.WriteLine("====================================\n \n");

                Console.WriteLine("====================================");
                Console.WriteLine(Lenda.nome + " - " + Lenda.vida + "/" + d + "HP");
                Console.WriteLine("Selecione um ataque \n1-Ataque basico 2-Ataque rapido e defesa \n3-Ataque Poderoso 4-Bloquear");
                Console.WriteLine("====================================");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.Clear();
                    c = Lenda.dano - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (b == 2)
                {
                    Console.Clear();
                    c = (Lenda.dano - 5) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 5;
                }
                if (b == 3)
                {
                    Console.Clear();
                    c = (Lenda.dano + 10) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa - 10;

                }
                if (b == 4)
                {

                    Console.Clear();
                    Console.WriteLine("Passas-te o turno a Bloquear");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 10;

                }
                Inimigo.defesa = g;
                e = rnd.Next(1, 4);

                if (e == 1)
                {
                    Console.Clear();
                    c = Inimigo.dano - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (e == 2)
                {
                    Console.Clear();
                    c = (Inimigo.dano - 5) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa + 5;
                    Console.Clear();
                }
                if (e == 3)
                {
                    Console.Clear();
                    c = (Inimigo.dano + 10) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa - 10;
                    Console.Clear();
                }
                if (e == 4)
                {

                    Console.Clear();
                    Console.WriteLine("O " + Inimigo.nome + " passou o turno a Bloquear");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Inimigo.defesa = Inimigo.defesa + 15;

                }
                Lenda.defesa = f;
            }
            Lenda.vida = d;
            Console.WriteLine("Escolha um dos upgrades");
            Console.WriteLine("1- Vida 2-Dano 3-Defesa");
            h = Convert.ToInt32(Console.ReadLine());
            if (h == 1)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.vida = Lenda.vida + i;
                d = Lenda.vida;
                Console.ReadLine();
            }
            if (h == 2)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.dano = Lenda.dano + i;
                Console.ReadLine();
            }
            if (h == 3)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.defesa = Lenda.defesa + i;
                Console.ReadLine();
            }

            Inimigo.nome = "HighLander";
            Inimigo.vida = 120;
            Inimigo.defesa = 20;
            Inimigo.dano = 20;
            
            g = Inimigo.defesa;


            Console.Clear();
            Console.WriteLine("Nivel 3");
            Console.WriteLine("HighLander");

            while (Inimigo.vida > 0 && Lenda.vida > 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Highlander - " + Inimigo.vida + "/120HP");
                Console.WriteLine("====================================\n \n");

                Console.WriteLine("====================================");
                Console.WriteLine(Lenda.nome + " - " + Lenda.vida + "/" + d + "HP");
                Console.WriteLine("Selecione um ataque \n1-Ataque basico 2-Ataque rapido e bloquear parcialmente \n3-Ataque Poderoso 4-Bloquear");
                Console.WriteLine("====================================");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.Clear();
                    c = Lenda.dano - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (b == 2)
                {
                    Console.Clear();
                    c = (Lenda.dano - 5) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 5;
                }
                if (b == 3)
                {
                    Console.Clear();
                    c = (Lenda.dano + 10) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa - 10;

                }
                if (b == 4)
                {

                    Console.Clear();
                    Console.WriteLine("Passas-te o turno a Bloquear");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 10;

                }
                Inimigo.defesa = g;
                e = rnd.Next(1, 4);

                if (e == 1)
                {
                    Console.Clear();
                    c = Inimigo.dano - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo Fez um ataque basico");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (e == 2)
                {
                    Console.Clear();
                    c = (Inimigo.dano - 5) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque rapido e bloquear");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa + 5;
                    Console.Clear();
                }
                if (e == 3)
                {
                    Console.Clear();
                    c = (Inimigo.dano + 10) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque poderoso.");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa - 10;
                    Console.Clear();
                }
                if (e == 4)
                {

                    Console.Clear();
                    Console.WriteLine("O Inimigo usou Bloquear.");
                    Console.WriteLine("O " + Inimigo.nome + " passou o turno a Bloquear.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Inimigo.defesa = Inimigo.defesa + 15;

                }
                Lenda.defesa = f;
            }
            Lenda.vida = d;
            Console.WriteLine("Escolha um dos upgrades");
            Console.WriteLine("1- Vida 2-Dano 3-Defesa");
            h = Convert.ToInt32(Console.ReadLine());
            if (h == 1)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.vida = Lenda.vida + i;
                d = Lenda.vida;
                Console.ReadLine();
            }
            if (h == 2)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.dano = Lenda.dano + i;
                Console.ReadLine();
            }
            if (h == 3)
            {
                Console.WriteLine("");
                i = tier();
                Lenda.defesa = Lenda.defesa + i;
                Console.ReadLine();
            }
            Inimigo.nome = "Hitokiri";
            Inimigo.vida = 100;
            Inimigo.defesa = 25;
            Inimigo.dano = 30;
            
            
            g = Inimigo.defesa;


            Console.Clear();
            Console.WriteLine("Nivel 4");
            Console.WriteLine("Hitokiri");

            while (Inimigo.vida > 0 && Lenda.vida > 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Hitokiri - " + Inimigo.vida + "/100HP");
                Console.WriteLine("====================================\n \n");

                Console.WriteLine("====================================");
                Console.WriteLine(Lenda.nome + " - " + Lenda.vida + "/" + d + "HP");
                Console.WriteLine("Selecione um ataque \n1-Ataque basico 2-Ataque rapido e bloquear parcialmente \n3-Ataque Poderoso 4-Bloquear");
                Console.WriteLine("====================================");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.Clear();
                    c = Lenda.dano - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (b == 2)
                {
                    Console.Clear();
                    c = (Lenda.dano - 5) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 5;
                }
                if (b == 3)
                {
                    Console.Clear();
                    c = (Lenda.dano + 10) - Inimigo.defesa;
                    Inimigo.vida = Inimigo.vida - c;
                    Console.WriteLine("Causou " + c + " de dano");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa - 10;

                }
                if (b == 4)
                {

                    Console.Clear();
                    Console.WriteLine("Passas-te o turno a Bloquear");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Lenda.defesa = Lenda.defesa + 10;

                }
                Inimigo.defesa = g;
                e = rnd.Next(1, 4);

                if (e == 1)
                {
                    Console.Clear();
                    c = Inimigo.dano - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo Fez um ataque basico");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (e == 2)
                {
                    Console.Clear();
                    c = (Inimigo.dano - 5) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque rapido e bloquear");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa + 5;
                    Console.Clear();
                }
                if (e == 3)
                {
                    Console.Clear();
                    c = (Inimigo.dano + 10) - Lenda.defesa;
                    Lenda.vida = Lenda.vida - c;
                    Console.WriteLine("O Inimigo usou o ataque poderoso.");
                    Console.WriteLine(Inimigo.nome + " causou " + c + " de dano em voce.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Inimigo.defesa = Inimigo.defesa - 10;
                    Console.Clear();
                }
                if (e == 4)
                {

                    Console.Clear();
                    Console.WriteLine("O Inimigo usou Bloquear.");
                    Console.WriteLine("O " + Inimigo.nome + " passou o turno a Bloquear.");
                    Console.WriteLine("Clique na tecla Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Inimigo.defesa = Inimigo.defesa + 15;

                }
                Lenda.defesa = f;
            }
        }

        static int tier()
        {
            int i;
            Random tier = new Random();
            i = tier.Next(1, 100);

            if (i<=50)
            {
                Console.WriteLine("Tier 1");
                return 5;
            }
            if (i>50 || i <= 75)
            {
                Console.WriteLine("Tier 2");
                return 10;
            }
            if (i>75 || i <= 90)
            {
                Console.WriteLine("Tier 3");
                return 15;
            }
            if (i>90 || i <= 100)
            {
                Console.WriteLine("Tier 4");
                return 20;
            }
            return 0;
        }

        /*
        static int DanoDefendido(object Inimigo, object Lenda)
        {
            Console.WriteLine(Inimigo.vida);
            return 0;
        }
        static int DanoCausado(object Inimigo, object Lenda)
        {
            return 0;
        }*/
    }
}
