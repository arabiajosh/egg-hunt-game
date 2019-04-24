using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSelectBehavior : MonoBehaviour
{

    Camera playerCam;
    Ray ray;
    RaycastHit raycastHit;


    private void Start()
    {
        playerCam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = playerCam.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out raycastHit);

        if(raycastHit.transform.tag.Equals("egg"))
        {
            //Debug.Log("Aiming at egg");
            if (Input.GetMouseButton(0))
            {
                raycastHit.transform.gameObject.SetActive(false);
                GameManager.instance.CollectEgg();
            }
        }
        else
        {
            //Debug.Log("Aiming at " + raycastHit.transform.tag);
        }
    }
}
