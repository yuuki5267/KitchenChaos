using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingrCounterVisual : MonoBehaviour
{
    private const string CUT = "Cut";

    [SerializeField] private CuttingCounter cuttingCounter;
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Start() {
        cuttingCounter.Oncut += CuttingCounter_Oncut;
    }

    private void CuttingCounter_Oncut(object sender, System.EventArgs e) {
        animator.SetTrigger(CUT);
    }

}
