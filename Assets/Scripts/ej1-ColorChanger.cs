/**
*/

using System.Runtime.Versioning;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
  public int IntervaloFrames = 120;

  private float[] color = new float[3];
  private Renderer objeto;
  private int frameCounter = 0;

  void Start()
  {
    objeto = GetComponent<Renderer>();
    ApplyColor();
  }

  void Update()
  {
    frameCounter++;

    // Al alcanzar la cantidad de frames configurada
    if (frameCounter >= IntervaloFrames)
    {
      // Elegimos un canal aleatorio (0, 1 o 2) y cambiamos su valor
      int randomChannel = Random.Range(0, 3);
      color[randomChannel] = Random.value;

      ApplyColor();
      frameCounter = 0; // Reiniciamos el contador
    }
  }

  void ApplyColor()
  {
    // El cuarto parámetro es el canal Alfa (opacidad = 1.0f)
    Color newColor = new Color(color[0], color[1], color[2], 1.0f);
    objeto.material.color = newColor;
  }
}