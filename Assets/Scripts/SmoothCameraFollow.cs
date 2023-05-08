using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    
    private Transform target;    // The object that the camera will follow
    public float smoothing = 5f;    // The smoothing factor for the camera movement
    private GameObject harry;
    private GameObject grace;
    private Vector3 offset;    // The initial offset between the camera and the target

    private bool isFrozen_Player1 = false;
 
    void Start()
    {
        harry = GameObject.FindGameObjectWithTag("Harry");
        // grace = GameObject.FindGameObjectWithTag("Grace");
        target = harry.GetComponent<Transform>();

        // Calculate the initial offset between the camera and the target
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            harry = GameObject.FindGameObjectWithTag("Harry");
            grace = GameObject.FindGameObjectWithTag("Grace");
            if (isFrozen_Player1)
            {
                isFrozen_Player1 = false;
                target = grace.GetComponent<Transform>();

            }
            else
            {
                isFrozen_Player1 = true;
                target = harry.GetComponent<Transform>();
            }
        }
        // Calculate the desired position for the camera
        Vector3 targetPosition = target.position + offset;

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
