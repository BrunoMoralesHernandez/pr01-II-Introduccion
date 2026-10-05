/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 11: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Traslada el cubo hacia la esfera a velocidad constante
 * utilizando un vector de direccion normalizado y manteniendo su altura.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class PerseguirEsfera : MonoBehaviour
{
  // Referencia al Transform de la esfera que queremos perseguir
  public Transform targetEsfera;

  // Velocidad constante de avance en unidades por segundo
  public float speed = 3.0f;

  /*
   * Metodo Update. Se ejecuta cada frame recalculando la direccion hacia el objetivo
   */
  void Update()
  {
    PerseguirObjetivo();
  }

  /*
   * Calcula el vector direccion hacia la esfera y traslada el cubo
   */
  private void PerseguirObjetivo()
  {
    if (targetEsfera == null) return;

    // 1. Calculamos el vector direccion: Destino - Origen
    Vector3 direccion = targetEsfera.position - transform.position;

    // 2. Anulamos la componente Y para que el cubo no altere su altura
    direccion.y = 0.0f;

    // Comprobamos que no esten prácticamente en el mismo punto para evitar vibraciones
    if (direccion.magnitude > 0.1f)
    {
      // 3. Normalizamos el vector para que su magnitud sea 1
      Vector3 direccionNormalizada = direccion.normalized;

      // 4. Trasladamos en el espacio del mundo independientemente de los FPS
      transform.Translate(direccionNormalizada * speed * Time.deltaTime, Space.World);
    }
  }
}