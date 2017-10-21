using System.Collections;
using UnityEngine;

public class CatToMove : MonoBehaviour {
    public Transform startMarker;
    public Vector3 endMarker;
    private float speed = 0.05F;
    private float startTime;
    private float journeyLength;
    public GameObject textMove;

    void Start()
    {
        //initially, the object will not move when the journeyLength is 0
        journeyLength = 0;   
    }

    void Update()
    {
        textMove.GetComponent<TextMesh>().text = "pos:" + this.transform.position;

       
        if (journeyLength > 0)
        {
            //distance 
            float distCovered = (Time.time - startTime) * speed;
            //percentage of distance moved
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker, fracJourney);
            
        }
    }

    //send the endPos from HelloAR script when "Hit Made" to know where to go
    public void StartMove(Vector3 endPos)
    {
        startMarker = this.transform;
        endMarker = endPos;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker);
        Debug.Log("journeyLength is " + journeyLength);
    }
}
