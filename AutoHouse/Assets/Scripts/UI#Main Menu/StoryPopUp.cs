using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class StoryPopUp : MonoBehaviour
{
    private GameObject go;

    void Update()
    {
        // If the Space key is pressed, close the story GUI
        if (Input.GetKeyDown(KeyCode.Space)) {
            go = gameObject.transform.parent.gameObject;
            Destroy(go);
        }
    }
}
