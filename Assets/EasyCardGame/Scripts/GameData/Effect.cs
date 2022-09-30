using System;

namespace CardGame.GameData
{
    [Serializable]
    public class Effect {
        public enum EffectTypes {
            Physical,
            Fire,
            Cold,
            Magnetic,
            Elemental,
            NumOfEffects
        }

        public EffectTypes EffectType;
        public int Power;
        public int RangedPower;

        public Effect(EffectTypes EffectType) {
            this.EffectType = EffectType;
        }
    }
}