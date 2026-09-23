using UnityEngine;

public class UIOverlap : MonoBehaviour
{
    public RectTransform Arrow;
    public RectTransform GreenArea; 
    public Camera Camera;
    ArrowMovement arrow;

    private void Start()
    {
        arrow = GetComponentInParent<ArrowMovement>();
    }
    void Update()
    {
        if (isOverlapping(Arrow, GreenArea, Camera) && arrow.isMoving == false)
        {
            Debug.Log("arrow in green");
        }
        else if (arrow.isMoving == false)
        {
            Debug.Log("no overlap");
        }
        
    }

    bool isOverlapping(RectTransform rect1, RectTransform rect2, Camera cam)
    {
        Rect r1 = GetScreenRect(rect1,cam); 
        Rect r2 = GetScreenRect(rect2,cam);

       
        return r1.Overlaps(r2); // returns true if overlaps
    }
    Rect GetScreenRect(RectTransform rectTransform,Camera cam)
    {
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);

        for (int i = 0; i < 4; i++)
        {
            corners[i] = RectTransformUtility.WorldToScreenPoint(cam,corners[i]);
        }

        // Compute axis-aligned bounding box (handles rotation and scaling correctly)
        float minX = Mathf.Min(corners[0].x, corners[1].x, corners[2].x, corners[3].x);
        float maxX = Mathf.Max(corners[0].x, corners[1].x, corners[2].x, corners[3].x);
        float minY = Mathf.Min(corners[0].y, corners[1].y, corners[2].y, corners[3].y);
        float maxY = Mathf.Max(corners[0].y, corners[1].y, corners[2].y, corners[3].y);

        return new Rect(minX,minY,maxX-minX,maxY-minY);
    }
}
