using System;

namespace BuilderPatternExcercise
{
   public class PC
    {
        public string Cpu;
        public string Ram;
        public string Vga;
        public string Main;

        public override string ToString() {
            return $"PC I want to build will have CPU: {Cpu}, RAM: {Ram}, VGA: {Vga}, MAIN: {Main}";
        }

    }
}
