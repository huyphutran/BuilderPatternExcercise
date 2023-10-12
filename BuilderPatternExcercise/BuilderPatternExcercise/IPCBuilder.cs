namespace BuilderPatternExcercise
{
    public interface IPCBuilder
    {
        //Create Interface for Builder
        IPCBuilder GetCpu(string Cpu);
        IPCBuilder GetRam(string Ram);

        IPCBuilder GetVga(string Vga);

        IPCBuilder GetMain(string Main);

        PC Build();

    }
}
