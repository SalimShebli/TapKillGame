using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Chape : MonoBehaviour {
    public bool isBad;
    C_Game gameController;
    GameObject Camera;
    bool GameOn = false;
    float timer = 0;
    float LifeTime = 4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameOn)
        {
            timer += Time.deltaTime;
            if(timer>LifeTime)
            {
                GameOn = false;
                Destroy(gameObject);
            }
        }
	}
    public void SetGameControllerAndCamera(C_Game cont,GameObject cam)
    {
        gameController = cont;
        Camera = cam;
    }
    public void SetPosition(float x,float y)
    {
        transform.position = new Vector3(x, y, transform.position.z);
        gameObject.SetActive(true);
        GameOn = true;
        transform.LookAt(Camera.transform);
    }
    public void OnMouseDown()
    {
        print("Mouse Down");
        if(GameOn)
        {
            GameOn = false;
           
            gameController.OnObjectHit(isBad);
            Destroy(gameObject);
        }
    }
}
