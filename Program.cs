using System.Numerics;
using System.Xml.Linq;

namespace Chracter
{
    internal class Program
    {
        class Chracter
        {
            public int level;
            private int HP = 100;
            public int speed;
            public int attackPoint;
            public int takeDamage;
            public void moveFront()
            {
                Console.WriteLine("전진하였습니다.");
            }
            public void moveBack()
            {
                Console.WriteLine("후진하였습니다.");
            }
            public void turnLeft()
            {
                Console.WriteLine("좌회전 했습니다.");
            }
            public void turnRight()
            {
                Console.WriteLine("우회전 했습니다.");
            }

            public void TakeDamage(int damage)
            {
                Console.WriteLine($"플레이어가 데미지 {damage}를 받는다.");
                HP -= damage;
                Console.WriteLine($"플레이어의 체력이 {HP}가 되었다.");


            }
            public void Attack()
            {
                Console.WriteLine($"플레이어가 {attackPoint}공격력으로 공격합니다.");
            }

        }
        static void Main(string[] args)
        {
            Chracter chracter = new Chracter();
            chracter.attackPoint = 20;

            ConsoleKey inputKey = Console.ReadKey(true).Key;

            while (true)
            {
                switch (inputKey)
                {
                    case ConsoleKey.UpArrow:
                        chracter.moveFront();
                        break;
                    case ConsoleKey.DownArrow:
                        chracter.moveBack();
                        break;
                    case ConsoleKey.LeftArrow:
                        chracter.turnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        chracter.turnRight();
                        break;
                    case ConsoleKey.A:
                        chracter.Attack();
                        chracter.TakeDamage(15);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
