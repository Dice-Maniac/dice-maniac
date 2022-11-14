using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar: MonoBehaviour
{
    // the attribute of the bar
    public Transform bar;

    // size update function
    public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    //color update function (used when hit by skills)
    public void SetColor(Color color) {
        bar.Find("health").GetComponent<SpriteRenderer>().color = color;
    }
}
