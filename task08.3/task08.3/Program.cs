using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08._3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите позицию белой ладьи:");
                string whiteRookPosition = Console.ReadLine();
                Console.WriteLine("Введите позицию черного коня:");
                string blackKnightPosition = Console.ReadLine();

                if (whiteRookPosition == blackKnightPosition)
                {
                    Console.WriteLine("Фигуры не могут стоять на одной клетке");
                    return;
                }

                int whiteRookV, whiteRookH;
                int blackKnightV, blackKnightH;

                DecodePosition(whiteRookPosition, out whiteRookV, out whiteRookH);
                DecodePosition(blackKnightPosition, out blackKnightV, out blackKnightH);

            if (whiteRookH < 1 || whiteRookH > 8 || whiteRookV < 1 || whiteRookV > 8 ||
               blackKnightH < 1 || blackKnightH > 8 || blackKnightV < 1 || blackKnightV > 8)
            {
                Console.WriteLine("Координаты фигур выходят за пределы шахматной доски!");
                return;
            }

            if (IsUnderAttackByWhiteRook(blackKnightPosition, whiteRookPosition))
                Console.WriteLine("Ладья бьет коня");
            else if (IsUnderAttackByBlackKnight(whiteRookPosition, blackKnightPosition))
                Console.WriteLine("Конь бьет ладью");
            else
                Console.WriteLine("Фигуры не бьют друг друга");
        }

        static void DecodePosition(string position, out int vert, out int hor)

        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }

        static bool IsUnderAttackByWhiteRook(string blackKnightPosition, string whiteRookPostition)
        {
            int bkV, bkH, wrV, wrH;

            DecodePosition(blackKnightPosition, out bkV, out bkH);
            DecodePosition(whiteRookPostition, out wrV, out wrH);

            return bkV == wrV || bkH == wrH;
        }

        static bool IsUnderAttackByBlackKnight(string whiteRookPostition, string blackKnightPosition)
        {
            int wrV, wrH;
            int bkV, bkH;

            DecodePosition(whiteRookPostition, out wrV, out wrH);
            DecodePosition(blackKnightPosition, out bkV, out bkH);

            int verticalDiff = Math.Abs(wrV - bkV);
            int horizontalDiff = Math.Abs(wrH - bkH);

            return (verticalDiff == 1 && horizontalDiff == 2) || (verticalDiff == 2 && horizontalDiff == 1);
        }
    }
}