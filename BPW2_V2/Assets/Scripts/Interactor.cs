using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask;
    public Animator appearanceAnimation;
    private bool playingAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 20, interactableLayermask)
            && Input.GetMouseButtonDown(0) && playingAnimation == false)
        {
            //Debug.Log(hit.collider.name);
            //Debug.DrawRay(Camera.main.transform.position,Camera.main.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            // Debug.Log("i hit it");
            appearanceAnimation.SetBool("AppearIsland", true);
            playingAnimation = true;
        }

        else 
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 20, interactableLayermask)
            && Input.GetMouseButtonDown(0) && playingAnimation == true)
            {
                appearanceAnimation.SetBool("AppearIsland", false);
                playingAnimation = false;
            }
        }
    }
}
