using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Connection : MonoBehaviour {

    C_Start startController;
	public void GetStartInfo(C_Start controller)
    {
        startController = controller;
        string path="https://www.sometest.com/api";
    
        WWW www = new WWW(path);
        StartCoroutine(WaitForCallback(www));
    }
    IEnumerator WaitForCallback(WWW www)
    {
        yield return www;
       
        startController.OnStartInfoReturn();
    }
}
