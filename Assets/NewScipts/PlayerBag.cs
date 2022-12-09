using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBag : MonoBehaviour
{
    public GameObject item;
    public GameObject content;
    [HideInInspector]
    public List<Sprite> playerSpr = new List<Sprite>();
    public Button btnBag;
         void Start(){
                btnBag.onClick.AddListener(OnClickBag);
          }

    public void OnClickBag()
    {
                SpawnItem();
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "good")
        {
            playerSpr.Add(collision.gameObject.GetComponent<SpriteRenderer>().sprite);
         print   (playerSpr.Count);
            Destroy(collision.gameObject);
        }
    }
   
   public void SpawnItem()
   {
    for( int i = 0 ;i < content.transform.childCount;i++)
    {
        
        Destroy(content.transform.GetChild(i).gameObject);
    }
    for(int i = 0 ;i < playerSpr.Count;i++)
    {
    print("                  " + playerSpr[i]);

        GameObject go = Instantiate(item,content.transform);        
         go.GetComponent<Image>().sprite = playerSpr[i];
         }
   }
   
}
