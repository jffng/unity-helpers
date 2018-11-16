using UnityEngine;
using System.Collections;

public static class Helper
{
  public static GameObject CreatePlate(float width, float height, float xPos, float yPos, float zPos)
  {
    GameObject pl = new GameObject("Plane");
    MeshFilter mf = go.AddComponent(typeof(MeshFilter)) as MeshFilter;
    MeshRenderer mr = go.AddComponent(typeof(MeshRenderer)) as MeshRenderer;

    Mesh m = new Mesh();
    m.vertices = new Vector3[]
    {
      new Vector3(0,0,0),
      new Vector3(width,0,0),
      new Vector3(width,height,0),
      new Vector3(0,height,0)
    };

    Vector3[] temp= m.vertices;

    for (var i = 0; i < temp.Length; i++){
      temp[i] += Vector3(xPos, yPos, zPos);
    }

    m.vertices = temp;

    m.uv = new Vector2[]
    {
      new Vector2(0,0),
      new Vector2(0,1),
      new Vector2(1,1),
      new Vector2(1,0)
    };

    m.triangles = new int[]{0,1,2,0,2,3};

    mf.mesh = m;
    m.RecalculateBounds();
    m.RecalculateNormals();

    return pl
  }
}
