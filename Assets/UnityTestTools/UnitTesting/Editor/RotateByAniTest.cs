using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


[TestFixture]
public class RotateByAniTest : MonoBehaviour 
{
	[Test]
	public void RotateByProperties() 
	{
		var rotate = new RotateByAnimation();

//		rotate.Hash(RotateByX, 0, RotateByY, 1, RotateByZ, 2, easeType, "easeInOutBack", loopType, "pingPong", delay, 3, time, 4, includechildren, true);

		rotate.RotateByX = 0;
		rotate.RotateByY = 1;
		rotate.RotateByZ = 2;
		rotate.easeType = "easeInOutBack";
		rotate.loopType = "pingPong";
		rotate.delay = 3;
		rotate.time = 4;
		rotate.includechildren = true;

		Assert.That (rotate.RotateByX == 0);
		Assert.That (rotate.RotateByY == 1);
		Assert.That (rotate.RotateByZ == 2);
		Assert.That (rotate.easeType == "easeInOutBack");
		Assert.That (rotate.loopType == "pingPong");
		Assert.That (rotate.delay == 3);
		Assert.That (rotate.time == 4);
		Assert.That (rotate.includechildren == true);

	}


}
