using System.Collections.Generic;

using UnityEngine.EventSystems;

using UnityEngine;

public class Shoot : MonoBehaviour
{


    public Transform TheLaser;
    public int ShootTimer = 0;
    public bool Fire;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
     void Update()
    {
        ShootTimer++;




        if (!HI())
        {
            if (Input.GetMouseButton(0) && ShootTimer >= 10)
            {

                ShootTimer = 0;
                Instantiate(TheLaser, transform.position, transform.rotation);
            }

        }



    
    }
     private bool HI()
    {

        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;

    }
}
