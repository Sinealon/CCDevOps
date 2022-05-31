using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Sheeptest
{
    [UnityTest]
    public IEnumerator MoveNorth()
    {
        var gameObject = new GameObject();
        //var sheep = gameObject.AddComponent<>();
        //sheep.Move(Direction.North);

        yield return null;

        Assert.Equals(gameObject, new GameObject());
    }
}
