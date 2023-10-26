using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person semen = new Person("Семен", "Генеральный директор", null);

            Person rashid = new Person("Рашид", "Финансовый директор", semen);

            Person ilham = new Person("О Ильхам", "Директор по автоматизации", semen);

            Person lukas = new Person("Лукас", "Бог Бухгалтерии", rashid);

            Person orkadiy = new Person("Оркадий", "Начальник инф систем", ilham);
            Person volodya = new Person("Володя", "Зам начальника инф систем", ilham);

            Person ilshat = new Person("Ильшат", "Главный системщик", orkadiy);

            Person ivanych = new Person("Иванич", "Зам системщика", ilshat);

            Person ilya = new Person("Илья", "Системный раб", ilshat);
            Person vity = new Person("Витя", "Системный раб", ilshat);
            Person zhenya = new Person("Женя", "Системный раб", ilshat);

            Person sergey = new Person("Сергей", "Главный Разработчик", ilham);

            Person lyasan = new Person("Ляйсан", "Зам Главного разработка", sergey);
            Person marat = new Person("Марат", "Разработка", lyasan);
            Person dina = new Person("Дина", "Раз раб", lyasan);
            Person ildar = new Person("Ильдар", "Раз раб", lyasan);
            Person anton = new Person("Антон", "Раз раб", lyasan);


            List<Exercise> tasks = new List<Exercise>();
            tasks.Add(new Exercise("Написать код для студента ПМ", semen, anton, ExerciseType.Development));
            tasks.Add(new Exercise("Наладить сервера", orkadiy, vity, ExerciseType.System));
            tasks.Add(new Exercise("Помыть полы", marat, semen, ExerciseType.Boss));


            foreach (Exercise task in tasks)
            {


                if (task.Executor.CanDoTask(task))
                {


                    Console.WriteLine(task.Assigner.Name + " поставил задачу " + task.Name + " рабочему " + task.Executor.Name);
                }
                else
                {


                    Console.WriteLine(task.Assigner.Name + " поставил задачу " + task.Name + " рабочему " + task.Executor.Name + ", но он не на того напал");
                }
            }
        }
    }
}


