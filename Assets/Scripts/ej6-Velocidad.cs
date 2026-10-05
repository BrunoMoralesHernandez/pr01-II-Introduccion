/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 6: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Multiplica la velocidad por el valor de los ejes horizontal
 * y vertical al presionar las teclas de flecha.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class VelocidadTeclas : MonoBehaviour
{
  // Campo velocidad modificable desde el Inspector
  public float velocidad = 5.0f;

  /*
   * Metodo Update. Se ejecuta en cada frame comprobando la pulsacion
   * de las cuatro teclas de flecha.
   */
  void Update()
  {
    ComprobarFlechas();
  }

  /*
   * Detecta que flecha esta pulsada y muestra el calculo por consola
   */
  private void ComprobarFlechas()
  {
    // Obtenemos los valores de los ejes (-1 a 1)
    float ejeHorizontal = Input.GetAxis("Horizontal");
    float ejeVertical = Input.GetAxis("Vertical");

    // Resultado de multiplicar la velocidad por ambos ejes
    float resultado = velocidad * ejeVertical * ejeHorizontal;

    // Comprobamos cada flecha y formateamos el mensaje empezando por su nombre
    if (Input.GetKey(KeyCode.UpArrow))
    {
      Debug.Log("Flecha Arriba pulsada. Resultado: " + resultado + 
                " (H: " + ejeHorizontal + ", V: " + ejeVertical + ")");
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
      Debug.Log("Flecha Abajo pulsada. Resultado: " + resultado + 
                " (H: " + ejeHorizontal + ", V: " + ejeVertical + ")");
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
      Debug.Log("Flecha Izquierda pulsada. Resultado: " + resultado + 
                " (H: " + ejeHorizontal + ", V: " + ejeVertical + ")");
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      Debug.Log("Flecha Derecha pulsada. Resultado: " + resultado + 
                " (H: " + ejeHorizontal + ", V: " + ejeVertical + ")");
    }
  }
}