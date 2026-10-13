using amaze_new;

namespace amaze_new_new.tests;

[TestFixture]
public class AmazeTests
{
    [Test]
    public void Seed0Size15X20()
    {
        var expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:--:--:--:--:--:--:--:  :--:--:--:--:
I                             I        I     I 
:  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:
I           I     I     I  I     I     I     I 
:--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :
I        I  I  I     I  I     I     I     I  I 
:--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :
I     I  I     I     I     I  I           I  I 
:  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :
I  I  I     I        I     I  I     I     I  I 
:  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :
I  I  I     I  I     I        I     I  I  I  I 
:  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :
I  I     I     I  I  I        I  I     I  I  I 
:  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :
I  I  I     I     I  I     I  I  I        I  I 
:  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :
I           I  I     I  I  I     I     I  I  I 
:--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :
I     I  I        I     I  I  I        I     I 
:  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:
I  I  I     I  I     I     I  I        I     I 
:--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :
I     I  I     I        I     I  I     I  I  I 
:  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :
I        I  I     I     I     I  I        I  I 
:  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :
I        I     I     I     I  I  I     I     I 
:--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :
I     I     I  I  I  I     I     I  I        I 
:  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:
I  I        I     I  I           I  I  I     I 
:  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :
I  I        I  I  I     I     I  I           I 
:  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:
I     I  I  I     I  I  I           I        I 
:--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:
I     I  I     I     I              I        I 
:  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :
I                 I  I     I     I           I 
:--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:
";
        Amaze.RandomSeed = new Random(0);
        Amaze.Runner(15, 20);
        
        Console.WriteLine(Amaze.Result);
        
        // var generateMaze = new AmazeNew();
        // generateMaze.Runner(90, 90, IAmaze.Output.Text);
        
        Assert.That(Amaze.Result, Is.EqualTo(expected), "Should have the maze that was expected");
    }

    [Test]
    public void Seed100Size4X5()
    {
        var expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:  :
I           I 
:  :--:  :--:
I     I  I  I 
:--:  :  :  :
I  I  I     I 
:  :  :--:  :
I  I     I  I 
:  :--:  :  :
I        I  I 
:--:--:--:  :
";
        // GOAL -> simplify this code out
        
        Amaze.RandomSeed = new Random(100);
        Amaze.Runner(4, 5);
        
        Console.WriteLine(Amaze.Result);
        
        // var generateMaze = new AmazeNew();
        // generateMaze.Runner(90, 90, IAmaze.Output.Text);

        Assert.That(Amaze.Result, Is.EqualTo(expected), "Should have the maze that was expected");
    }
}
