using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int movementSpeed;
    private Animator anim;
    public GameObject textObject;
    public GameObject textObject2;
    public string name1 = null;
    public string name2 = null;
  //  public GameObject thing;
 

    // Start is called before the first frame update
    void Start()
    {
        textObject.SetActive(false);
        textObject2.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetAxisRaw("Horizontal") < -0.5)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime,0f,0f));
        }
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "door" )
            {
            Debug.Log("collide");
            textObject.SetActive(true);
            if (Input.GetKeyUp(KeyCode.Space))
                {
                     SceneManager.LoadScene(name1);
                     
                }
                 
            }
        if (collision.gameObject.tag == "Certificate")
        {
            textObject2.SetActive(true);
            if (Input.GetKeyUp(KeyCode.Space))
            {
                SceneManager.LoadScene(name2);

            }
        }
        if (collision.gameObject.tag == "home")
        {
            Debug.Log("collide");
            textObject2.SetActive(true);
            if (Input.GetKeyUp(KeyCode.Space))
            {
                SceneManager.LoadScene(name2);

            }

        }




    }
    private void OnTriggerExit2D()
    {
        textObject.SetActive(false);
        textObject2.SetActive(false);
    }

}
