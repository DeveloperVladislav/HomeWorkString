using System.Text.RegularExpressions;

namespace HomeWorkString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите текст!");

			string name = "Vlad";

			string? text = Console.ReadLine();

			Console.WriteLine($"Ваш текст - {text}");

			//Конкатенация строк
			string strocaConcat = text + " " + name;
			Console.WriteLine($"(strocaConcat) - {strocaConcat}");

			//С помощью метода Concat
			string strocaConcatMetod = string.Concat(text, " ", name);
			Console.WriteLine($"(strocaConcatMetod) - {strocaConcatMetod}");

			//С помощью метода Join
			string[] arrStroca = new string[] { text, strocaConcat, strocaConcatMetod };
			string strocaJoinMethod = string.Join(" ", arrStroca);
			Console.WriteLine($"(strocaJoinMethod) - {strocaJoinMethod}");

			Console.WriteLine("\n---------------Compare--------------------------");
			//Сравнение строк
			string s1 = "hello";
			string s2 = "world";

			int result = string.Compare(s1, s2);
			if (result < 0)
			{
				Console.WriteLine("Строка s1 перед строкой s2");
			}
			else if (result > 0)
			{
				Console.WriteLine("Строка s1 после строки s2");
			}
			else
			{
				Console.WriteLine("Строки идентичны");
			}


			Console.WriteLine("\n---------------IndexOf--------------------------");
			//Поиск символа по индексу
			char ch = 'o';
			int indexOf = s1.IndexOf(ch);
			Console.WriteLine($"{s1}: '{ch}' = {indexOf} index");


			Console.WriteLine("\n---------------Split--------------------------");

			string text1 = "Разделяю строки методом Split";

			string[] words = text1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Второй параметр StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки.

			foreach (string s in words)
			{
				Console.WriteLine(s);
			}

			Console.WriteLine("\n---------------Trim и Substring--------------------------");
			text1 = text1.Trim();
			Console.WriteLine(text1);
			text1 = text1.Trim(new char[] { 'Р', 't' });//обрезка начального и конечного символа
			Console.WriteLine(text1);

			text1 = text1.Substring(6);
			Console.WriteLine($"Substring - {text1}");

			Console.WriteLine("\n---------------Insert--------------------------");

			string substring = " Vlad";
			s1 = s1.Insert(5, substring);
			Console.WriteLine(s1);


			Console.WriteLine("\n---------------Remove--------------------------");
			//Удалить часть строки
			s1 = s1.Remove(0, 3);
			Console.WriteLine(s1);

			Console.WriteLine("\n---------------Replace--------------------------");
			//Замена строки
			string example = "easy example";
			Console.WriteLine(example);
			example = example.Replace("easy", "bad");
			Console.WriteLine(example);

			Console.WriteLine("\n---------------ToUpper() и ToLower()--------------------------");
			//Смена регистра

			example = example.ToUpper();
			Console.WriteLine(example);
			example = example.ToLower();
			Console.WriteLine(example);

			Console.WriteLine("\n----------------Regex-------------------------");

			//Проверка на валидность телефонного номера (Россия, Беларусь)
			string pattern = @"(\+7|8|7)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}|(\+375|375)?[\s\-]?\(?(29|33|44)\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}";

			Console.WriteLine("Введите номер телефона:");
			string phoneNumber = Console.ReadLine();


			if (Regex.IsMatch(phoneNumber, pattern))
			{
				Console.WriteLine("Номер телефона валидный");
			}
			else
			{
				Console.WriteLine("Номер телефона не валидный");
			}

			Console.WriteLine("\n----------------DateTime-------------------------");

			Console.WriteLine(DateTime.Now);//текущая дата и время компьютера
			Console.WriteLine(DateTime.UtcNow);//время по гринвичу
			Console.WriteLine(DateTime.Today);//только текущая дата
			Console.WriteLine($"s: {DateTime.Now:s}");////дата в классическом формате
			Console.WriteLine(DateTime.Now.ToString("yyyy.dd.MM"));//дата в классическом формате

		}
		
	}
}