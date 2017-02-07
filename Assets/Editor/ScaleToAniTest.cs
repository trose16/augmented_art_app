using UnityEngine;
using UnityEditor;
using NUnit.Framework;


[TestFixture]
public class ScaleToAniTest : MonoBehaviour 
{

	[Test]
	public void ScaleByProperties() {

		var scale = new ScaleToAnimation();
		scale.ScaleToX = 1;
		scale.ScaleToY = 2;
		scale.ScaleToZ = 3;
		scale.delay = 4;
		scale.time = 5;
		scale.speed = 6;
		scale.easeType = "easeInOutExpo";
		scale.loopType = "pingPong";
		scale.includechildren = true;
			
		Assert.That(scale.ScaleToX == 1);
		Assert.That(scale.ScaleToY == 2);
		Assert.That(scale.ScaleToZ == 3);
		Assert.That(scale.delay == 4);
		Assert.That(scale.time == 5);
		Assert.That(scale.speed == 6);
		Assert.That(scale.easeType == "easeInOutExpo");
		Assert.That(scale.loopType == "pingPong");
		Assert.That(scale.includechildren == true);
	}
}
