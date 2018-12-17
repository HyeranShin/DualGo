using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour {
    public string SceneName;
     
	public void onClick()
    {
        SceneManager.LoadScene (SceneName);
    }

    public void onClick_mini()
    {
        SceneManager.GetActiveScene();
    }
}
