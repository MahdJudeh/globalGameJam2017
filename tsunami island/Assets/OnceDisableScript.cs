using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceDisableScript : MonoBehaviour {

    void OnDisable()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Death>().safe = false;
    }
}
