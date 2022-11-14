using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// The script of movement
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
        //Update the transform.position
        transform.position= Vector3.MoveTowards(transform.position,movePoint.position,moveSpeed* Time.deltaTime);
        // Check if there is any collision, if not, move up or down according to the user input    
        if(Vector3.Distance(transform.position,movePoint.position)<=.05f){
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal"))==1f){
                if(!Physics2D.OverlapCircle(movePoint.position+new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f),.01f,stopmovement)){
                    //moveLimit should be decided by the dice point. If moveLimit is zero, character not aloowed to move
                    if (script.moveLimit !=0)
                        {movePoint.position+=new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);script.moveLimit -=1;}
                }                          
            }
            //move left or right according to the user input
            else if(Mathf.Abs(Input.GetAxisRaw("Vertical"))==1f){
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f,Input.GetAxisRaw("Vertical"), 0f), .01f, stopmovement)){
                    if (script.moveLimit !=0)
                        { movePoint.position += new Vector3(0f,Input.GetAxisRaw("Vertical"), 0f); script.moveLimit -=1;}
                }                      
            }
        }
    }
}
