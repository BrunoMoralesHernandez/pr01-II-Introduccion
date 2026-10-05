/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 7: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Comprueba el funcionamiento de la accion 'disparo' mapeada
 * a la tecla H mediante el Input Manager.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class DisparoController : MonoBehaviour
{
  /*
   * Metodo Update. Escucha si el usuario ejecuta la accion 'disparo'
   */
  void Update()
  {
    ComprobarDisparo();
  }

  /*
   * Comprueba si el boton virtual configurado en el Input Manager ha sido presionado
   */
  private void ComprobarDisparo()
  {
    // Input.GetButtonDown devuelve true en el instante exacto en que se presiona la tecla asociada
    if (Input.GetButtonDown("disparo"))
    {
      Debug.Log("¡Pum! Disparo efectuado mediante la tecla H.");
    }
  }
}