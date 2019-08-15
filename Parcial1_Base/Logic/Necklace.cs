namespace Parcial1_Base.Logic
{
    public class Necklace : Accessory
    {
        int amount = 0;

        public Necklace(int style) : base(style)
        {
            if (amount<1)
            {

            }
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Accessory object with the same values of this instance</returns>
        public override Accessory Copy()
        {
            return new Necklace(style);
        }
    }
}