using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class ColorToAniTest : MonoBehaviour {

	[Test]
	public void ColorToProperties ()  
	{

		var color = new ColorToAnimation();
		color.time = 3; 
		color.delay = 2;
		color.loopType = "pingPong";
		color.includechildren = true;

		Assert.That (color.time == 3);
		Assert.That (color.delay == 2);
		Assert.That (color.loopType == "pingPong");
		Assert.That (color.includechildren == true);

	}

}
