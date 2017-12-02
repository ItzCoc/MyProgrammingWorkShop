using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            /*its way more complicated than it should be... BUT IT WORKS 
             *There are way to many integers
             *Made By Christopher Buchberger
             */


            int nextPlayer = 1; //IF it would be 0 first turn would go to O i like X more that's why nextPlayer is 1
            int playerCheck = 1;
            string playerEdge = "*  *";
            string playerMiddle = " ** ";
            string input = "";
            string errorFieldIsAlreadyUsed = "Dieses Feld wurde schon gewählt nimm bitte ein noch nicht gewähltes";

            bool inputIsCorrect = false;
            Console.WriteLine("Wilkommen zu Tic-Tac-Toe");
            Console.WriteLine("************************");
            Console.WriteLine("Regeln:");
            Console.WriteLine("3 gleiche Zeichen in");
            Console.WriteLine("einer Reihe Parralel");
            Console.WriteLine("oder Schräg gewinnt!");
            Console.WriteLine("************************");
            Console.WriteLine("Steuerung:");
            Console.WriteLine("Du willst in das Mittlere");
            Console.WriteLine("Feld  dein Zeichen  geben");
            Console.WriteLine("Das heißt mittlere  Reihe");
            Console.WriteLine("also  M  für  Mitte und M");
            Console.WriteLine("für Mittlere Reihe");
            Console.WriteLine("********");
            Console.WriteLine("Befehle");
            Console.WriteLine("O = Oben Obere Reihe , M = Mitte Mittlere Reihe U = Unten Untere Reihe");
            Console.WriteLine("L = Links,M = mittlere Reihe,R= Rechts");
            Console.WriteLine(" Deine eingabe zb. OL = Oben Links");
            Console.WriteLine("Drück eine Taste um fortzufahren");
            Console.ReadLine();

            int gameOver = 2;
            //Oben Rechts
            string fieldOR1 = "    ";
            string fieldOR2 = "    ";
            string fieldOR3 = "    ";
            string fieldOR4 = "    ";
            int lockOR = 0;		//lockOR das Feld Oben Rechts (OR) ist gespert
            int lockORX = 0;	//sagt dem Programm welcher spieler das Feld gesperrt hat
            int lockORY = 0;	//sagt dem Programm welcher spieler das Feld gesperrt hat
            //Oben Mitte
            string fieldOM1 = "    ";
            string fieldOM2 = "    ";
            string fieldOM3 = "    ";
            string fieldOM4 = "    ";
            int lockOM = 0;
            int lockOMX = 0;
            int lockOMY = 0;
            //Oben Links
            string fieldOL1 = "    ";
            string fieldOL2 = "    ";
            string fieldOL3 = "    ";
            string fieldOL4 = "    ";
            int lockOL = 0;
            int lockOLX = 0;
            int lockOLY = 0;
            //Mitte Rechts
            string fieldML1 = "    ";
            string fieldML2 = "    ";
            string fieldML3 = "    ";
            string fieldML4 = "    ";
            int lockML = 0;
            int lockMLX = 0;
            int lockMLY = 0;
            //Mitte Mitte
            string fieldMM1 = "    ";
            string fieldMM2 = "    ";
            string fieldMM3 = "    ";
            string fieldMM4 = "    ";
            int lockMM = 0;
            int lockMMX = 0;
            int lockMMY = 0;
            //Mitte Links
            string fieldMR1 = "    ";
            string fieldMR2 = "    ";
            string fieldMR3 = "    ";
            string fieldMR4 = "    ";
            int lockMR = 0;
            int lockMRX = 0;
            int lockMRY = 0;
            //Mitte Rechts
            string fieldUL1 = "    ";
            string fieldUL2 = "    ";
            string fieldUL3 = "    ";
            string fieldUL4 = "    ";
            int lockUL = 0;
            int lockULX = 0;
            int lockULY = 0;
            //Mitte Mitte
            string fieldUM1 = "    ";
            string fieldUM2 = "    ";
            string fieldUM3 = "    ";
            string fieldUM4 = "    ";
            int lockUM = 0;
            int lockUMX = 0;
            int lockUMY = 0;
            //Mitte Links
            string fieldUR1 = "    ";
            string fieldUR2 = "    ";
            string fieldUR3 = "    ";
            string fieldUR4 = "    ";
            int lockUR = 0;
            int lockURX = 0;
            int lockURY = 0;
            while (gameOver > 0)
            {
                Console.Clear();
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldOL1, fieldOM1, fieldOR1);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldOL2, fieldOM2, fieldOR2);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldOL3, fieldOM3, fieldOR3);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldOL4, fieldOM4, fieldOR4);

                Console.WriteLine("***********************************");

                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldML1, fieldMM1, fieldMR1);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldML2, fieldMM2, fieldMR2);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldML3, fieldMM3, fieldMR3);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldML4, fieldMM4, fieldMR4);

                Console.WriteLine("***********************************");

                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldUL1, fieldUM1, fieldUR1);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldUL2, fieldUM2, fieldUR2);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldUL3, fieldUM3, fieldUR3);
                Console.WriteLine("  {0}     * {1}   * {2}    ", fieldUL4, fieldUM4, fieldUR4);



                while (!inputIsCorrect)
                {
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    nextPlayer++;
                    if (nextPlayer % 2 == 0)
                    {
                        if (input == "OL")
                        {
                            if (lockOL == 0)
                            {
                                fieldOL1 = playerEdge;
                                fieldOL2 = playerMiddle;
                                fieldOL3 = playerMiddle;
                                fieldOL4 = playerEdge;
                                inputIsCorrect = true;
                                lockOL = 1;
                                lockOLX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }

                        if (input == "ML")
                        {
                            if (lockML == 0)
                            {
                                fieldML1 = playerEdge;
                                fieldML2 = playerMiddle;
                                fieldML3 = playerMiddle;
                                fieldML4 = playerEdge;
                                inputIsCorrect = true;
                                lockML = 1;
                                lockMLX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UL")
                        {
                            if (lockUL == 0)
                            {
                                fieldUL1 = playerEdge;
                                fieldUL2 = playerMiddle;
                                fieldUL3 = playerMiddle;
                                fieldUL4 = playerEdge;
                                inputIsCorrect = true;
                                lockUL = 1;
                                lockULX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "OM")
                        {
                            if (lockOM == 0)
                            {
                                fieldOM1 = playerEdge;
                                fieldOM2 = playerMiddle;
                                fieldOM3 = playerMiddle;
                                fieldOM4 = playerEdge;
                                inputIsCorrect = true;
                                lockOM = 1;
                                lockOMX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "MM")
                        {
                            if (lockMM == 0)
                            {
                                fieldMM1 = playerEdge;
                                fieldMM2 = playerMiddle;
                                fieldMM3 = playerMiddle;
                                fieldMM4 = playerEdge;
                                inputIsCorrect = true;
                                lockMM = 1;
                                lockMMX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UM")
                        {
                            if (lockUM == 0)
                            {
                                fieldUM1 = playerEdge;
                                fieldUM2 = playerMiddle;
                                fieldUM3 = playerMiddle;
                                fieldUM4 = playerEdge;
                                inputIsCorrect = true;
                                lockUM = 1;
                                lockUMX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "OR")
                        {
                            if (lockOR == 0)
                            {
                                fieldOR1 = playerEdge;
                                fieldOR2 = playerMiddle;
                                fieldOR3 = playerMiddle;
                                fieldOR4 = playerEdge;
                                inputIsCorrect = true;
                                lockOR = 1;
                                lockORX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "MR")
                        {
                            if (lockMR == 0)
                            {
                                fieldMR1 = playerEdge;
                                fieldMR2 = playerMiddle;
                                fieldMR3 = playerMiddle;
                                fieldMR4 = playerEdge;
                                inputIsCorrect = true;
                                lockMR = 1;
                                lockMRX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UR")
                        {
                            if (lockUR == 0)
                            {
                                fieldUR1 = playerEdge;
                                fieldUR2 = playerMiddle;
                                fieldUR3 = playerMiddle;
                                fieldUR4 = playerEdge;
                                inputIsCorrect = true;
                                lockUR = 1;
                                lockURX = 1;
                            }




                            //ABOVE   IS  X   PLAYER CONTROLLER
                            //UNDERNEATH IS Y PLAYER CONTROLLER









                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                    }
                    if (nextPlayer % 2 != 0)
                    {
                        if (input == "OL")
                        {
                            if (lockOL == 0)
                            {
                                fieldOL1 = playerMiddle;
                                fieldOL2 = playerEdge;
                                fieldOL3 = playerEdge;
                                fieldOL4 = playerMiddle;
                                inputIsCorrect = true;
                                lockOL = 1;
                                lockOLX = 1;
                            }
                        }
                        if (lockOL == 1)
                        {
                            playerCheck--;//Damit wieder der Gleiche Spieler dran ist...
                            Console.WriteLine(errorFieldIsAlreadyUsed);
                        }
                        if (input == "ML")
                        {
                            if (lockML == 0)
                            {
                                fieldML1 = playerMiddle;
                                fieldML2 = playerEdge;
                                fieldML3 = playerEdge;
                                fieldML4 = playerMiddle;
                                inputIsCorrect = true;
                                lockML = 1;
                                lockMLX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UL")
                        {
                            if (lockUL == 0)
                            {
                                fieldUL1 = playerMiddle;
                                fieldUL2 = playerEdge;
                                fieldUL3 = playerEdge;
                                fieldUL4 = playerMiddle;
                                inputIsCorrect = true;
                                lockUL = 1;
                                lockULX = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "OM")
                        {
                            if (lockOM == 0)
                            {
                                fieldOM1 = playerMiddle;
                                fieldOM2 = playerEdge;
                                fieldOM3 = playerEdge;
                                fieldOM4 = playerMiddle;
                                inputIsCorrect = true;
                                lockOM = 1;
                                lockOMY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "MM")
                        {
                            if (lockMM == 0)
                            {
                                fieldMM1 = playerMiddle;
                                fieldMM2 = playerEdge;
                                fieldMM3 = playerEdge;
                                fieldMM4 = playerMiddle;
                                inputIsCorrect = true;
                                lockMM = 1;
                                lockMMY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UM")
                        {
                            if (lockUM == 0)
                            {
                                fieldUM1 = playerMiddle;
                                fieldUM2 = playerEdge;
                                fieldUM3 = playerEdge;
                                fieldUM4 = playerMiddle;
                                inputIsCorrect = true;
                                lockUM = 1;
                                lockUMY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "OR")
                        {
                            if (lockOR == 0)
                            {
                                fieldOR1 = playerMiddle;
                                fieldOR2 = playerEdge;
                                fieldOR3 = playerEdge;
                                fieldOR4 = playerMiddle;
                                inputIsCorrect = true;
                                lockOR = 1;
                                lockORY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "MR")
                        {
                            if (lockMR == 0)
                            {
                                fieldMR1 = playerMiddle;
                                fieldMR2 = playerEdge;
                                fieldMR3 = playerEdge;
                                fieldMR4 = playerMiddle;
                                inputIsCorrect = true;
                                lockMR = 1;
                                lockMRY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                        if (input == "UR")
                        {
                            if (lockUR == 0)
                            {
                                fieldUR1 = playerMiddle;
                                fieldUR2 = playerEdge;
                                fieldUR3 = playerEdge;
                                fieldUR4 = playerMiddle;
                                inputIsCorrect = true;
                                lockUR = 1;
                                lockURY = 1;
                            }
                            else
                            {
                                playerCheck--; //Damit wieder der Gleiche Spieler dran ist...
                                Console.WriteLine(errorFieldIsAlreadyUsed);
                            }
                        }
                    }
                }
                /*bool xWins1 = (lockOLX == 1 && lockOMX == 1 && lockORX == 1);
                bool xWins2 = (lockOLX == 1 && lockMLX == 1 && lockULX == 1);
                bool xWins3 = (lockOMX == 1 && lockMMX == 1 && lockUMX == 1);
                bool xWins4 = (lockORX == 1 && lockMRX == 1 && lockURX == 1);
                bool xWins5 = (lockMLX == 1 && lockMMX == 1 && lockMRX == 1);
                bool xWins6 = (lockULX == 1 && lockUMX == 1 && lockURX == 1);
                bool xWins7 = (lockULX == 1 && lockMMX == 1 && lockORX == 1);
                bool xWins8 = (lockOLX == 1 && lockMMX == 1 && lockURX == 1);

                bool YWins1 = (lockOLY == 1 && lockOMY == 1 && lockORY == 1);
                bool YWins2 = (lockOLY == 1 && lockMLY == 1 && lockULY == 1);
                bool YWins3 = (lockOMY == 1 && lockMMY == 1 && lockUMY == 1);
                bool YWins4 = (lockORY == 1 && lockMRY == 1 && lockURY == 1);
                bool YWins5 = (lockMLY == 1 && lockMMY == 1 && lockMRY == 1);
                bool YWins6 = (lockULY == 1 && lockUMY == 1 && lockURY == 1);
                bool YWins7 = (lockULY == 1 && lockMMY == 1 && lockORY == 1);
                bool YWins8 = (lockOLY == 1 && lockMMY == 1 && lockURY == 1);


                if (xWins1 || xWins2 || xWins3 || xWins4 || xWins5 || xWins6 || xWins7 || xWins8)
                {
                    Console.WriteLine("Spieler X hat Gewonnen");
                    gameOver--;
                    Console.ReadLine();

                }
                if (YWins1 || YWins2 || YWins3 || YWins4 || YWins5 || YWins6 || YWins7 || YWins8)
                {
                    Console.WriteLine("Spieler Y hat Gewonnen");
                    gameOver--;
                    Console.ReadLine();

                }*/
                inputIsCorrect = false;
            }
        }
    }
}


