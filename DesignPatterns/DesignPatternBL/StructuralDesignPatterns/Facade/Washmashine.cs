
namespace Facade
{
    public class Washmashine
    {
        private readonly Washing washing;
        private readonly Squeeze squeeze;

        public Washmashine(Washing washing, Squeeze squeeze)
        {
            this.washing = washing;
            this.squeeze = squeeze;
        }

        public void CottonWashing()
        {
            washing.OrdinaryWash();
            squeeze.IntermediateSqueeze();
            squeeze.FinalSqueeze();
        }

        public void SyntheticsWashing()
        {
            washing.DelicateWash();
            squeeze.DelicateSqueeze();
        }
    }
}
