/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 10: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Adapta el movimiento del ejercicio 9 escalando el desplazamiento
 * con Time.deltaTime para lograr un movimiento independiente de los FPS.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class ControlTecladoDeltaTime : MonoBehaviour
{
  // Tipo de control a utilizar por la entidad
  public enum TipoControl { CuboFlechas, EsferaWASD }
  public TipoControl tipoControl = TipoControl.CuboFlechas;

  // Velocidad de movimiento en unidades (metros) por segundo
  public float speed = 5.0f;

  // Permite desplazarse sobre el plano suelo (X, Z) en lugar de altura (X, Y)
  public bool moverEnSuelo3D = true;

  /*
   * Metodo Update. Se ejecuta cada frame aplicando la traslacion proporcional al tiempo
   */
  void Update()
  {
    ProcesarMovimiento();
  }

  /*
   * Calcula el vector direccion y traslada la entidad usando Time.deltaTime
   */
  private void ProcesarMovimiento()
  {
    float horizontal = 0.0f;
    float vertical = 0.0f;

    // Lectura para el cubo con teclas de flecha
    if (tipoControl == TipoControl.CuboFlechas)
    {
      if (Input.GetKey(KeyCode.RightArrow)) horizontal += 1.0f;
      if (Input.GetKey(KeyCode.LeftArrow)) horizontal -= 1.0f;
      if (Input.GetKey(KeyCode.UpArrow)) vertical += 1.0f;
      if (Input.GetKey(KeyCode.DownArrow)) vertical -= 1.0f;
    }
    // Lectura para la esfera con WASD
    else if (tipoControl == TipoControl.EsferaWASD)
    {
      if (Input.GetKey(KeyCode.D)) horizontal += 1.0f;
      if (Input.GetKey(KeyCode.A)) horizontal -= 1.0f;
      if (Input.GetKey(KeyCode.W)) vertical += 1.0f;
      if (Input.GetKey(KeyCode.S)) vertical -= 1.0f;
    }

    // Determinamos la orientacion del plano de movimiento
    Vector3 direccion;
    if (moverEnSuelo3D)
    {
      direccion = new Vector3(horizontal, 0.0f, vertical);
    }
    else
    {
      direccion = new Vector3(horizontal, vertical, 0.0f);
    }

    // Escalamos el desplazamiento con Time.deltaTime
    Vector3 desplazamiento = direccion * speed * Time.deltaTime;

    // Aplicamos la traslacion en el espacio mundial
    transform.Translate(desplazamiento, Space.World);
  }
}