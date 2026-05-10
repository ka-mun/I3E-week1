using UnityEngine;

public class script2 : MonoBehaviour
{
    Vector3 valueToMove = new Vector3(0,0.01f,0);
    Vector3 rotationSpeed = new Vector3(50f,50f,50f);
    float limit = 1f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.localPosition += valueToMove;
        if (transform.localPosition.y >= limit || transform.localPosition.y<= -limit)
            {valueToMove = -valueToMove;
            }
        transform.Rotate(rotationSpeed*Time.deltaTime);
        
    }
}
