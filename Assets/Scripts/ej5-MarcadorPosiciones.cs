/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 5: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script asociado a un objeto que aplica un desplazamiento
 * relativo a su posición original al pulsar la barra espaciadora.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class DesplazamientoObjeto : MonoBehaviour
{
  // Variable publica configurable desde el Inspector para cada objeto
  public Vector3 desplazamiento;

  // Guarda la posicion original del objeto al iniciar la escena
  private Vector3 _posicionOriginal;

  /*
   * Metodo Start. Almacena la posicion de partida del objeto
   */
  void Start()
  {
    GuardarPosicionOriginal();
  }

  /*
   * Metodo Update. Comprueba en cada frame si se ha pulsado la barra espaciadora
   */
  void Update()
  {
    ComprobarPulsacion();
  }

  /*
   * Metodo auxiliar para registrar la posicion inicial
   */
  private void GuardarPosicionOriginal()
  {
    _posicionOriginal = transform.position;
  }

  /*
   * Metodo para detectar la barra espaciadora y reubicar el objeto
   */
  private void ComprobarPulsacion()
  {
    // "Jump" mapea por defecto la barra espaciadora en el Input Manager de Unity
    if (Input.GetAxis("Jump") > 0)
    {
      AplicarDesplazamiento();
    }
  }

  /*
   * Aplica el desplazamiento configurado sumandolo a la posicion original
   */
  private void AplicarDesplazamiento()
  {
    transform.position = _posicionOriginal + desplazamiento;
  }
}