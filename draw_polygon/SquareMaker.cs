using UnityEngine;
using System.Collections.Generic;

public class SquareMaker : MonoBehaviour {

  public List<Vector3> points;

  void Start()
  {
    GameObject threeDSquare = new GameObject("3DSquare");
    threeDSquare.AddComponent<MeshRenderer>();
    threeDSquare.AddComponent<MeshFilter>();
    threeDSquare.GetComponent<MeshFilter>().mesh = CreateMesh(points);
  }

  private Mesh CreateMesh(List<Vector3> points)
  {
    List<int> tris = new List<int>(); // Every 3 ints represents a triangle
    List<Vector2> uvs = new List<Vector2>(); // Vertex position in 0-1 UV space
    /* 4 points in the list for the square made of two triangles:
    0 *--* 1
      | /|
      |/ |
    3 *--* 2
    */
    tris.Add(1); 
    tris.Add(2);
    tris.Add(3);
    tris.Add(3);
    tris.Add(0);
    tris.Add(1);
    // uvs determine vert (point) coordinates in uv space
    uvs.Add(new Vector2(0f, 1f));
    uvs.Add(new Vector2(1f, 1f));
    uvs.Add(new Vector2(1f, 0f));
    uvs.Add(new Vector2(0f, 0f));

    Mesh mesh = new Mesh();
    mesh.vertices = points.ToArray();
    mesh.uv = uvs.ToArray();
    mesh.triangles = tris.ToArray();
    mesh.RecalculateNormals();
    return mesh;
  }
}
