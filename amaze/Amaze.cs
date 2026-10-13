// using System

using System.Reflection.Metadata;

public class IOutputable
{
	public static Random RandomSeed { get; set; } = new Random(0);
	
	public enum Output
	{
		Text,
		Pixel
	}
	
	public void Runner(int horizontalOriginal, int verticalOriginal, Output getOutputOption)
	{
		switch (getOutputOption)
		{
			case Output.Text:
				Console.WriteLine("Handling Text output state.");
				break;
			case Output.Pixel:
				Console.WriteLine("Handling Pixel output state.");
				break;
			default:
				throw new ArgumentOutOfRangeException(nameof(getOutputOption), getOutputOption, null);
		}
	}
}

public class Amaze
{
	private static int Target { get; set; } = 0;
	public static string Result = "";

	public static void Main(string[] args)
	{
		Runner(int.Parse(args[0]),int.Parse(args[1]));
		System.Console.WriteLine(Result);
	}

	private static void Clear()
	{
		Result = "";
	}

	private static void Println() 
	{
		Result += "\n";
	}

	private static void Print(string text)
	{
		Result += text;
	}

	private static int Random(int count) 
	{
		return (int) (count * RandomSeed.NextDouble()) + 1;
	}

	private static void GotoLine(int lineNumber) 
	{
		Target = lineNumber;
	}

	public static void Runner(int horizontalOriginal, int verticalOriginal) 
	{
		Clear();
		Print("Amazing - Copyright by Creative Computing, Morristown, NJ");
		Println();

		
		// Set default variable values
		int horizontal = horizontalOriginal;
		int vertical = verticalOriginal;
		if ( horizontal == 1 || vertical == 1) return;

		int[,] widthArray = new int[ horizontal + 1,vertical + 1];
		int[,] verticalArray = new int[ horizontal + 1,vertical + 1];
		
		int q = 0;
		int z = 0;
		int randomInt = Random( horizontal);

		// 130:170
		for (int i = 1; i <=  horizontal; i++) 
		{
			if (i == randomInt)
				Print(":  ");
			else
				Print(":--");
		}
		// 180
		Print(":");
		Println();

		// 190
		int c = 1;
		widthArray[randomInt,1] = c;
		c++;

		// 200
		int r = randomInt;
		int s = 1;
		GotoLine(270);

		while (Target != -1) 
		{
			switch (Target) 
			{
				case 210:
					if (r !=  horizontal)
						GotoLine(250);
					else
						GotoLine(220);
					continue;
				case 220:
					if (s != vertical)
						GotoLine(240);
					else
						GotoLine(230);
					continue;
				case 230:
					r = 1;
					s = 1;
					GotoLine(260);
					continue;
				case 240:
					r = 1;
					s++;
					GotoLine(260);
					continue;
				case 250:
					r++;
					GotoLine(260);
					continue;
				case 260:
					if (widthArray[r,s] == 0)
						GotoLine(210);
					else
						GotoLine(270);
					continue;
				case 270:
					if (r - 1 == 0)
						GotoLine(600);
					else
						GotoLine(280);
					continue;
				case 280:
					if (widthArray[r - 1,s] != 0)
						GotoLine(600);
					else
						GotoLine(290);
					continue;
				case 290:
					if (s - 1 == 0)
						GotoLine(430);
					else
						GotoLine(300);
					continue;
				case 300:
					if (widthArray[r,s - 1] != 0)
						GotoLine(430);
					else
						GotoLine(310);
					continue;
				case 310:
					if (r ==  horizontal)
						GotoLine(350);
					else
						GotoLine(320);
					continue;
				case 320:
					if (widthArray[r + 1,s] != 0)
						GotoLine(350);
					else
						GotoLine(330);
					continue;
				case 330:
					randomInt = Random(3);
					GotoLine(340);
					continue;
				case 340:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(980);
					else if (randomInt == 3)
						GotoLine(1020);
					else
						GotoLine(350);
					continue;
				case 350:
					if (s != vertical)
						GotoLine(380);
					else
						GotoLine(360);
					continue;
				case 360:
					if (z == 1)
						GotoLine(410);
					else
						GotoLine(370);
					continue;
				case 370:
					q = 1;
					GotoLine(390);
					continue;
				case 380:
					if (widthArray[r,s + 1] != 0)
						GotoLine(410);
					else
						GotoLine(390);
					continue;
				case 390:
					randomInt = Random(3);
					GotoLine(400);
					continue;
				case 400:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(980);
					else if (randomInt == 3)
						GotoLine(1090);
					else
						GotoLine(410);
					continue;
				case 410:
					randomInt = Random(2);
					GotoLine(420);
					continue;
				case 420:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(980);
					else
						GotoLine(430);
					continue;
				case 430:
					if (r ==  horizontal)
						GotoLine(530);
					else
						GotoLine(440);
					continue;
				case 440:
					if (widthArray[r + 1,s] != 0)
						GotoLine(530);
					else
						GotoLine(450);
					continue;
				case 450:
					if (s != vertical)
						GotoLine(480);
					else
						GotoLine(460);
					continue;
				case 460:
					if (z == 1)
						GotoLine(510);
					else
						GotoLine(470);
					continue;
				case 470:
					q = 1;
					GotoLine(490);
					continue;
				case 480:
					if (widthArray[r,s + 1] != 0)
						GotoLine(510);
					else
						GotoLine(490);
					continue;
				case 490:
					randomInt = Random(3);
					GotoLine(500);
					continue;
				case 500:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(1020);
					else if (randomInt == 3)
						GotoLine(1090);
					else
						GotoLine(510);
					continue;
				case 510:
					randomInt = Random(2);
					GotoLine(520);
					continue;
				case 520:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(1020);
					else
						GotoLine(530);
					continue;
				case 530:
					if (s != vertical)
						GotoLine(560);
					else
						GotoLine(540);
					continue;
				case 540:
					if (z == 1)
						GotoLine(590);
					else
						GotoLine(550);
					continue;
				case 550:
					q = 1;
					GotoLine(570);
					continue;
				case 560:
					if (widthArray[r,s + 1] != 0)
						GotoLine(590);
					else
						GotoLine(570);
					continue;
				case 570:
					randomInt = Random(2);
					GotoLine(580);
					continue;
				case 580:
					if (randomInt == 1)
						GotoLine(940);
					else if (randomInt == 2)
						GotoLine(1090);
					else
						GotoLine(590);
					continue;
				case 590:
					GotoLine(940);
					continue;
				case 600:
					if (s - 1 == 0)
						GotoLine(790);
					else
						GotoLine(610);
					continue;
				case 610:
					if (widthArray[r,s - 1] != 0)
						GotoLine(790);
					else
						GotoLine(620);
					continue;
				case 620:
					if (r ==  horizontal)
						GotoLine(720);
					else
						GotoLine(630);
					continue;
				case 630:
					if (widthArray[r + 1,s] != 0)
						GotoLine(720);
					else
						GotoLine(640);
					continue;
				case 640:
					if (s != vertical)
						GotoLine(670);
					else
						GotoLine(650);
					continue;
				case 650:
					if (z == 1)
						GotoLine(700);
					else
						GotoLine(660);
					continue;
				case 660:
					q = 1;
					GotoLine(680);
					continue;
				case 670:
					if (widthArray[r,s + 1] != 0)
						GotoLine(700);
					else
						GotoLine(680);
					continue;
				case 680:
					randomInt = Random(3);
					GotoLine(690);
					continue;
				case 690:
					if (randomInt == 1)
						GotoLine(980);
					else if (randomInt == 2)
						GotoLine(1020);
					else if (randomInt == 3)
						GotoLine(1090);
					else
						GotoLine(700);
					continue;
				case 700:
					randomInt = Random(2);
					GotoLine(710);
					continue;
				case 710:
					if (randomInt == 1)
						GotoLine(980);
					else if (randomInt == 2)
						GotoLine(1020);
					else
						GotoLine(720);
					continue;
				case 720:
					if (s != vertical)
						GotoLine(750);
					else
						GotoLine(730);
					continue;
				case 730:
					if (z == 1)
						GotoLine(780);
					else
						GotoLine(740);
					continue;
				case 740:
					q = 1;
					GotoLine(760);
					continue;
				case 750:
					if (widthArray[r,s + 1] != 0)
						GotoLine(780);
					else
						GotoLine(760);
					continue;
				case 760:
					randomInt = Random(2);
					GotoLine(770);
					continue;
				case 770:
					if (randomInt == 1)
						GotoLine(980);
					else if (randomInt == 2)
						GotoLine(1090);
					else
						GotoLine(780);
					continue;
				case 780:
					GotoLine(980);
					continue;
				case 790:
					if (r ==  horizontal)
						GotoLine(880);
					else
						GotoLine(800);
					continue;
				case 800:
					if (widthArray[r + 1,s] != 0)
						GotoLine(880);
					else
						GotoLine(810);
					continue;
				case 810:
					if (s != vertical)
						GotoLine(840);
					else
						GotoLine(820);
					continue;
				case 820:
					if (z == 1)
						GotoLine(870);
					else
						GotoLine(830);
					continue;
				case 830:
					q = 1;
					GotoLine(990);
					continue;
				case 840:
					if (widthArray[r,s + 1] != 0)
						GotoLine(870);
					else
						GotoLine(850);
					continue;
				case 850:
					randomInt = Random(2);
					GotoLine(860);
					continue;
				case 860:
					if (randomInt == 1)
						GotoLine(1020);
					else if (randomInt == 2)
						GotoLine(1090);
					else
						GotoLine(870);
					continue;
				case 870:
					GotoLine(1020);
					continue;
				case 880:
					if (s != vertical)
						GotoLine(910);
					else
						GotoLine(890);
					continue;
				case 890:
					if (z == 1)
						GotoLine(930);
					else
						GotoLine(900);
					continue;
				case 900:
					q = 1;
					GotoLine(920);
					continue;
				case 910:
					if (widthArray[r,s + 1] != 0)
						GotoLine(930);
					else
						GotoLine(920);
					continue;
				case 920:
					GotoLine(1090);
					continue;
				case 930:
					GotoLine(1190);
					continue;
				case 940:
					widthArray[r - 1,s] = c;
					GotoLine(950);
					continue;
				case 950:
					c++;
					verticalArray[r - 1,s] = 2;
					r--;
					GotoLine(960);
					continue;
				case 960:
					if (c ==  horizontal * vertical + 1)
						GotoLine(1200);
					else
						GotoLine(970);
					continue;
				case 970:
					q = 0;
					GotoLine(270);
					continue;
				case 980:
					widthArray[r,s - 1] = c;
					GotoLine(990);
					continue;
				case 990:
					c++;
					GotoLine(1000);
					continue;
				case 1000:
					verticalArray[r,s - 1] = 1;
					s--;
					if (c ==  horizontal * vertical + 1)
						GotoLine(1200);
					else
						GotoLine(1010);
					continue;
				case 1010:
					q = 0;
					GotoLine(270);
					continue;
				case 1020:
					widthArray[r + 1,s] = c;
					GotoLine(1030);
					continue;
				case 1030:
					c++;
					if (verticalArray[r,s] == 0)
						GotoLine(1050);
					else
						GotoLine(1040);
					continue;
				case 1040:
					verticalArray[r,s] = 3;
					GotoLine(1060);
					continue;
				case 1050:
					verticalArray[r,s] = 2;
					GotoLine(1060);
					continue;
				case 1060:
					r++;
					GotoLine(1070);
					continue;
				case 1070:
					if (c ==  horizontal * vertical + 1)
						GotoLine(1200);
					else
						GotoLine(1080);
					continue;
				case 1080:
					GotoLine(600);
					continue;
				case 1090:
					if (q == 1)
						GotoLine(1150);
					else
						GotoLine(1100);
					continue;
				case 1100:
					widthArray[r,s + 1] = c;
					c++;
					if (verticalArray[r,s] == 0)
						GotoLine(1120);
					else
						GotoLine(1110);
					continue;
				case 1110:
					verticalArray[r,s] = 3;
					GotoLine(1130);
					continue;
				case 1120:
					verticalArray[r,s] = 1;
					GotoLine(1130);
					continue;
				case 1130:
					s++;
					if (c == vertical *  horizontal + 1)
						GotoLine(1200);
					else
						GotoLine(1140);
					continue;
				case 1140:
					GotoLine(270);
					continue;
				case 1150:
					z = 1;
					GotoLine(1160);
					continue;
				case 1160:
					if (verticalArray[r,s] == 0)
						GotoLine(1180);
					else
						GotoLine(1170);
					continue;
				case 1170:
					verticalArray[r,s] = 3;
					q = 0;
					GotoLine(1190);
					continue;
				case 1180:
					verticalArray[r,s] = 1;
					q = 0;
					r = 1;
					s = 1;
					GotoLine(260);
					continue;
				case 1190:
					GotoLine(210);
					continue;
				case 1200:
					Target = -1;
					continue;
			}

		}

		// 1200:
		for (int j = 1; j <= vertical; j++) 
		{
			Print("I");        // 1210

			for (int i = 1; i <=  horizontal; i++) 
			{
				if (verticalArray[i,j] >= 2)
					Print("   ");  // 1240
				else
					Print("  I");  // 1260
			}

			Print(" ");   // 1280
			Println();

			for (int i = 1; i <=  horizontal; i++) 
			{
				if (verticalArray[i,j] == 0)
					Print(":--");   // 1300, 1340
				else if (verticalArray[i,j] == 2)
					Print(":--");  // 1310, 1340
				else
					Print(":  "); // 1320
			}

			Print(":");    // 1360
			Println();
		}
	}
}
