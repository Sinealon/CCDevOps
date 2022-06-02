using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class MoveTest
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MoveTestWithEnumeratorPasses()
    {
        var gamobject = new GameObject();
        var testButton = gamobject.AddComponent<Button>();
        testButton.transform.localPosition = new Vector3(0, 0, 0);
        var clickcounter = gamobject.AddComponent<ClickCounter>();
        clickcounter.button = testButton.gameObject;
        testButton.onClick.AddListener(clickcounter.clicked);
        for (int i = 0; i < 10; i++)
        {
            testButton.onClick.Invoke();
        }
        Assert.AreEqual(testButton.transform.localPosition, new Vector3(-100, 0, 0));
        for (int i = 0; i < 10; i++)
        {
            testButton.onClick.Invoke();
        }
        Assert.AreEqual(testButton.transform.localPosition, new Vector3(0, 0, 0));
        yield return null;
    }
}
