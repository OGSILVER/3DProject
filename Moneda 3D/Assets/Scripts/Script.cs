using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;
    public GameObject lvlComplete;
    public GameObject scoreText;

   
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "coin")
        {
            Score.scoreValue += 1;
            Destroy(col.gameObject);
        }    //On hit -> Pickup coin
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        lvlComplete.SetActive(false);
        scoreText.SetActive(true);
    }
    

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(x, rb.velocity.y ,z) * speed;    //Movement
        


        if(Score.scoreValue == 5)                            //Level complete trigger
        {
            lvlComplete.SetActive(true);
            //scoreText.SetActive(false);
        }


    }
    
}
