using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinType Type;
    public DestroyType DType;
    


    public class CoinTypeSpecification : ISpecification<Coin>
    {
        private readonly CoinType _type;

        public CoinTypeSpecification(CoinType type)
        {
            _type = type;
        }

        public bool IsClassified(Coin item) => item.Type == _type;
    }

    public class DestroyableSpecification : ISpecification<Coin>
    {
        private readonly DestroyType _type;

        public DestroyableSpecification(DestroyType type)
        {
            _type = type;
        }

        public bool IsClassified(Coin item) => item.DType == _type;
    }

    public enum CoinType
    {
        GOOD,
        BAD,
    }

    public enum DestroyType
    {
        FAST,
        SLOW,
        NONE,
    }



    public DamageType DamagType;

    public class DamageTypeSpecification : ISpecification<Coin>
    {
        private readonly DamageType _type;

        public DamageTypeSpecification(DamageType type)
        {
            _type = type;
        }

        public bool IsClassified(Coin item) => item.DamagType == _type;
    }


    public enum DamageType
    {
        LETHAL,
        POISON,
        FIRE,
        ARCANE,
        ICE

    }

}
