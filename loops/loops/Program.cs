﻿using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,
                j = 0,
                count = 0;
            string lines =  
                    "          _____                    _____                    _____            _____           _______                     ." +
                    "         /\\    \\                  /\\    \\                  /\\    \\          /\\    \\         /::\\    \\                    ." +
                    "        /::\\____\\                /::\\    \\                /::\\____\\        /::\\____\\       /::::\\    \\                   ." +
                    "       /:::/    /               /::::\\    \\              /:::/    /       /:::/    /      /::::::\\    \\                  ." +
                    "      /:::/    /               /::::::\\    \\            /:::/    /       /:::/    /      /::::::::\\    \\                 ." +
                    "     /:::/    /               /:::/\\:::\\    \\          /:::/    /       /:::/    /      /:::/~~\\:::\\    \\                ." +
                    "    /:::/____/               /:::/__\\:::\\    \\        /:::/    /       /:::/    /      /:::/    \\:::\\    \\               ." +
                    "   /::::\\    \\              /::::\\   \\:::\\    \\      /:::/    /       /:::/    /      /:::/    / \\:::\\    \\              ." +
                    "  /::::::\\    \\   _____    /::::::\\   \\:::\\    \\    /:::/    /       /:::/    /      /:::/____/   \\:::\\____\\             ." +
                    " /:::/\\:::\\    \\ /\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/    /       /:::/    /      |:::|    |     |:::|    |            ." +
                    "/:::/  \\:::\\    /::\\____\\/:::/__\\:::\\   \\:::\\____\\/:::/____/       /:::/____/       |:::|____|     |:::|    |            ." +
                    "\\::/    \\:::\\  /:::/    /\\:::\\   \\:::\\   \\::/    /\\:::\\    \\       \\:::\\    \\        \\:::\\    \\   /:::/    /             ." +
                    " \\/____/ \\:::\\/:::/    /  \\:::\\   \\:::\\   \\/____/  \\:::\\    \\       \\:::\\    \\        \\:::\\    \\ /:::/    /              ." +
                    "          \\::::::/    /    \\:::\\   \\:::\\    \\       \\:::\\    \\       \\:::\\    \\        \\:::\\    /:::/    /               ." +
                    "           \\::::/    /      \\:::\\   \\:::\\____\\       \\:::\\    \\       \\:::\\    \\        \\:::\\__/:::/    /                ." +
                    "           /:::/    /        \\:::\\   \\::/    /        \\:::\\    \\       \\:::\\    \\        \\::::::::/    /                 ." +
                    "          /:::/    /          \\:::\\   \\/____/          \\:::\\    \\       \\:::\\    \\        \\::::::/    /                  ." +
                    "         /:::/    /            \\:::\\    \\               \\:::\\    \\       \\:::\\    \\        \\::::/    /                   ." +
                    "        /:::/    /              \\:::\\____\\               \\:::\\____\\       \\:::\\____\\        \\::/____/                    ." +
                    "        \\::/    /                \\::/    /                \\::/    /        \\::/    /         ~~                          ." +
                    "         \\/____/                  \\/____/                  \\/____/          \\/____/                                      ." +
                    "                                                                                                                         ." +
                    "      _____                    _____                    _____                    _____                    _____          ." +
                    "     /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\         ." +
                    "    /::\\    \\                /::\\____\\                /::\\    \\                /::\\    \\                /::\\    \\        ." +
                    "    \\:::\\    \\              /:::/    /               /::::\\    \\              /::::\\    \\              /::::\\    \\       ." +
                    "     \\:::\\    \\            /:::/    /               /::::::\\    \\            /::::::\\    \\            /::::::\\    \\      ." +
                    "      \\:::\\    \\          /:::/    /               /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\     ." +
                    "       \\:::\\    \\        /:::/____/               /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\    ." +
                    "       /::::\\    \\      /::::\\    \\              /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\   ." +
                    "      /::::::\\    \\    /::::::\\    \\   _____    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\  ." +
                    "     /:::/\\:::\\    \\  /:::/\\:::\\    \\ /\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/\\:::\\   \\:::\\____\\  /:::/\\:::\\   \\:::\\    \\ ." +
                    "    /:::/  \\:::\\____\\/:::/  \\:::\\    /::\\____\\/:::/__\\:::\\   \\:::\\____\\/:::/  \\:::\\   \\:::|    |/:::/__\\:::\\   \\:::\\____\\." +
                    "   /:::/    \\::/    /\\::/    \\:::\\  /:::/    /\\:::\\   \\:::\\   \\::/    /\\::/   |::::\\  /:::|____|\\:::\\   \\:::\\   \\::/    /." +
                    "  /:::/    / \\/____/  \\/____/ \\:::\\/:::/    /  \\:::\\   \\:::\\   \\/____/  \\/____|:::::\\/:::/    /  \\:::\\   \\:::\\   \\/____/ ." +
                    " /:::/    /                    \\::::::/    /    \\:::\\   \\:::\\    \\            |:::::::::/    /    \\:::\\   \\:::\\    \\     ." +
                    "/:::/    /                      \\::::/    /      \\:::\\   \\:::\\____\\           |::|\\::::/    /      \\:::\\   \\:::\\____\\    ." +
                    "\\::/    /                       /:::/    /        \\:::\\   \\::/    /           |::| \\::/____/        \\:::\\   \\::/    /    ." +
                    " \\/____/                       /:::/    /          \\:::\\   \\/____/            |::|  ~|               \\:::\\   \\/____/     ." +
                    "                              /:::/    /            \\:::\\    \\                |::|   |                \\:::\\    \\         ." +
                    "                             /:::/    /              \\:::\\____\\               \\::|   |                 \\:::\\____\\        ." +
                    "                             \\::/    /                \\::/    /                \\:|   |                  \\::/    /        ." +
                    "                              \\/____/                  \\/____/                  \\|___|                   \\/____/         ." +
                    "                                                                                                                         .";// 44 x 114
            //char[] asciiArt = new char[lines.Length];
            
            char[] asciiArt = lines.ToCharArray();


            while(j < 45) {
                while (i < 115)
                {

                    Console.Write(asciiArt[count]);
                    i++;
                    count++;
                }
                Console.Write("\n");
                j++;
            }
        }
    }
}
