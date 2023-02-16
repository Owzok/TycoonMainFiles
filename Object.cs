using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movementDirection;
    public float speed = 0.1f;
    public float movementSpeed;
    bool going_hor = false;
    private GameHandle gh;
    public GameObject fx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gh = GameObject.FindWithTag("GameController").GetComponent<GameHandle>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(movementSpeed * horizontal, movementSpeed * vertical, 0) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "ConveyorHor"){
            going_hor = true;
        }
        if(col.gameObject.tag == "ConveyorVer"){
            going_hor = false;
        }
        //Debug.Log("Entered: " + col.gameObject.tag);

        if(col.gameObject.tag == "Furnace"){
            Instantiate(fx, transform.position, transform.rotation);
            gh.money += 1;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "ConveyorVer"){
            rb.velocity = new Vector2(-0.2f * speed, -0.1f * speed);
        }
        if(col.gameObject.tag == "ConveyorHor"){
            rb.velocity = new Vector2(0.2f * speed, -0.1f * speed);
        }
    }

    void OnTriggerExit2D(Collider2D col){
        //Debug.Log("Exit: " + col.gameObject.tag);
    }
}
