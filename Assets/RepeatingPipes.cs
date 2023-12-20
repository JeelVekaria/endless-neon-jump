using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingPipes : MonoBehaviour
{
    public float interval = 1;
    private float timer = 0;
    public float height;
    public GameObject Pipes;

    // Update is called once per frame
    void Update()
    {
        if(timer>interval){
            GameObject newPipe = Instantiate(Pipes);

            newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height, height),0);
            Destroy(newPipe,15);
            timer=0;
        }
        timer+= Time.deltaTime;
        
    }
}
