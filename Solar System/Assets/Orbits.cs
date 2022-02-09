using System;
using UnityEngine;
public class Orbits: MonoBehaviour {

    const float jupiterRotation = 60f/11.9f;
    const float earthRotation = 60f;
    const float mercuryRotation = 60f/.241f;
    const float venusRotation = 60f/.615f;
    const float marsRotation = 60f/1.88f;
    const float saturnRotation = 60f/29.4f;
    const float uranusRotation = 60f/83.7f;
    const float neptuneRotation = 60f/163.7f;
    const float moonRotation = 60f/0.0748f;
    [SerializeField] 
    Transform mercury, venus, earth, mars, jupiter, saturn, uranus, neptune,moon;

    void Update () {;
        float rotation = (Time.time);
        jupiter.localRotation = Quaternion.Euler(0f, jupiterRotation * rotation, 0f);
        earth.localRotation = Quaternion.Euler(0f, earthRotation * rotation, 0f);
        mercury.localRotation = Quaternion.Euler(0f, mercuryRotation * rotation, 0f);
        venus.localRotation = Quaternion.Euler(0f, venusRotation * rotation, 0f);
        mars.localRotation = Quaternion.Euler(0f, marsRotation * rotation, 0f);
        saturn.localRotation = Quaternion.Euler(0f, saturnRotation * rotation, 0f);
        uranus.localRotation = Quaternion.Euler(0f, uranusRotation * rotation, 0f);
        neptune.localRotation = Quaternion.Euler(0f, neptuneRotation * rotation, 0f);
        moon.localRotation = Quaternion.Euler(0f, moonRotation * rotation, 0f);
    }

}