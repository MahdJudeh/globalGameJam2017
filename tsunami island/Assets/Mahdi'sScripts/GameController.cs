using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject Moon;
    public GameObject Sun;
    public GameObject Ocean;
    public GameObject Log;
    public GameObject Spawner;
    public Text dayText;
    public float timeSpeed;
    private float rotation = .003f;
    private int spawnCounter;
    private int spawnCounter2;
    private bool initialSpawn;

    void Start()
    {
        initialSpawn = false;
        spawnCounter = 1;
        spawnCounter2 = 1;
    }


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
            Ocean.transform.localScale += new Vector3(0f, 0.0006f*timeSpeed, 0f);
        }
        else
        {
            Moon.SetActive(false);
            Sun.SetActive(true);
            Ocean.transform.localScale -= new Vector3(0f, 0.0004f*timeSpeed, 0f);
        }

        Sun.transform.rotation = Quaternion.Euler(Time.time*timeSpeed, -90, 0);
        Moon.transform.rotation = Quaternion.Euler(Time.time*timeSpeed-180, -90, 0);
        dayText.text = "Day: " + (int)(Time.time * timeSpeed / 360);

        if (((int)(Mathf.Floor(Time.time * timeSpeed)) % 360 == 0))
        {
            if (initialSpawn == false && (int)(Mathf.Floor(Time.time * timeSpeed)) / 360 == 0)
            {
                for (int i = 0; i < 18; i++)
                    Instantiate(Log, new Vector3(Random.Range(-10f, 10.0f), GameObject.FindGameObjectWithTag("beach1").GetComponent<Transform>().position.y, Random.Range(15.0f, 15.5f)), Quaternion.Euler(0, 180, 0));
                initialSpawn = true;
            }
            else if ((int)(Mathf.Floor(Time.time * timeSpeed)) / 360 >spawnCounter ){
                for (int i = 0; i < Random.Range(5,10); i++)
                    Instantiate(Log, new Vector3(Random.Range(-10f, 10.0f), GameObject.FindGameObjectWithTag("beach1").GetComponent<Transform>().position.y, Random.Range(15.0f, 15.5f)), Quaternion.Euler(0, 180, 0));
                spawnCounter++;
            }
            if ((int)(Mathf.Floor(Time.time * timeSpeed)) / 360 > spawnCounter2)
            {
                for (int i = 0; i < Random.Range(5, 10); i++)
                    Instantiate(Log, new Vector3(Random.Range(4.0f, 11.0f), GameObject.FindGameObjectWithTag("beach2").GetComponent<Transform>().position.y, Random.Range(-4.0f, 6.0f)), Quaternion.Euler(0, 180, 0));
                spawnCounter2++;
            }
        }
    }
}
