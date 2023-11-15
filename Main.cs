using static RPG_Dashboard.SheetViewer;

namespace RPG_Dashboard
{
    class RPG_Dashboard { 
        static void Main()
        {
            Player player1 = new Player("Vash Gainsborough", "Gunbreaker", 1500, 250, 400);
            Enemy enemy1 = new Enemy("Emet Selch","Boss", 5000, 100, 80);

            PrintCharacter(player1);
            PrintCharacter(enemy1);

            player1.Attack(enemy1);
            player1.Attack(enemy1);
            player1.Attack(enemy1);
        }
    }
}