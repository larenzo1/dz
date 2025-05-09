using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace новелла
{
    internal class Новелла
    {
        static void Main(string[] args)
        {
            int currentStep = 1; 
            bool gameOver = false;

            Console.WriteLine("Добро пожаловать в интерактивную новеллу!");
            Console.WriteLine("Ваши решения определят вашу судьбу.");
            Console.WriteLine("Нажмите Enter, чтобы начать.");
            Console.ReadLine();

            while (!gameOver)
            {
                switch (currentStep)
                {
                    case 1: 
                        Console.WriteLine("\nВы просыпаетесь в незнакомой комнате. Голова болит, и вы ничего не помните. Видите два выхода: дверь направо и дверь налево.");
                        Console.WriteLine("1. Пойти в дверь направо.");
                        Console.WriteLine("2. Пойти в дверь налево.");
                        string choice1 = Console.ReadLine();

                        if (choice1 == "1")
                        {
                            currentStep = 2;
                        }
                        else if (choice1 == "2")
                        {
                            currentStep = 3;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы остаетесь на месте.");
                        }
                        break;

                    case 2: 
                        Console.WriteLine("\nВы оказываетесь в комнате, где на стене висит загадка: 'Я всегда иду, но никогда не двигаюсь. Я всегда настоящее, но скоро стану прошлым. Кто я?'");
                        Console.WriteLine("1. Ответить: Время.");
                        Console.WriteLine("2. Попытаться открыть запертую дверь в другой конец комнаты.");
                        string choice2 = Console.ReadLine();

                        if (choice2 == "1")
                        {
                            Console.WriteLine("Загадка решена! Открывается потайной проход.");
                            currentStep = 4;
                        }
                        else if (choice2 == "2")
                        {
                            Console.WriteLine("Вы тратите много времени, пытаясь открыть дверь, но безуспешно. Возвращаетесь к загадке.");
                            currentStep = 2;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы остаетесь в комнате.");
                            currentStep = 2;
                        }
                        break;

                    case 3: 
                        Console.WriteLine("\nВы входите в темный коридор. Слышите шорох.");
                        Console.WriteLine("1. Продолжить идти вперед.");
                        Console.WriteLine("2. Вернуться обратно в первую комнату.");
                        string choice3 = Console.ReadLine();

                        if (choice3 == "1")
                        {
                            currentStep = 5;
                        }
                        else if (choice3 == "2")
                        {
                            currentStep = 1;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы замираете от страха.");
                            currentStep = 3;
                        }
                        break;

                    case 4: 
                        Console.WriteLine("\nВы проходите через потайной проход и оказываетесь в комнате с множеством старинных книг.");
                        Console.WriteLine("1. Прочитать одну из книг.");
                        Console.WriteLine("2. Искать выход.");
                        string choice4 = Console.ReadLine();

                        if (choice4 == "1")
                        {
                            Console.WriteLine("Вы читаете книгу и узнаете о проклятии этого места. Вы понимаете, как выбраться.");
                            currentStep = 7;
                        }
                        else if (choice4 == "2")
                        {
                            Console.WriteLine("Вы не находите выхода и блуждаете по комнате в поисках выхода. В итоге выходите обратно в комнату с загадкой.");
                            currentStep = 2;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы рассматриваете полки с книгами.");
                            currentStep = 4;
                        }
                        break;

                    case 5: 
                        Console.WriteLine("\nВ коридоре на вас нападает странное существо!");
                        Console.WriteLine("1. Попытаться убежать.");
                        Console.WriteLine("2. Попытаться сразиться с ним.");
                        string choice5 = Console.ReadLine();

                        if (choice5 == "1")
                        {
                            Console.WriteLine("Вы убегаете, но существо преследует вас. Вы запираетесь в комнате.");
                            currentStep = 3;
                        }
                        else if (choice5 == "2")
                        {
                            Console.WriteLine("Вы вступаете в бой, но проигрываете...");
                            currentStep = 11; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Существо нападает.");
                            currentStep = 11; 
                            gameOver = true;
                        }
                        break;

                    case 6: 
                        Console.WriteLine("\nВы попадаете в комнату с тремя рычагами. Какой из них потянуть?");
                        Console.WriteLine("1. Потянуть первый рычаг.");
                        Console.WriteLine("2. Потянуть второй рычаг.");
                        Console.WriteLine("3. Потянуть третий рычаг.");
                        string choice6 = Console.ReadLine();

                        if (choice6 == "1")
                        {
                            Console.WriteLine("Потянув первый рычаг, вы открываете дверь в следующий зал.");
                            currentStep = 8;
                        }
                        else if (choice6 == "2")
                        {
                            Console.WriteLine("Потянув второй рычаг, вы активируете ловушку!");
                            currentStep = 12; 
                            gameOver = true;
                        }
                        else if (choice6 == "3")
                        {
                            Console.WriteLine("Потянув третий рычаг, ничего не происходит. Вы решаете попробовать первый.");
                            currentStep = 8;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод.  Вы стоите в нерешительности.");
                            currentStep = 6;
                        }
                        break;

                    case 7: 
                        Console.WriteLine("\nСледуя подсказкам из книги, вы находите секретный механизм.");
                        Console.WriteLine("1. Активировать механизм.");
                        Console.WriteLine("2. Попытаться найти другой выход.");
                        string choice7 = Console.ReadLine();

                        if (choice7 == "1")
                        {
                            Console.WriteLine("Вы активируете механизм, и открывается потайная дверь, ведущая на свободу!");
                            currentStep = 9; 
                            gameOver = true;
                        }
                        else if (choice7 == "2")
                        {
                            Console.WriteLine("Вы ищете другой выход, но натыкаетесь на завалы. Вы заперты.");
                            currentStep = 13; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы изучаете механизм.");
                            currentStep = 7;
                        }
                        break;

                    case 8: 
                        Console.WriteLine("\nВы попадаете в комнату, полную золота и драгоценностей!");
                        Console.WriteLine("1. Взять золото и бежать.");
                        Console.WriteLine("2. Поискать что-нибудь более ценное.");
                        string choice8 = Console.ReadLine();

                        if (choice8 == "1")
                        {
                            Console.WriteLine("Вы хватаете золото и бежите. За вами начинается погоня, но вам удается скрыться!");
                            currentStep = 10; 
                            gameOver = true;
                        }
                        else if (choice8 == "2")
                        {
                            Console.WriteLine("Вы ищете что-то более ценное и находите древний амулет. Как только вы его берете, комната начинает рушиться!");
                            currentStep = 14; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы любуетесь сокровищами.");
                            currentStep = 8;
                        }
                        break;

                    

                    case 9: 
                        Console.WriteLine("\nВы выбрались на свободу! Вы спасены!");
                        Console.WriteLine("Поздравляем, вы прошли игру!");
                        gameOver = true;
                        break;

                    case 10: 
                        Console.WriteLine("\nВы сбежали с золотом и остались в живых! Богатый и свободный!");
                        Console.WriteLine("Поздравляем, вы прошли игру!");
                        gameOver = true;
                        break;

                    case 11: 
                        Console.WriteLine("\nВы проиграли битву и погибли.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 12: 
                        Console.WriteLine("\nЛовушка убила вас мгновенно.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;
                    case 13: 
                        Console.WriteLine("\nВы заперты в подземелье навечно.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 14: 
                        Console.WriteLine("\nПодземелье обрушилось, и вы погибли под обломками.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 15:  
                        Console.WriteLine("\nВ одной из комнат вы натыкаетесь на старого мудреца. Он может помочь вам выбраться, но за это просит у вас плату.");
                        Console.WriteLine("1. Отдать ему все свое золото.");
                        Console.WriteLine("2. Попытаться обмануть его.");
                        Console.WriteLine("3. Отказаться от помощи и поискать другой путь.");
                        string choice9 = Console.ReadLine();

                        if (choice9 == "1")
                        {
                            Console.WriteLine("Вы отдали мудрецу все свое золото, и он указал вам секретный выход. Вы выбрались на свободу, но бедны.");
                            currentStep = 16; 
                            gameOver = true;
                        }
                        else if (choice9 == "2")
                        {
                            Console.WriteLine("Вы попытались обмануть мудреца, но он разгадал ваш план и проклял вас!");
                            currentStep = 17; 
                            gameOver = true;
                        }
                        else if (choice9 == "3")
                        {
                            currentStep = 18;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Мудрец смотрит на вас с подозрением.");
                            currentStep = 15;
                        }
                        break;
                    case 16: 
                        Console.WriteLine("\nВы выбрались на свободу, но остались без гроша в кармане.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 17: 
                        Console.WriteLine("\nМудрец проклял вас, и вы медленно угасаете.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 18: 
                        Console.WriteLine("\nВы попадаете в сложный лабиринт.");
                        Console.WriteLine("1. Пойти направо.");
                        Console.WriteLine("2. Пойти налево.");
                        Console.WriteLine("3. Идти прямо.");
                        string choice10 = Console.ReadLine();

                        if (choice10 == "1")
                        {
                            currentStep = 19;
                        }
                        else if (choice10 == "2")
                        {
                            currentStep = 20;
                        }
                        else if (choice10 == "3")
                        {
                            currentStep = 6; 
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы стоите на месте, чувствуя себя потерянным.");
                            currentStep = 18;
                        }
                        break;

                    case 19: 
                        Console.WriteLine("\nВы зашли в тупик. Придется вернуться назад.");
                        currentStep = 18;
                        break;

                    case 20: 
                        Console.WriteLine("\nВы попадаете в комнату с большим зеркалом. В отражении вы видите себя, но с искаженным лицом.");
                        Console.WriteLine("1. Попытаться разбить зеркало.");
                        Console.WriteLine("2. Пройти сквозь зеркало.");
                        Console.WriteLine("3. Изучить отражение.");
                        string choice11 = Console.ReadLine();

                        if (choice11 == "1")
                        {
                            Console.WriteLine("Разбив зеркало, вы активируете механизм, который открывает потайную дверь.");
                            currentStep = 7; 
                        }
                        else if (choice11 == "2")
                        {
                            Console.WriteLine("Пройдя сквозь зеркало, вы попадаете в параллельный мир, где все иначе, но выход не находится.");
                            currentStep = 18; 
                        }
                        else if (choice11 == "3")
                        {
                            Console.WriteLine("Вы внимательно изучаете отражение и понимаете, что искажение указывает на место, где спрятан ключ.");
                            currentStep = 21;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы смотрите на свое отражение, чувствуя беспокойство.");
                            currentStep = 20;
                        }
                        break;

                    case 21: 
                        Console.WriteLine("\nВы нашли ключ, спрятанный за картиной.  Что вы откроете этим ключом?");
                        Console.WriteLine("1. Дверь в конце лабиринта (Шаг 18).");
                        Console.WriteLine("2. Сундук в комнате с золотом (Шаг 8).");
                        string choice12 = Console.ReadLine();

                        if (choice12 == "1")
                        {
                            Console.WriteLine("Вы открыли дверь в конце лабиринта и оказались на свободе!");
                            currentStep = 22; 
                            gameOver = true;
                        }
                        else if (choice12 == "2")
                        {
                            Console.WriteLine("Вы открыли сундук, и оттуда вырвался злой дух. Он поглотил вас.");
                            currentStep = 23; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы держите ключ в руке, не зная, что с ним делать.");
                            currentStep = 21;
                        }
                        break;

                    case 22: 
                        Console.WriteLine("\nВы благополучно покинули лабиринт и выбрались на свободу. Поздравляем!");
                        gameOver = true;
                        break;

                    case 23: 
                        Console.WriteLine("\nЗлой дух поглотил вас. Ваша душа потеряна навеки.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    

                    case 24:  
                        Console.WriteLine("\nВы заходите в комнату, полностью покрытую паутиной. Пауки ползают повсюду.");
                        Console.WriteLine("1. Пробраться через паутину.");
                        Console.WriteLine("2. Попытаться обойти комнату стороной.");
                        string choice13 = Console.ReadLine();

                        if (choice13 == "1")
                        {
                            Console.WriteLine("Вы пробираетесь через паутину, но вас кусает ядовитый паук. Вы чувствуете, что вам становится хуже.");
                            currentStep = 25; 
                            gameOver = true;
                        }
                        else if (choice13 == "2")
                        {
                            Console.WriteLine("Вы пытаетесь обойти комнату, но попадаете в ловушку.");
                            currentStep = 26;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы стоите в паутине, охваченные страхом.");
                            currentStep = 24;
                        }
                        break;

                    case 25: 
                        Console.WriteLine("\nЯд паука слишком силен. Вы умираете в мучениях.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 26: 
                        Console.WriteLine("\nВы попали в ловушку. Стены комнаты начинают сдвигаться.");
                        Console.WriteLine("1. Попытаться найти выход.");
                        Console.WriteLine("2. Принять свою судьбу.");

                        string choice14 = Console.ReadLine();

                        if (choice14 == "1")
                        {
                            Console.WriteLine("Вы отчаянно ищете выход и находите скрытую кнопку, которая останавливает стены.");
                            currentStep = 27;
                        }
                        else if (choice14 == "2")
                        {
                            Console.WriteLine("Стены сдвигаются, и вы погибаете, раздавленный.");
                            currentStep = 28; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы в панике.");
                            currentStep = 26;
                        }
                        break;
                    case 27: 
                        Console.WriteLine("\nСтены перестали сдвигаться. Теперь куда?");
                        Console.WriteLine("1. Вернуться в комнату с паутиной.");
                        Console.WriteLine("2. Исследовать дальше.");

                        string choice15 = Console.ReadLine();

                        if (choice15 == "1")
                        {
                            currentStep = 24;
                        }
                        else if (choice15 == "2")
                        {
                            currentStep = 15; 
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы замерли в страхе");
                            currentStep = 27;
                        }
                        break;
                    case 28: 
                        Console.WriteLine("\nВас раздавило стенами. Игра окончена!");
                        gameOver = true;
                        break;

                    case 29: 
                        Console.WriteLine("\nВы находите мерцающий портал. Что вы предпримите?");
                        Console.WriteLine("1. Войти в портал.");
                        Console.WriteLine("2. Поискать другой путь.");
                        string choice16 = Console.ReadLine();

                        if (choice16 == "1")
                        {
                            Console.WriteLine("Вы входите в портал и оказываетесь в раю. Ваша душа нашла покой.");
                            currentStep = 30; 
                            gameOver = true;
                        }
                        else if (choice16 == "2")
                        {
                            Console.WriteLine("Вы решаете не рисковать и продолжаете поиски выхода. Вы натыкаетесь на заваленный проход и погибаете от голода.");
                            currentStep = 31; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы изучаете портал, но не решаетесь войти.");
                            currentStep = 29;
                        }
                        break;

                    case 30: 
                        Console.WriteLine("\nВы попали в рай. Ваша душа обрела вечный покой.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;

                    case 31: 
                        Console.WriteLine("\nВы умерли от голода, не сумев найти выход.");
                        Console.WriteLine("Игра окончена.");
                        gameOver = true;
                        break;
                    case 32: 
                        Console.WriteLine("\nВы находите подземный водопад. Что вы предпримете?");
                        Console.WriteLine("1. Прыгнуть в водопад.");
                        Console.WriteLine("2. Попытаться найти другой путь.");
                        string choice17 = Console.ReadLine();

                        if (choice17 == "1")
                        {
                            Console.WriteLine("Вы прыгаете в водопад и оказываетесь в подземном озере, из которого есть выход на поверхность. Вы спасены!");
                            currentStep = 33; 
                            gameOver = true;
                        }
                        else if (choice17 == "2")
                        {
                            Console.WriteLine("Вы ищете другой путь, но не находите его. Вы возвращаетесь к водопаду, но теряете уверенность и падаете со скалы.");
                            currentStep = 34; 
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Вы разглядываете водопад");
                            currentStep = 32;
                        }
                        break;

                    case 33: 
                        Console.WriteLine("\nВы спасены и выбрались из подземелья через водопад!");
                        gameOver = true;
                        break;
                    case 34: 
                        Console.WriteLine("\nВы потеряли уверенность и упали со скалы! Игра окончена.");
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Что-то пошло не так. Неизвестный шаг.");
                        gameOver = true;
                        break;
                }

                if (gameOver)
                {
                    Console.WriteLine("\nХотите начать заново? (y/n)");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "y")
                    {
                        currentStep = 1;
                        gameOver = false;
                        Console.WriteLine("Новая игра началась!");
                        Console.ReadLine(); 
                    }
                    else
                    {
                        Console.WriteLine("Спасибо за игру!");
                    }
                }
            }
        }
    }
}