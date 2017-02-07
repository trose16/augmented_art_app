using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class FadeFromAniTest : MonoBehaviour
{
	[Test]
	public void FadeFromProperties ()  
	{

		var fade = new FadeFromAnimation();
		fade.alpha = 0;
		fade.time = 3;
		fade.delay = 1;
		fade.easeType = "easeInSine";
		fade.loopType = "pingPong";
		fade.includechildren = true;

		Assert.That (fade.alpha == 0);
		Assert.That (fade.time == 3);
		Assert.That (fade.delay == 1);
		Assert.That (fade.easeType == "easeInSine");
		Assert.That (fade.loopType == "pingPong");
		Assert.That (fade.includechildren == true);

	
		
	}


}
