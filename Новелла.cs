using System;

class AdventureNovel
{
    static void Main()
    {
        bool hasKey = false;
        bool hasMap = false;
        bool hasAmulet = false;
        int step = 1;

        Console.WriteLine("Вы просыпаетесь в старинном замке. Перед вами три двери. Что будете делать?");
        Console.WriteLine("1 — Проверить левую дверь");
        Console.WriteLine("2 — Проверить среднюю дверь");
        Console.WriteLine("3 — Проверить правую дверь");

        while (step <= 20)
        {
            Console.Write($"\nШаг {step}. Ваш выбор (1-3): ");
            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }

            switch (step)
            {
                case 1:
                    if (choice == 1)
                    {
                        Console.WriteLine("Дверь заперта. Вы замечаете ключ под ковриком!");
                        hasKey = true;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("За дверью тёмный коридор. Вы слышите шорох...");
                    }
                    else
                    {
                        Console.WriteLine("Дверь не открывается. Похоже, нужна сила.");
                    }
                    break;

                case 2:
                    if (choice == 1 && hasKey)
                    {
                        Console.WriteLine("Вы открываете дверь ключом! Внутри лежит старинная карта.");
                        hasMap = true;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Вы идёте по коридору и находите амулет на алтаре.");
                        hasAmulet = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы пытаетесь выломать дверь, но безуспешно.");
                    }
                    break;

                case 3:
                    if (hasMap && choice == 1)
                    {
                        Console.WriteLine("Карта показывает тайный проход за левой дверью!");
                    }
                    else if (hasAmulet && choice == 2)
                    {
                        Console.WriteLine("Амулет светится в темноте, освещая путь.");
                    }
                    else
                    {
                        Console.WriteLine("Ничего особенного происходит.");
                    }
                    break;

                // Остальные шаги (4–20) — упрощённые варианты
                default:
                    if (choice == 1) Console.WriteLine("Вы исследуете левую часть комнаты.");
                    else if (choice == 2) Console.WriteLine("Вы осматриваете центр помещения.");
                    else Console.WriteLine("Вы подходите к правой стене.");
                    break;
            }

            step++;
        }

        // Определение концовки на основе собранных предметов
        Console.WriteLine("\n*** Финал ***");

        if (hasKey && hasMap && hasAmulet)
        {
            Console.WriteLine("Собрав все артефакты, вы раскрываете тайну замка и находите сокровище!");
            Console.WriteLine("Концовка: Триумф исследователя.");
        }
        else if (hasKey && hasMap)
        {
            Console.WriteLine("С картой и ключом вы находите выход, но тайна замка остаётся неразгаданной.");
            Console.WriteLine("Концовка: Побег с частичным знанием.");
        }
        else if (hasKey && hasAmulet)
        {
            Console.WriteLine("Амулет защищает вас, но без карты вы блуждаете в лабиринте.");
            Console.WriteLine("Концовка: Вечное странствие.");
        }
        else if (hasMap && hasAmulet)
        {
            Console.WriteLine("С картой и амулетом вы находите древний алтарь, но не можете его активировать.");
            Console.WriteLine("Концовка: Неполная разгадка.");
        }
        else if (hasKey)
        {
            Console.WriteLine("У вас есть ключ, но без других предметов тайна остаётся скрытой.");
            Console.WriteLine("Концовка: Начало пути.");
        }
        else if (hasMap)
        {
            Console.WriteLine("Карта у вас, но без ключа и амулета вы не можете продвинуться дальше.");
            Console.WriteLine("Концовка: Загадка без решения.");
        }
        else if (hasAmulet)
        {
            Console.WriteLine("Амулет греет вашу руку, но его сила остаётся тайной.");
            Console.WriteLine("Концовка: Спящая магия.");
        }
        else
        {
            Console.WriteLine("Вы не нашли ничего полезного. Замок поглощает вас во тьме.");
            Console.WriteLine("Концовка: Потерянный странник.");
        }

        Console.WriteLine("Спасибо за игру!");
    }
}
