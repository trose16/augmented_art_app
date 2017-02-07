using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


[TestFixture]
public class MoveByAniTest : MonoBehaviour 
{
	[Test]
	public void MoveByProperties() 
	{
		var movesBy = new MoveByAnimation();
		movesBy.MoveByX = 10;
		movesBy.MoveByY = 5;
		movesBy.MoveByZ = 20; 
		movesBy.delay = 1;
		movesBy.easeType = "easeInOutExpo";
		movesBy.loopType = "pingPong";
		movesBy.includechildren = true;

		Assert.That (movesBy.MoveByX == 10);
		Assert.That (movesBy.MoveByY == 5);
		Assert.That (movesBy.MoveByZ == 20);
		Assert.That (movesBy.delay == 1);
		Assert.That (movesBy.easeType == "easeInOutExpo");
		Assert.That (movesBy.loopType == "pingPong");
		Assert.That (movesBy.includechildren == true);
		
	}

}
