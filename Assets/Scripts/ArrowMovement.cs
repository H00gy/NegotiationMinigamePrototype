using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 startPos;

    public float distance; // How far it moves in pixels
    public float speed;      // How fast it moves

    public bool isMoving = true;

    void Start()
    {
        speed = Random.Range(1, 3); 
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = false;



        }


        // Apply movment
        if (isMoving)
        {
            // PingPong creates a smooth looping value between 0 and distance * 2
            float movement = Mathf.PingPong(Time.time * speed * distance, distance * 2) - distance;
            rectTransform.anchoredPosition = new Vector2(startPos.x + movement, startPos.y);
        }
        

        
    }
    
}
