using System.Drawing;

public static class Global
{
    public static int LenghtConsole;
    public static int HightConsole;
    public static int Lines = 0;
}

public class Programm
{

    static void Main()
    {
        string TextForTest1 = "Элиас Дисней был глубоко религиозным мрачным человеком и " +
    "сурово относился к воспитанию детей. Его любимой была поговорка: «Пожалеешь розог — " +
    "испортишь ребёнка». Вместе с тем глава семейства по-своему любил семью и сумел привить " +
    "детям свои моральные ценности. Элиас Дисней учил детей быть честными и заботиться о репутации, " +
    "привил любовь к труду, научил преодолевать трудности и сострадать ближнему. Для Уолта эти " +
    "принципы стали главными в жизни. Он перенял лучшие отцовские качества: непоколебимость, " +
    "готовность идти на риск, трудолюбие, честность, любовь к семье. Мать Уолта Диснея, в свою " +
    "очередь, оказала огромное влияние на становление его личности. Она была очень спокойной женщиной " +
    "с выдержанным, но настойчивым характером и замечательным чувством юмора. Лёгкий и весёлый нрав " +
    "Флоры Дисней уравновешивал суровый характер отца семейства. ";
        var TextForTest = TextForTest1.ToArray();
        foreach (char i in TextForTest)
        {
            int Count = 0;
            Console.Write(i);
            Count++;
            if (Count == Console.BufferWidth)
            {
                Console.WriteLine("");
            }
        }
        foreach (char i in TextForTest)
        {
            ConsoleKeyInfo UserButton = Console.ReadKey(true);
            if (UserButton.KeyChar == i)
            {
                if (Global.LenghtConsole == Console.BufferWidth-1)
                {
                    ChekFinishLine("Blue", TextForTest, i);
                }
                else
                {
                    Chek("Blue", TextForTest);
                }
            }
            else
            {
                if (Global.LenghtConsole == Console.BufferWidth-1)
                {
                    ChekFinishLine("Red", TextForTest, i);
                }
                else
                {
                    Chek("Red", TextForTest);
                }
            }
        }
    }
    private static void Chek(string Color, char[] TextForTest)
    {
        Console.SetCursorPosition(Global.LenghtConsole, Global.HightConsole);
        if (Color == "Red")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (Color == "Blue")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

            for (int j = Global.LenghtConsole; j < Console.BufferWidth; j++)
            {
                Console.Write(TextForTest[j + Global.Lines * Console.BufferWidth]);
            }
            Console.SetCursorPosition(Global.LenghtConsole + 1, Global.HightConsole);
            Console.ResetColor();
            for (int x = Global.LenghtConsole + 1; x < Console.BufferWidth; x++)
            {
                Console.Write(TextForTest[x + Global.Lines * Console.BufferWidth]);
            }
            Global.LenghtConsole++;
    }
    private static void ChekFinishLine(string Color, char[] TextForTest, char LastSymbol)
    {
        if (Color == "Red")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (Color == "Blue")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.SetCursorPosition(Console.BufferWidth-1, Global.HightConsole);
        Console.Write(LastSymbol);
        Console.ResetColor();
        Global.HightConsole++;
        Global.Lines++;
        Global.LenghtConsole = 0;
    }
}









