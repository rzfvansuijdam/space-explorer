﻿ using UnityEngine;
 using System.Collections;

 public class kill_script : MonoBehaviour 
 {


     // Use this for initialization
    void Start () 
    {

    }

     // Update is called once per frame
     void Update () 
    {

    }

    void OnMouseDown()
    {
        // Destroy game object
        Destroy (this.gameObject);
    }
 }