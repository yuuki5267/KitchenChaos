using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IHasProgress
{
    public event EventHandler<OnProgresChangedEventArgs> OnProgressChanged;
    public class OnProgresChangedEventArgs : EventArgs {
        public float progressNormalized;
    }
}
