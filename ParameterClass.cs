namespace MoshHamedaniProjects
{

    class UseParamClass
    {
        public void callingMethod(ParameterClass p)
        {
            p.Name = "DR";
            System.Console.WriteLine(p.Name);

            System.Console.WriteLine(p.method(10));
        }
    }
    class ParameterClass
    {
        public string Name { get; set; }

        public int method(int a)
        {
            return a;
        }
    }
}
