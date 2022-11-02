using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask stopmovement;
    public gamecontrol script;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent=null;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (script.moveLimit !=0)
        {
            transform.position= Vector3.MoveTowards(transform.position,movePoint.position,moveSpeed* Time.deltaTime);
            if(Vector3.Distance(transform.position,movePoint.position)<=.05f){
                if(Mathf.Abs(Input.GetAxisRaw("Horizontal"))==1f){
                    if(!Physics2D.OverlapCircle(movePoint.position+new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f),.01f,stopmovement))
                        {movePoint.position+=new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);script.moveLimit -=1;}
                }
                else if(Mathf.Abs(Input.GetAxisRaw("Vertical"))==1f){
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f,Input.GetAxisRaw("Vertical"), 0f), .01f, stopmovement))
                        { movePoint.position += new Vector3(0f,Input.GetAxisRaw("Vertical"), 0f); script.moveLimit -=1;}
                }
            }
        }
        

        
    }
}
