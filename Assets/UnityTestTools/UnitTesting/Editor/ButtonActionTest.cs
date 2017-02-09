using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

//This test will work when we use "EditorSceneManager.OpenScene" instead of "SceneManager.LoadScene" in ButtonAction
//because this test framework is not working in Play mode.

[TestFixture]
public class ButtonActionTest : MonoBehaviour {

	[Test]
	public void ButtonActionGoToIndexScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Home.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoIndex ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Index");
	}

	[Test]
	public void ButtonActionGoToHomeScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Index.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoHome ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Home");
	}

	[Test]
	public void ButtonActionGoToArtistScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Index.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoArtist ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Artist");
	}

	[Test]
	public void ButtonActionGoToAugmentScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Index.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoAugment ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Augment");
	}
		
	[Test]
	public void ButtonActionGoToCanvasScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Index.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoCanvas ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Canvas");
	}

	[Test]
	public void ButtonActionGoBackToIndexSceneFromArtistScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Artist.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoIndex ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Index");
	}

	[Test]	
	public void ButtonActionGoBackToIndexSceneFromCanvasScene()
	{
		EditorSceneManager.OpenScene ("Assets/Scenes/Canvas.unity");
		var buttonActions = new ButtonAction ();
		buttonActions.GoIndex ();
		var currentScene = SceneManager.GetActiveScene ();
		Assert.That ( currentScene.name == "Index");
	}

}
