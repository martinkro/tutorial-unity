using UnityEngine;
using System.Collections;

public class PrefabScript : MonoBehaviour {
    /// <summary>
    /// Whenever user click on prefab, it will change color of it.
    /// </summary>
    void OnMouseDown()
    {
        this.renderer.material.color = Color.green;
    }
}
