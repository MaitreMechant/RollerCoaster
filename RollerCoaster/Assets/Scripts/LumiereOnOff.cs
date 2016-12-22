using UnityEngine;
using System.Collections;

public class LumiereOnOff : MonoBehaviour {

    public Light lumlum;

	// Use this for initialization
	void Start () {

        lumlum = GetComponent<Light>();
     
      
    }

   
void Update () {
 
    if (Input.GetKeyDown("space"))
        {
        lumlum.intensity = 8f;
   }

    if (Input.GetKeyUp("space"))
        {
       lumlum.intensity = 2f;
    }

}
	


}
