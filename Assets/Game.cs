using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public Animator anim;
    public GameObject player;
    public int heldDownFor = 0;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Act();
        }

        if (heldDownFor >= 5) {
            Act();
        }
        heldDownFor = Input.GetKey(KeyCode.Space) ? heldDownFor + 1 : 0;
    }

    void Act() {
        if ((heldDownFor >= 25 && heldDownFor % 25 == 0) || heldDownFor == 0)
            anim.SetBool("Inverted", !anim.GetBool("Inverted"));
        player.transform.Rotate(new Vector3(0, 0, -15 * Time.deltaTime));
    }
}
