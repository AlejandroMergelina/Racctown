using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatModifierSO : ScriptableObject
{

    public abstract void AffectCharacter(CharacterSO character, float val);

}
