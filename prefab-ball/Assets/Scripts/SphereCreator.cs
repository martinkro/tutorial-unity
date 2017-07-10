using UnityEngine;
using System.Collections;

public class SphereCreator : MonoBehaviour {
    
    //Refrence of Prefab.
    public GameObject ball;
    
    int xPosition=0, yPosition=3;
   
    //This will call whenever user click on plane.
    void OnMouseDown()
    {
        Instantiate(ball, new Vector3(xPosition,yPosition,0),Quaternion.identity);
        xPosition += 1;
    }

}
    