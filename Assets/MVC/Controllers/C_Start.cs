using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C_Start : MonoBehaviour {


    [SerializeField]
    V_Start startView;

    M_Connection connectionModel;
    
	// Use this for initialization
	void Start () {
        connectionModel = GetComponent<M_Connection>();
        connectionModel.GetStartInfo(this);
	}
#region public_functions
	public void OnStartInfoReturn()
    {
        startView.ShowStartButton();     
    }
    public void MoveToGameScene()
    {
        SceneManager.LoadScene("game");
    }

#endregion
}
