﻿using UnityEngine;
using System.Collections;

/// <summary>
/// The base class for all RPGStatModifiers
/// </summary>
public abstract class RPGStatModifier {
    /// <summary>
    /// The order in which the modifier is applied to the stat
    /// </summary>
    public abstract int Order { get; }

    /// <summary>
    /// The value of the modifier that is combined with other
    /// modifiers of the same stat then is passed to ApplyModifier
    /// method to determine the final modifier value to apply to the stat
    /// </summary>
    public float Value { get; set; }

    /// <summary>
    /// Does the modifier's value stat with other modifiers of the 
    /// same type. If value is false, the value of the single modifier will be used
    /// if the sum of stacking modifiers is not greater then the not statcking mod.
    /// </summary>
    public bool Stacks { get; set; }

    /// <summary>
    /// Default Constructer
    /// </summary>
    public RPGStatModifier() {
        Value = 0;
        Stacks = true;
    }

    /// <summary>
    /// Constructs a Stat Modifier with the given value and stack set to true
    /// </summary>
    public RPGStatModifier(float value) {
        Value = value;
        Stacks = true;
    }

    /// <summary>
    /// Constructs a Stat Modifier with the given value and stack value
    /// </summary>
    public RPGStatModifier(float value, bool stacks) {
        Value = value;
        Stacks = stacks;
    }

    /// <summary>
    /// Calculates the amount to apply to the stat based off the 
    /// sum of all the stat modifier's value and the current value of
    /// the stat.
    /// </summary>
    public abstract int ApplyModifier(int statValue, float modValue);
}
