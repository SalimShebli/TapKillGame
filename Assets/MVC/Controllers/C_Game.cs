using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Game : MonoBehaviour
{

    #region public_and_serialize_fields
    public float startX, endX;
    public float startY, endY;
    [SerializeField]
    List<GameObject> Prefabs;
    [SerializeField]
    V_Game gameUI;
    [SerializeField]
    GameObject MainCamera;
    #endregion

    #region private_variables
    float gametime = 0;
    float fullgame = 60;
    bool gameOn=true;
    int totPoints;
    #endregion
    // Use this for initialization
	void Start () {
        StartCoroutine(WaitForInitObjects());
	}
	
	// Update is called once per frame
	void Update () {
        gametime += Time.deltaTime;
        if(gametime>=fullgame)
        {
            gameOn = false;
            gameUI.OnGameEnd();
        }
        
	}
    IEnumerator WaitForInitObjects()
    {
        yield return new WaitForSeconds(2f);
        if (gameOn)
        {
            InitNewObject();
            StartCoroutine(WaitForInitObjects());
        }
    }
    void InitNewObject()
    {
        int rChape=Random.Range(0,Prefabs.Count);
        GameObject newGameObject = Instantiate(Prefabs[rChape]);
        float rx = Random.Range(startX, endX);
        float ry = Random.Range(startY, endY);
      
        newGameObject.GetComponent<M_Chape>().SetGameControllerAndCamera(this,MainCamera);
        newGameObject.GetComponent<M_Chape>().SetPosition(rx, ry);
    }
    public void OnObjectHit(bool isBad)
    {
        if (isBad)
        {
            totPoints -= 10;
        }
        else totPoints += 10;
        gameUI.UpdatePoints(totPoints);
    }
    public  void ExitGame()
    {
        Application.Quit();
    }
}
