


using UnityEngine;

public class starst : MonoBehaviour
{

    public GameObject plane;
    int count = 2;
    float timer;
    public GameObject reference;
    public GameObject box;


    // Start is called before the first frame update
    void Start()
    {
        GameObject plane2 = Instantiate(plane, new Vector3(0, 8, 0), Quaternion.identity);
        plane2.transform.Rotate(0f, 0, 180f);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(plane, new Vector3(0, 0, 3 * i), Quaternion.identity);
            GameObject plane1 = Instantiate(plane, new Vector3(0, 8, 3 * i), Quaternion.identity);
            plane1.transform.Rotate(0f, 0f, 180f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(-12.5f, 12.5f);
        float random2 = Random.Range(-12.5f, 12.5f);

        

        timer += Time.deltaTime;
        if (reference.transform.position.z > -15)
        {
            count += 1;
            Instantiate(plane, new Vector3(0, 0, 3 * count-3), Quaternion.identity);
            GameObject plane1 = Instantiate(plane, new Vector3(0, 8, 3 * count-3), Quaternion.identity);
            plane1.transform.Rotate(0f, 0f, 180f);
            timer = 0;
        }
        else
        {
            if (timer >= 0.6)
            {
                GameObject bottomPlane = Instantiate(plane, new Vector3(0, 0, 3 * count - 3), Quaternion.identity);
                GameObject topPlane = Instantiate(plane, new Vector3(0, 8, 3 * count - 3), Quaternion.identity);
                topPlane.transform.Rotate(0f, 0f, 180f);


                foreach (Transform transform in topPlane.transform)
                {
                    float random3 = Random.Range(0f, 8f);
                    if (random3 < 3)
                    {
                        DestroyImmediate(transform.gameObject);
                    }

                }
                foreach (Transform transform in bottomPlane.transform)
                {
                    float random3 = Random.Range(0f, 8f);
                    if (random3 < 2)
                    {
                        DestroyImmediate(transform.gameObject);
                    }

                }
                float box1 = Random.Range(0f, 8f);
                float box2 = Random.Range(0f, 8f);
                if (box1 < 4.5)
                {
                    Instantiate(box, new Vector3(random, 0.5f, 3 * count), Quaternion.identity);
                }
                if (box2 < 4.5)
                { 
                    Instantiate(box, new Vector3(random2, 7.5f, 3 * count), Quaternion.identity);
                }
                timer = 0;
            }
        }
        
        
    }
}
