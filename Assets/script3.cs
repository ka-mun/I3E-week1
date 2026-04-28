using UnityEngine;

public class script3 : MonoBehaviour
{
    Vector3 valueToMove = new Vector3(0f,0f,0.01f);
    Vector3 rotationSpeed = new Vector3(50f,50f,50f);
    float limit = 1f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.localPosition += valueToMove;
        if (transform.localPosition.z >= limit || transform.localPosition.z<= -limit)
            {valueToMove.z = -valueToMove.z;
            }
        transform.Rotate(rotationSpeed*Time.deltaTime);
        
    }
}
