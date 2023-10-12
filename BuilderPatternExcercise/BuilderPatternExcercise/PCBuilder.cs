namespace BuilderPatternExcercise
{
    public class PCBuilder : IPCBuilder
    {
        private PC pc = new PC();
        public IPCBuilder GetCpu(string cpu)
        {
            pc.Cpu = cpu;
            return this;
        }

        public IPCBuilder GetRam(string ram)
        {
            pc.Ram = ram;
            return this;
        }

        public IPCBuilder GetVga(string vga)
        {
            pc.Vga = vga;
            return this;
        }
        public IPCBuilder GetMain(string main)
        {
            pc.Main = main;
            return this;
        }


        public PC Build() {
        
            return pc;
        }


    }
}
