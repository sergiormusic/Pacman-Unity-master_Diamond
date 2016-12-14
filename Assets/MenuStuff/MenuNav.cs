using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour {

	public Texture playButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI ()
	{
		if (GUI.Button (new Rect (200, 200, 600, 80), playButton))
			SceneManager.LoadScene ("game");
	}

}
