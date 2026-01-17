using System;
namespace root
{
	class Pro1
	{
		static void Main()
		{
            Console.WriteLine("请输入玩家昵称");
			string playername = Console.ReadLine();
            Console.WriteLine("请输入玩家血量");
			double life=double.Parse(Console.ReadLine());
            Console.WriteLine("请输入玩家防御力");
			double exlife=double.Parse(Console.ReadLine());
			double miss = 50.5;
            Console.WriteLine("请输入怪兽攻击力！");
			double monsterattack=double.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个随机数作为闪避判断（范围1-100仅支持1位小数，否则系统会报错！）");
			double remiss=double.Parse(Console.ReadLine());
			double life1 = life + exlife-monsterattack;
			if (remiss>miss) 
			{
                Console.WriteLine($"{playername}完美闪避！");
			}
			else
			{
				if (life1 <0)
				{
					Console.WriteLine("闪避失败！你死了！");
				}
				else
				{
					if (monsterattack < exlife)
					{
						Console.WriteLine($"闪避失败！剩余血量{life}");
					}
					else
					{
                        Console.WriteLine($"闪避失败！剩余血量{life1}");
					}
				}
                
			}




				Console.ReadKey();

		}

	}

}