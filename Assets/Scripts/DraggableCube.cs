using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableCube : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<BoxCollider2D>().attachedRigidbody;
    }

    public GameObject selectedObject;
    Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject && targetObject.transform.gameObject.tag == "Draggable")
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.localPosition - mousePosition;
            }
        }
        if (selectedObject)
        {
            rb.velocity = new Vector3(0, 0, 0);
            selectedObject.transform.position = mousePosition + offset;
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }
}
