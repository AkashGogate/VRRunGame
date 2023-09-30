
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballMove : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        
        rb = gameObject.GetComponent<Rigidbody>();
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x<13.5)
        {
            rb.AddForce(new Vector3(0.2f, 0f, 0f), ForceMode.Impulse);
        }
        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > -13.5)
        {
            rb.AddForce(new Vector3(-0.2f, 0f, 0f), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<4.25 && transform.position.y < 0.75)
        {
            rb.AddForce(new Vector3(0f, 10f,0f), ForceMode.Impulse);
        }
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 1)
        {
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("floor");
            foreach (GameObject obst in obstacles) {
                if(obst.transform.position.y == 0)
                {
                    obst.transform.position = new Vector3(obst.transform.position.x, 8,obst.transform.position.z);
                    obst.transform.Rotate(0f, 0f, 180f);
                }
                else if (obst.transform.position.y == 8)
                {
                    obst.transform.position = new Vector3(obst.transform.position.x, 0, obst.transform.position.z);
                    obst.transform.Rotate(0f, 0f, 180f);
                }

                else if (obst.transform.position.y == 0.5)
                {
                    obst.transform.position = new Vector3(obst.transform.position.x * (-1f), 7.5f, obst.transform.position.z);
                    obst.transform.Rotate(0f, 0f, 180f);
                }
                
                else if(obst.transform.position.y == 7.5)
                {
                    obst.transform.position = new Vector3(obst.transform.position.x*(-1f), 0.5f, obst.transform.position.z);
                    obst.transform.Rotate(0f, 0f, 180f);
                }

            }
            transform.position = new Vector3(transform.position.x, 7.5f, transform.position.z);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "log(Clone)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
