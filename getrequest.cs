using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class movecube : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string url = "http://bonfire-dev.herokuapp.com/echo";
		var form = new WWWForm();
		form.AddField( "foo", "bar" );
		WWW www = new WWW(url, form);

		StartCoroutine(WaitForRequest(www));
	
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		
		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
	
	// Update is called once per frame
	void Update () {
	}
}
