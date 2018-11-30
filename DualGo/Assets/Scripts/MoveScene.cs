using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour {
    public string SceneName;
     
	public void onClick()
    {
        Application.LoadLevel(SceneName);
    }
}
