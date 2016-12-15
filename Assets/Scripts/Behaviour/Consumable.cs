using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Consumable : MonoBehaviour
{

    public int ScoreValue;
    protected GameController controller;
	AudioSource Audio;
	public AudioClip Beep;

	// Use this for initialization
	protected void Start ()
	{
        // Find the GameController.
	    GameObject obj = GameObject.FindWithTag("GameController");
	    if (obj != null)
	    {
	        controller = obj.GetComponent<GameController>();
	    }
	    if (controller == null)
	    {
	        Debug.LogError("Can't find GameController!");
	    }
		Audio = GetComponent<AudioSource> ();
	}

    void OnTriggerEnter(Collider other)
    {

		if (other.tag == "Player") {
			this.Consumed ();

			// Added by Kristian Veech
			// Beep plays when a dot is "consumed"
			Audio.PlayOneShot (Beep, 0.7F);
			Debug.Log ("beep");
		}
    }

    /// <summary>
    /// This Consumable object has been consumed by the player
    /// </summary>
    protected virtual void Consumed()
    {
        controller.DotConsumed(this.ScoreValue);
        Destroy(gameObject, 0.6f);
    }

}
