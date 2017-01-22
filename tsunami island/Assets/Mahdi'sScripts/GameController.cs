using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject Moon;
    public GameObject Sun;
    public GameObject Ocean;
    public Text dayText;
    public float timeSpeed;
    private float rotation = .003f;


    // Update is called once per frame
    void Update()
    {
        //int rand = Random.Range(0, max);
        //if (Time.time-Time.timeSinceLevelLoad>)
        //{
        //    Ocean.transform.localScale += new Vector3(0f, 0.001f, 0f);
        //    Sun.transform.Rotate(rotation, 0f, 0f);
        //    time += 2;
        //    if (time == 7200)
        //    {
        //        time
        //        Sun.GetComponent<Light>().enabled = false;
        //        Moon.GetComponent<Light>().enabled = true;
        //        Sun.transform.position = new Vector3(50f, 0f, 0f);
        //        Sun.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
        //    }
        //}
        //else if (time < 10800)
        //{
        //    Ocean.transform.localScale -= new Vector3(0f, 0.0006f, 0f);
        //    Moon.transform.Rotate(rotation, 0f, 0f);
        //    time += 2;
        //    if (time == 10800)
        //    {
        //        Moon.GetComponent<Light>().enabled = false;
        //        time = 0;
        //        day++;
        //    }
        //}
        if ((Time.time * timeSpeed) % 360 > 180)
        {
            Moon.SetActive(true);
            Sun.SetActive(false);
            Ocean.transform.localScale += new Vector3(0f, 0.0008f*timeSpeed, 0f);

        }
        else
        {
            Moon.SetActive(false);
            Sun.SetActive(true);
            Ocean.transform.localScale -= new Vector3(0f, 0.0006f*timeSpeed, 0f);
        }

        Sun.transform.rotation = Quaternion.Euler(Time.time*timeSpeed, -90, 0);
        Moon.transform.rotation = Quaternion.Euler(Time.time*timeSpeed-180, -90, 0);
        dayText.text = "Day: " + (int)(Time.time * timeSpeed / 360);
    }
}
