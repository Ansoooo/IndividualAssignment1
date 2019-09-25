using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class move : MonoBehaviour
{
    const string DLL_NAME = "A1"; // <- change dll name to name of dll
    [DllImport(DLL_NAME)]
    private static extern void savePosiToText(float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern int getPosiFromText();
    [DllImport(DLL_NAME)]
    private static extern float getPosiFromTextX();
    [DllImport(DLL_NAME)]
    private static extern float getPosiFromTextY();
    [DllImport(DLL_NAME)]
    private static extern float getPosiFromTextZ();

    private void Start()
    {
        Debug.Log("WASD to move, Q to save, E to load");
    }

    // Update is called once per frame
    void Update()
    {
        // HORIZONTAL PLANAR MOVEMENTS
        if (Input.GetKey(KeyCode.W)) // Forward
        {
            transform.Translate(0f, 0f, 30f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) // Backward
        {
            transform.Translate(0f, 0f, -30f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) // Left
        {
            transform.Translate(-30f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D)) // Right
        {
            transform.Translate(30f * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            savePosiToText(transform.position.x, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.E))
        {
            getPosiFromText();
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(getPosiFromTextX(), getPosiFromTextY(), getPosiFromTextZ()), 100 * Time.deltaTime);
        }
    }
}
