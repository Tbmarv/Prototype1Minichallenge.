using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   public GameObject firstCam;
    public GameObject thirdCam;
    int camMode;

    [SerializeField] private string camInput;
    public void Update()
    {

        if (Input.GetButtonDown(camInput))
        {
            if (camMode == 1)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }

            StartCoroutine(CamChange());
        }
    }

    public IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(camMode == 0)
        {

            firstCam.SetActive(true);
            thirdCam.SetActive(false);

        }

        if (camMode == 1)
        {
            firstCam.SetActive(false);
            thirdCam.SetActive(true);

        }

}

}

