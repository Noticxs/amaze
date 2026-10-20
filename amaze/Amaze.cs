// using System

namespace amaze_new;

public static class Amaze
{
    private const string HorizontalInternalWall = ":--";
    private const string VerticalInternalWall = ":  ";
    private const string OuterWall = "I";

    private static int Target { get; set; }
    public static Random RandomSeed { get; set; } = new(0);

#pragma warning disable CA2211
    public static string Result = "";
#pragma warning restore CA2211

    public static void Main(string[] args)
    {
        Run(int.Parse(args[0]), int.Parse(args[1]));
    }

    private enum AppendMethods
    {
        NewLine,
        Text,
        BlankLine,
    };

    private static void Append(AppendMethods appendMethod, string? text)
    {
        switch (appendMethod)
        {
            case AppendMethods.NewLine:
                Result += "\n";
                break;
            case AppendMethods.Text:
                Result += text;
                break;
            case AppendMethods.BlankLine:
                Result = "";
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(appendMethod), appendMethod, null);
        }
    }

    private static int Random(int count)
    {
        return (int)(RandomSeed.NextDouble() * count) + 1 <= count ? (int)(RandomSeed.NextDouble() * count) + 1 : count;
    }

    private static void SetTarget(int lineNumber)
    {
        Target = lineNumber;
    }

    public static void Run(int width, int height)
    {
        Append(AppendMethods.BlankLine, null);
        Append(AppendMethods.Text, "Amazing - Copyright by Creative Computing, Morristown, NJ");
        Append(AppendMethods.NewLine, null);

        if (width == 1 || height == 1) return;

        var visitedStepGrid = new int[width + 1, height + 1];
        var cellWallConfig = new int[width + 1, height + 1];

        var hasHitBoundary = false;
        var hasReachedOuterEdge = false;

        var randomInt = Random(width);

        // Print top border
        for (var i = 1; i <= width; i++)
        {
            Append(AppendMethods.Text, i == randomInt ? VerticalInternalWall : HorizontalInternalWall);
        }

        Append(AppendMethods.Text, ":");
        Append(AppendMethods.NewLine, null);

        var stepCounter = 1;
        visitedStepGrid[randomInt, 1] = stepCounter;
        stepCounter++;

        var currentX = randomInt;
        var currentY = 1;

        SetTarget(270);

        while (Target != -1)
        {
            switch (Target)
            {
                case 210:
                    SetTarget(currentX != width ? 250 : 220);
                    continue;
                case 220:
                    SetTarget(currentY != height ? 240 : 230);
                    continue;
                case 230:
                    currentX = 1;
                    currentY = 1;
                    SetTarget(260);
                    continue;
                case 240:
                    currentX = 1;
                    currentY++;
                    SetTarget(260);
                    continue;
                case 250:
                    currentX++;
                    SetTarget(260);
                    continue;
                case 260:
                    SetTarget(visitedStepGrid[currentX, currentY] == 0 ? 210 : 270);
                    continue;
                case 270:
                    if (currentX - 1 == 0)
                    {
                        SetTarget(600);
                    }
                    else
                    {
                        SetTarget(280);
                    }
                    continue;
                case 280:
                    if (visitedStepGrid[currentX - 1, currentY] != 0)
                    {
                        SetTarget(600);
                    }
                    else
                    {
                        SetTarget(290);
                    }
                    continue;
                case 290:
                    if (currentY - 1 == 0)
                    {
                        SetTarget(430);
                    }
                    else
                    {
                        SetTarget(300);
                    }
                    continue;
                case 300:
                    if (visitedStepGrid[currentX, currentY - 1] != 0)
                    {
                        SetTarget(430);
                    }
                    else
                    {
                        SetTarget(310);
                    }
                    continue;
                case 310:
                    SetTarget(currentX == width ? 350 : 320);
                    continue;
                case 320:
                    SetTarget(visitedStepGrid[currentX + 1, currentY] != 0 ? 350 : 330);
                    continue;
                case 330:
                    randomInt = Random(3);
                    SetTarget(340);
                    continue;
                case 340:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(980); break;
                        case 3: SetTarget(1020); break;
                        default: SetTarget(350); break;
                    }
                    continue;
                case 350:
                    SetTarget(currentY != height ? 380 : 360);
                    continue;
                case 360:
                    SetTarget(hasReachedOuterEdge ? 410 : 370);
                    continue;
                case 370:
                    hasHitBoundary = true;
                    SetTarget(390);
                    continue;
                case 380:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 410 : 390);
                    continue;
                case 390:
                    randomInt = Random(3);
                    SetTarget(400);
                    continue;
                case 400:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(980); break;
                        case 3: SetTarget(1090); break;
                        default: SetTarget(410); break;
                    }
                    continue;
                case 410:
                    randomInt = Random(2);
                    SetTarget(420);
                    continue;
                case 420:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(980); break;
                        default: SetTarget(430); break;
                    }
                    continue;
                case 430:
                    SetTarget(currentX == width ? 530 : 440);
                    continue;
                case 440:
                    SetTarget(visitedStepGrid[currentX + 1, currentY] != 0 ? 530 : 450);
                    continue;
                case 450:
                    SetTarget(currentY != height ? 480 : 460);
                    continue;
                case 460:
                    SetTarget(hasReachedOuterEdge ? 510 : 470);
                    continue;
                case 470:
                    hasHitBoundary = true;
                    SetTarget(490);
                    continue;
                case 480:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 510 : 490);
                    continue;
                case 490:
                    randomInt = Random(3);
                    SetTarget(500);
                    continue;
                case 500:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(1020); break;
                        case 3: SetTarget(1090); break;
                        default: SetTarget(510); break;
                    }
                    continue;
                case 510:
                    randomInt = Random(2);
                    SetTarget(520);
                    continue;
                case 520:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(1020); break;
                        default: SetTarget(530); break;
                    }
                    continue;
                case 530:
                    SetTarget(currentY != height ? 560 : 540);
                    continue;
                case 540:
                    SetTarget(hasReachedOuterEdge ? 590 : 550);
                    continue;
                case 550:
                    hasHitBoundary = true;
                    SetTarget(570);
                    continue;
                case 560:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 590 : 570);
                    continue;
                case 570:
                    randomInt = Random(2);
                    SetTarget(580);
                    continue;
                case 580:
                    switch (randomInt)
                    {
                        case 1: SetTarget(940); break;
                        case 2: SetTarget(1090); break;
                        default: SetTarget(590); break;
                    }
                    continue;
                case 590:
                    SetTarget(940);
                    continue;
                case 600:
                    if (currentY - 1 == 0)
                    {
                        SetTarget(790);
                    }
                    else
                    {
                        SetTarget(610);
                    }
                    continue;
                case 610:
                    if (visitedStepGrid[currentX, currentY - 1] != 0)
                    {
                        SetTarget(790);
                    }
                    else
                    {
                        SetTarget(620);
                    }
                    continue;
                case 620:
                    SetTarget(currentX == width ? 720 : 630);
                    continue;
                case 630:
                    SetTarget(visitedStepGrid[currentX + 1, currentY] != 0 ? 720 : 640);
                    continue;
                case 640:
                    SetTarget(currentY != height ? 670 : 650);
                    continue;
                case 650:
                    SetTarget(hasReachedOuterEdge ? 700 : 660);
                    continue;
                case 660:
                    hasHitBoundary = true;
                    SetTarget(680);
                    continue;
                case 670:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 700 : 680);
                    continue;
                case 680:
                    randomInt = Random(3);
                    SetTarget(690);
                    continue;
                case 690:
                    switch (randomInt)
                    {
                        case 1: SetTarget(980); break;
                        case 2: SetTarget(1020); break;
                        case 3: SetTarget(1090); break;
                        default: SetTarget(700); break;
                    }
                    continue;
                case 700:
                    randomInt = Random(2);
                    SetTarget(710);
                    continue;
                case 710:
                    switch (randomInt)
                    {
                        case 1: SetTarget(980); break;
                        case 2: SetTarget(1020); break;
                        default: SetTarget(720); break;
                    }
                    continue;
                case 720:
                    SetTarget(currentY != height ? 750 : 730);
                    continue;
                case 730:
                    SetTarget(hasReachedOuterEdge ? 780 : 740);
                    continue;
                case 740:
                    hasHitBoundary = true;
                    SetTarget(760);
                    continue;
                case 750:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 780 : 760);
                    continue;
                case 760:
                    randomInt = Random(2);
                    SetTarget(770);
                    continue;
                case 770:
                    switch (randomInt)
                    {
                        case 1: SetTarget(980); break;
                        case 2: SetTarget(1090); break;
                        default: SetTarget(780); break;
                    }
                    continue;
                case 780:
                    SetTarget(980);
                    continue;
                case 790:
                    SetTarget(currentX == width ? 880 : 800);
                    continue;
                case 800:
                    SetTarget(visitedStepGrid[currentX + 1, currentY] != 0 ? 880 : 810);
                    continue;
                case 810:
                    SetTarget(currentY != height ? 840 : 820);
                    continue;
                case 820:
                    SetTarget(hasReachedOuterEdge ? 870 : 830);
                    continue;
                case 830:
                    hasHitBoundary = true;
                    SetTarget(990);
                    continue;
                case 840:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 870 : 850);
                    continue;
                case 850:
                    randomInt = Random(2);
                    SetTarget(860);
                    continue;
                case 860:
                    switch (randomInt)
                    {
                        case 1: SetTarget(1020); break;
                        case 2: SetTarget(1090); break;
                        default: SetTarget(870); break;
                    }
                    continue;
                case 870:
                    SetTarget(1020);
                    continue;
                case 880:
                    SetTarget(currentY != height ? 910 : 890);
                    continue;
                case 890:
                    SetTarget(hasReachedOuterEdge ? 930 : 900);
                    continue;
                case 900:
                    hasHitBoundary = true;
                    SetTarget(920);
                    continue;
                case 910:
                    SetTarget(visitedStepGrid[currentX, currentY + 1] != 0 ? 930 : 920);
                    continue;
                case 920:
                    SetTarget(1090);
                    continue;
                case 930:
                    SetTarget(1190);
                    continue;
                case 940:
                    visitedStepGrid[currentX - 1, currentY] = stepCounter;
                    SetTarget(950);
                    continue;
                case 950:
                    stepCounter++;
                    cellWallConfig[currentX - 1, currentY] = 2;
                    currentX--;
                    SetTarget(960);
                    continue;
                case 960:
                    if (stepCounter == width * height + 1)
                    {
                        SetTarget(1200);
                    }
                    else
                    {
                        SetTarget(970);
                    }
                    continue;
                case 970:
                    hasHitBoundary = false;
                    SetTarget(270);
                    continue;
                case 980:
                    visitedStepGrid[currentX, currentY - 1] = stepCounter;
                    SetTarget(990);
                    continue;
                case 990:
                    stepCounter++;
                    SetTarget(1000);
                    continue;
                case 1000:
                    cellWallConfig[currentX, currentY - 1] = 1;
                    currentY--;
                    if (stepCounter == width * height + 1)
                    {
                        SetTarget(1200);
                    }
                    else
                    {
                        SetTarget(1010);
                    }
                    continue;
                case 1010:
                    hasHitBoundary = false;
                    SetTarget(270);
                    continue;
                case 1020:
                    visitedStepGrid[currentX + 1, currentY] = stepCounter;
                    stepCounter++;

                    if (cellWallConfig[currentX, currentY] == 0)
                    {
                        SetTarget(1050);
                    }
                    else
                    {
                        SetTarget(1040);
                    }
                    continue;
                case 1040:
                    cellWallConfig[currentX, currentY] = 3;
                    SetTarget(1060);
                    continue;
                case 1050:
                    cellWallConfig[currentX, currentY] = 2;
                    SetTarget(1060);
                    continue;
                case 1060:
                    currentX++;
                    if (stepCounter == width * height + 1)
                    {
                        SetTarget(1200);
                    }
                    else
                    {
                        SetTarget(1080);
                    }
                    continue;
                case 1080:
                    hasHitBoundary = false;
                    SetTarget(600);
                    continue;
                case 1090:
                    SetTarget(hasHitBoundary ? 1150 : 1100);
                    continue;
                case 1100:
                    if (stepCounter == width * height + 1)
                    {
                        SetTarget(1150);
                    }
                    else
                    {
                        SetTarget(1110);
                    }
                    continue;
                case 1110:
                    visitedStepGrid[currentX, currentY + 1] = stepCounter;
                    stepCounter++;
                    if (cellWallConfig[currentX, currentY] == 0)
                    {
                        SetTarget(1130);
                    }
                    else
                    {
                        SetTarget(1120);
                    }
                    continue;
                case 1120:
                    cellWallConfig[currentX, currentY] = 3;
                    SetTarget(1140);
                    continue;
                case 1130:
                    cellWallConfig[currentX, currentY] = 1;
                    SetTarget(1140);
                    continue;
                case 1140:
                    currentY++;
                    if (stepCounter == width * height + 1)
                    {
                        SetTarget(1200);
                    }
                    else
                    {
                        SetTarget(270);
                    }
                    continue;
                case 1150:
                    hasReachedOuterEdge = true;
                    SetTarget(1160);
                    continue;
                case 1160:
                    if (cellWallConfig[currentX, currentY] == 0)
                    {
                        SetTarget(1180);
                    }
                    else
                    {
                        SetTarget(1170);
                    }
                    continue;
                case 1170:
                    cellWallConfig[currentX, currentY] = 3;
                    hasHitBoundary = false;
                    SetTarget(1190);
                    continue;
                case 1180:
                    cellWallConfig[currentX, currentY] = 1;
                    hasHitBoundary = false;
                    currentX = 1;
                    currentY = 1;
                    SetTarget(260);
                    continue;
                case 1190:
                    SetTarget(210);
                    continue;
                case 1200:
                    Target = -1;
                    continue;
            }
        }

        // Print maze body
        for (var col = 1; col <= height; col++)
        {
            Append(AppendMethods.Text, OuterWall);

            for (var x = 1; x <= width; x++)
            {
                Append(AppendMethods.Text, cellWallConfig[x, col] >= 2 ? "   " : $"  {OuterWall}");
            }

            Append(AppendMethods.Text, " ");
            Append(AppendMethods.NewLine, null);

            for (var row = 1; row <= width; row++)
            {
                switch (cellWallConfig[row, col])
                {
                    case 0:
                    case 2:
                        Append(AppendMethods.Text, HorizontalInternalWall);
                        break;
                    default:
                        Append(AppendMethods.Text, VerticalInternalWall);
                        break;
                }
            }

            Append(AppendMethods.Text, ":");
            Append(AppendMethods.NewLine, null);
        }
    }
}
