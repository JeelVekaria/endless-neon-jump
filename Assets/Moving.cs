using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour{
    
    public float speed;
    // Start is called before the first frame update
    void Start(){
        speed=1.2f;
    }

    // Update is called once per frame
    void Update(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
