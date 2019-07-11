namespace AdapterPattern_Object
{
    public class Adapter : IExpectedInterface
    {
        private TargetClass target;

        public Adapter(TargetClass target)
        {

        }

        public void MethodA()
        {
            target.MethodB();
        }


    }
}
