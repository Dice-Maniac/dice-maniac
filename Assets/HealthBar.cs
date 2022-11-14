using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar: MonoBehaviour
{
    public Transform bar;

    // size update function
    public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    //color update function
    public void SetColor(Color color) {
        bar.Find("health").GetComponent<SpriteRenderer>().color = color;
    }
}
