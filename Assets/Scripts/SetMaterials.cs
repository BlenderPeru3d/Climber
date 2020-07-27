using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterials : MonoBehaviour
{
    [SerializeField]
    private Vector3[] vertices;
    public Vector3[] Vertices
    {
        get { return vertices; }
        set { vertices = value; }
    }
    [SerializeField]
    private int[] triangles;
    public int[] Triangles
    {
        get { return triangles; }
        set { triangles = value; }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
