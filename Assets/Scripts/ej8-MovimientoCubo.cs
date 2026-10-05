/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 8: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Traslada continuamente un objeto en base a un vector de dirección
 * y una velocidad configurables desde el Inspector.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
  // Vector de direccion del movimiento configurable desde el Inspector
  public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);

  // Velocidad del movimiento (inicialmente > 1)
  public float speed = 2.0f;

  // Permite alternar entre espacio local y mundial para el apartado e
  public bool usarEspacioMundial = false;

  /*
   * Metodo Update. Se ejecuta en cada iteracion aplicando la traslacion
   */
  void Update()
  {
    MoverObjeto();
  }

  /*
   * Aplica la traslacion proporcional al vector direccion y a la velocidad
   */
  private void MoverObjeto()
  {
    // Calculamos el desplazamiento del frame
    Vector3 desplazamiento = moveDirection * speed;

    if (usarEspacioMundial)
    {
      // Movimiento respecto al sistema de coordenadas global del mundo
      transform.Translate(desplazamiento, Space.World);
    }
    else
    {
      // Por defecto Translate utiliza el sistema de coordenadas local
      transform.Translate(desplazamiento, Space.Self);
    }
  }
}