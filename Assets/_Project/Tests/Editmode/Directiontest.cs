using NUnit.Framework;
using UnityEngine;

public class Directiontest
{
    // A Test behaves as an ordinary method
    [Test]
    public void moveTest()
    {
        Assert.AreEqual(100, (int)ClickCounter.Move.right);
        Assert.AreEqual(-100, (int)ClickCounter.Move.left);
    }
}
