/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 1: Introducción C# 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Primer ejercicio de la hoja de problemas. Script para cambiar
 * el color de un objeto de la escena
 * @date Sep 28 2026
 * @version 1.0
 */

using UnityEngine;

public class ColorChanger : MonoBehaviour 
{
  // Atributos
  [SerializeField] private int _intervaloFrames = 120;
  private float[] color = new float[3];
  private Renderer actualObject;
  private int frameCounter = 0;

  /*
   * Metodo start. Lee el comenente y ejecuta el cambio de color
   */
  void Start() 
  {
    actualObject = GetComponent<Renderer>();
    ApplyColor();
  }

  /*
   * Metodo Update. En cada frame revisa si ya ha pasado el numero de frames
   * establecido para cambiar de color. En dicho caso, cambia el color y 
   * reestablece el contador.
  */
  void Update() 
  {
    frameCounter++;

    if (frameCounter >= _intervaloFrames) {
      int randomChannel = Random.Range(0, 3);
      color[randomChannel] = Random.value;
      ApplyColor();
      frameCounter = 0;
    }
  }

  /*
   * Metoda para hacer el cambio de color. Crea un color a partir del atributo
   * color de la clase y se lo asigna al objeto
   */
  void ApplyColor() 
  {
    Color newColor = new Color(color[0], color[1], color[2], 1.0f);
    actualObject.material.color = newColor;
  }
}