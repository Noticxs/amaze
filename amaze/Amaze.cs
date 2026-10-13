// using System

namespace amaze_new;

public abstract class Amaze
{
	private static int Target { get; set; }
	public static Random RandomSeed { get; set; } = new Random(0);

#pragma warning disable CA2211
	public static string Result = "";
#pragma warning restore CA2211

	public static void Main(string[] args)
	{
		Run(int.Parse(args[0]),int.Parse(args[1]));
		// Console.WriteLine(Result);
	}

	private static void BlankLine()
	{
		Result = "";
	}

	private static void NewLine() 
	{
		Result += "\n";
	}

	private static void PrintText(string text)
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
	
	public enum ProcessState {
		Exit = 0,
		DrawWall = 100,
		DrawEntrance = 270,
		Finish = 500
	}

	public static void Run(int horizontalOriginal, int verticalOriginal) 
	{
		BlankLine();
		PrintText("Amazing - Copyright by Creative Computing, Morristown, NJ");
		NewLine();

		
		// Set default variable values
		if ( horizontalOriginal == 1 || verticalOriginal == 1) return;

		var widthArray = new int[ horizontalOriginal + 1,verticalOriginal + 1];
		var verticalArray = new int[ horizontalOriginal + 1,verticalOriginal + 1];
		
		var q = 0;
		var z = 0;
		var randomInt = Random( horizontalOriginal);

		// 130:170
		for (var i = 1; i <=  horizontalOriginal; i++)
		{
			PrintText(i == randomInt ? ":  " : ":--");
		}
		// 180
		PrintText(":");
		NewLine();

		// 190
		var counter = 1;
		widthArray[randomInt,1] = counter;
		counter++;

		// 200
		var randomInteger = randomInt;
		var s = 1;
		GotoLine(270);

		while (true)
		{
			pp
		}
		
		while (Target != -1) 
		{
			switch (Target) 
			{
				case 210:
					GotoLine(randomInteger != horizontalOriginal ? 250 : 220);
					continue;
				case 220:
					GotoLine(s != verticalOriginal ? 240 : 230);
					continue;
				case 230:
					randomInteger = 1;
					s = 1;
					GotoLine(260);
					continue;
				case 240:
					randomInteger = 1;
					s++;
					GotoLine(260);
					continue;
				case 250:
					randomInteger++;
					GotoLine(260);
					continue;
				case 260:
					GotoLine(widthArray[randomInteger, s] == 0 ? 210 : 270);
					continue;
				case 270:
					GotoLine(randomInteger - 1 == 0 ? 600 : 280);
					continue;
				case 280:
					GotoLine(widthArray[randomInteger - 1, s] != 0 ? 600 : 290);
					continue;
				case 290:
					GotoLine(s - 1 == 0 ? 430 : 300);
					continue;
				case 300:
					GotoLine(widthArray[randomInteger, s - 1] != 0 ? 430 : 310);
					continue;
				case 310:
					GotoLine(randomInteger == horizontalOriginal ? 350 : 320);
					continue;
				case 320:
					GotoLine(widthArray[randomInteger + 1, s] != 0 ? 350 : 330);
					continue;
				case 330:
					randomInt = Random(3);
					GotoLine(340);
					continue;
				case 340:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(980);
							break;
						case 3:
							GotoLine(1020);
							break;
						default:
							GotoLine(350);
							break;
					}
					continue;
				case 350:
					GotoLine(s != verticalOriginal ? 380 : 360);
					continue;
				case 360:
					GotoLine(z == 1 ? 410 : 370);
					continue;
				case 370:
					q = 1;
					GotoLine(390);
					continue;
				case 380:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 410 : 390);
					continue;
				case 390:
					randomInt = Random(3);
					GotoLine(400);
					continue;
				case 400:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(980);
							break;
						case 3:
							GotoLine(1090);
							break;
						default:
							GotoLine(410);
							break;
					}
					continue;
				case 410:
					randomInt = Random(2);
					GotoLine(420);
					continue;
				case 420:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(980);
							break;
						default:
							GotoLine(430);
							break;
					}
					continue;
				case 430:
					GotoLine(randomInteger == horizontalOriginal ? 530 : 440);
					continue;
				case 440:
					GotoLine(widthArray[randomInteger + 1, s] != 0 ? 530 : 450);
					continue;
				case 450:
					GotoLine(s != verticalOriginal ? 480 : 460);
					continue;
				case 460:
					GotoLine(z == 1 ? 510 : 470);
					continue;
				case 470:
					q = 1;
					GotoLine(490);
					continue;
				case 480:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 510 : 490);
					continue;
				case 490:
					randomInt = Random(3);
					GotoLine(500);
					continue;
				case 500:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(1020);
							break;
						case 3:
							GotoLine(1090);
							break;
						default:
							GotoLine(510);
							break;
					}
					continue;
				case 510:
					randomInt = Random(2);
					GotoLine(520);
					continue;
				case 520:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(1020);
							break;
						default:
							GotoLine(530);
							break;
					}
					continue;
				case 530:
					GotoLine(s != verticalOriginal ? 560 : 540);
					continue;
				case 540:
					GotoLine(z == 1 ? 590 : 550);
					continue;
				case 550:
					q = 1;
					GotoLine(570);
					continue;
				case 560:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 590 : 570);
					continue;
				case 570:
					randomInt = Random(2);
					GotoLine(580);
					continue;
				case 580:
					switch (randomInt)
					{
						case 1:
							GotoLine(940);
							break;
						case 2:
							GotoLine(1090);
							break;
						default:
							GotoLine(590);
							break;
					}
					continue;
				case 590:
					GotoLine(940);
					continue;
				case 600:
					GotoLine(s - 1 == 0 ? 790 : 610);
					continue;
				case 610:
					GotoLine(widthArray[randomInteger, s - 1] != 0 ? 790 : 620);
					continue;
				case 620:
					GotoLine(randomInteger == horizontalOriginal ? 720 : 630);
					continue;
				case 630:
					GotoLine(widthArray[randomInteger + 1, s] != 0 ? 720 : 640);
					continue;
				case 640:
					GotoLine(s != verticalOriginal ? 670 : 650);
					continue;
				case 650:
					GotoLine(z == 1 ? 700 : 660);
					continue;
				case 660:
					q = 1;
					GotoLine(680);
					continue;
				case 670:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 700 : 680);
					continue;
				case 680:
					randomInt = Random(3);
					GotoLine(690);
					continue;
				case 690:
					switch (randomInt)
					{
						case 1:
							GotoLine(980);
							break;
						case 2:
							GotoLine(1020);
							break;
						case 3:
							GotoLine(1090);
							break;
						default:
							GotoLine(700);
							break;
					}
					continue;
				case 700:
					randomInt = Random(2);
					GotoLine(710);
					continue;
				case 710:
					switch (randomInt)
					{
						case 1:
							GotoLine(980);
							break;
						case 2:
							GotoLine(1020);
							break;
						default:
							GotoLine(720);
							break;
					}
					continue;
				case 720:
					GotoLine(s != verticalOriginal ? 750 : 730);
					continue;
				case 730:
					GotoLine(z == 1 ? 780 : 740);
					continue;
				case 740:
					q = 1;
					GotoLine(760);
					continue;
				case 750:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 780 : 760);
					continue;
				case 760:
					randomInt = Random(2);
					GotoLine(770);
					continue;
				case 770:
					switch (randomInt)
					{
						case 1:
							GotoLine(980);
							break;
						case 2:
							GotoLine(1090);
							break;
						default:
							GotoLine(780);
							break;
					}
					continue;
				case 780:
					GotoLine(980);
					continue;
				case 790:
					GotoLine(randomInteger == horizontalOriginal ? 880 : 800);
					continue;
				case 800:
					GotoLine(widthArray[randomInteger + 1, s] != 0 ? 880 : 810);
					continue;
				case 810:
					GotoLine(s != verticalOriginal ? 840 : 820);
					continue;
				case 820:
					GotoLine(z == 1 ? 870 : 830);
					continue;
				case 830:
					q = 1;
					GotoLine(990);
					continue;
				case 840:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 870 : 850);
					continue;
				case 850:
					randomInt = Random(2);
					GotoLine(860);
					continue;
				case 860:
					switch (randomInt)
					{
						case 1:
							GotoLine(1020);
							break;
						case 2:
							GotoLine(1090);
							break;
						default:
							GotoLine(870);
							break;
					}
					continue;
				case 870:
					GotoLine(1020);
					continue;
				case 880:
					GotoLine(s != verticalOriginal ? 910 : 890);
					continue;
				case 890:
					GotoLine(z == 1 ? 930 : 900);
					continue;
				case 900:
					q = 1;
					GotoLine(920);
					continue;
				case 910:
					GotoLine(widthArray[randomInteger, s + 1] != 0 ? 930 : 920);
					continue;
				case 920:
					GotoLine(1090);
					continue;
				case 930:
					GotoLine(1190);
					continue;
				case 940:
					widthArray[randomInteger - 1,s] = counter;
					GotoLine(950);
					continue;
				case 950:
					counter++;
					verticalArray[randomInteger - 1,s] = 2;
					randomInteger--;
					GotoLine(960);
					continue;
				case 960:
					GotoLine(counter == horizontalOriginal * verticalOriginal + 1 ? 1200 : 970);
					continue;
				case 970:
					q = 0;
					GotoLine(270);
					continue;
				case 980:
					widthArray[randomInteger,s - 1] = counter;
					GotoLine(990);
					continue;
				case 990:
					counter++;
					GotoLine(1000);
					continue;
				case 1000:
					verticalArray[randomInteger,s - 1] = 1;
					s--;
					GotoLine(counter == horizontalOriginal * verticalOriginal + 1 ? 1200 : 1010);
					continue;
				case 1010:
					q = 0;
					GotoLine(270);
					continue;
				case 1020:
					widthArray[randomInteger + 1,s] = counter;
					GotoLine(1030);
					continue;
				case 1030:
					counter++;
					GotoLine(verticalArray[randomInteger, s] == 0 ? 1050 : 1040);
					continue;
				case 1040:
					verticalArray[randomInteger,s] = 3;
					GotoLine(1060);
					continue;
				case 1050:
					verticalArray[randomInteger,s] = 2;
					GotoLine(1060);
					continue;
				case 1060:
					randomInteger++;
					GotoLine(1070);
					continue;
				case 1070:
					GotoLine(counter == horizontalOriginal * verticalOriginal + 1 ? 1200 : 1080);
					continue;
				case 1080:
					GotoLine(600);
					continue;
				case 1090:
					GotoLine(q == 1 ? 1150 : 1100);
					continue;
				case 1100:
					widthArray[randomInteger,s + 1] = counter;
					counter++;
					GotoLine(verticalArray[randomInteger, s] == 0 ? 1120 : 1110);
					continue;
				case 1110:
					verticalArray[randomInteger,s] = 3;
					GotoLine(1130);
					continue;
				case 1120:
					verticalArray[randomInteger,s] = 1;
					GotoLine(1130);
					continue;
				case 1130:
					s++;
					GotoLine(counter == verticalOriginal * horizontalOriginal + 1 ? 1200 : 1140);
					continue;
				case 1140:
					GotoLine(270);
					continue;
				case 1150:
					z = 1;
					GotoLine(1160);
					continue;
				case 1160:
					GotoLine(verticalArray[randomInteger, s] == 0 ? 1180 : 1170);
					continue;
				case 1170:
					verticalArray[randomInteger,s] = 3;
					q = 0;
					GotoLine(1190);
					continue;
				case 1180:
					verticalArray[randomInteger,s] = 1;
					q = 0;
					randomInteger = 1;
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
		for (var j = 1; j <= verticalOriginal; j++) 
		{
			PrintText("I");        // 1210

			for (var i = 1; i <=  horizontalOriginal; i++)
			{
				PrintText(verticalArray[i, j] >= 2 ? "   " : "  I"); // 1260
				// 1240
			}

			PrintText(" ");   // 1280
			NewLine();

			for (var i = 1; i <=  horizontalOriginal; i++)
			{
				switch (verticalArray[i,j])
				{
					case 0:
					// 1310, 1340
					case 2:
						PrintText(":--");   // 1300, 1340
						break;
					default:
						PrintText(":  "); // 1320
						break;
				}
			}

			PrintText(":");    // 1360
			NewLine();
		}
	}
}