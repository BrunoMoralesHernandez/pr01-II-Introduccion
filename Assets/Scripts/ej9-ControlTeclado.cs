/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 9: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Permite controlar el cubo mediante las teclas de flecha y
 * la esfera mediante las teclas WASD a una velocidad configurable.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class ControlTeclado : MonoBehaviour
{
  // Permite elegir desde el Inspector que tipo de control usara este objeto
  public enum TipoControl { CuboFlechas, EsferaWASD }
  public TipoControl tipoControl = TipoControl.CuboFlechas;

  // Velocidad de desplazamiento
  public float speed = 0.05f;

  // Permite alternar si el eje vertical es la altura (Y) o profundidad en el suelo (Z)
  public bool moverEnSuelo3D = false;

  /*
   * Metodo Update. Lee las pulsaciones de teclado correspondientes en cada frame
   */
  void Update()
  {
    ProcesarMovimiento();
  }

  /*
   * Determina la direccion segun el esquema de control asignado y traslada el objeto
   */
  private void ProcesarMovimiento()
  {
    float horizontal = 0.0f;
    float vertical = 0.0f;

    // Control para el Cubo usando las teclas de flecha
    if (tipoControl == TipoControl.CuboFlechas)
    {
      if (Input.GetKey(KeyCode.RightArrow)) horizontal += 1.0f;
      if (Input.GetKey(KeyCode.LeftArrow)) horizontal -= 1.0f;
      if (Input.GetKey(KeyCode.UpArrow)) vertical += 1.0f;
      if (Input.GetKey(KeyCode.DownArrow)) vertical -= 1.0f;
    }
    // Control para la Esfera usando WASD
    else if (tipoControl == TipoControl.EsferaWASD)
    {
      if (Input.GetKey(KeyCode.D)) horizontal += 1.0f;
      if (Input.GetKey(KeyCode.A)) horizontal -= 1.0f;
      if (Input.GetKey(KeyCode.W)) vertical += 1.0f;
      if (Input.GetKey(KeyCode.S)) vertical -= 1.0f;
    }

    // Construimos el vector de direccion
    Vector3 direccion;
    if (moverEnSuelo3D)
    {
      // Horizontal = X, Vertical = Z (profundidad en el plano suelo)
      direccion = new Vector3(horizontal, 0.0f, vertical);
    }
    else
    {
      // Horizontal = X, Vertical = Y (altura clásica de los ejes 2D)
      direccion = new Vector3(horizontal, vertical, 0.0f);
    }

    // Aplicamos la traslacion proporcional a speed
    transform.Translate(direccion * speed, Space.World);
  }
}