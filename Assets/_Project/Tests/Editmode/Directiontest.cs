using NUnit.Framework;
using UnityEngine;

public class Directiontest
{
    // A Test behaves as an ordinary method
    [Test]
    public void North()
    {
        Assert.AreEqual(new Vector3(0, 1, 0), new Vector3(0, 1, 0));
    }
}
