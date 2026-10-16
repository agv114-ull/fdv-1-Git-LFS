using UnityEngine;

public class ScriptTarea11 : MonoBehaviour
{   
    GUIStyle estilo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log("Script tarea 1.1");

    }

    // para que aparezca el mensaje en pantalla, con el sistema UI antiguo de unity 
    void OnGUI() 
    {
        if (estilo == null) estilo = new GUIStyle(GUI.skin.label) { fontSize = 32 };
        GUI.Label(new Rect(20, 20, 600, 50), "Script tarea 1.1", estilo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
