namespace Workshop
{
    public abstract class MotherBoard{
        protected string processor = "";
        public string Processor {get {return processor;} set{processor = value;}}
        protected string cooler = "";
        public string Cooler {get {return cooler;} set{cooler = value;}}
        protected int memory;
        public int Memory {get {return memory;} set{memory = value;}}
        protected int psu_wats;
        public int Psu_wats {get {return psu_wats;} set{psu_wats = value;}}
        protected int fps;
        public int Fps {get {return fps;} set{fps = value;}}

        public abstract void Assemble();
        public abstract void WorkBench();
    }
    public class AMD : MotherBoard
    {
    
        public override void Assemble()
        {
            Console.WriteLine($"Adding Processor: {processor}");
            Console.WriteLine($"Adding Thermal Paste");
            Console.WriteLine($"Adding Cooler: {cooler}");
            Console.WriteLine($"Adding Memory: {memory}GB");
            Console.WriteLine($"Positioning PSU of {psu_wats}w");
            Console.WriteLine($"Plugin PSU Pines");
        }

        public override void WorkBench(){
            Console.WriteLine($"WorkBench result in: {fps} FPS");
        }
    }
    public class Intel : MotherBoard
    {
    
        public override void Assemble()
        {
            Console.WriteLine($"Adding Processor: {processor}");
            Console.WriteLine($"Adding Thermal Paste");
            Console.WriteLine($"Adding Cooler: {cooler}");
            Console.WriteLine($"Adding Memory: {memory}GB");
            Console.WriteLine($"Positioning PSU of {psu_wats}w");
            Console.WriteLine($"Plugin PSU Pines");
        }

        public override void WorkBench(){
            Console.WriteLine($"WorkBench result in: {fps} FPS");
        }
    }

    public abstract class CPU
    {
        protected MotherBoard motherBoard;
        protected CPU(MotherBoard motherBoard){
            this.motherBoard = motherBoard;
        }
        
        public abstract void AddProcessor();
        public abstract void AddCooler();
        public abstract void AddMemory();
        public abstract void AddPSU();
        public abstract void CountFPS();

        public void Mount(){
            AddProcessor();
            AddCooler();
            AddMemory();
            AddPSU();
            CountFPS();
            motherBoard.Assemble();
            motherBoard.WorkBench();
            Console.WriteLine($"Thank You!");
            Console.WriteLine();
        }
    }

    public class CPUIntel : CPU {
        public CPUIntel(MotherBoard motherBoard) : base(motherBoard){}

        public override void AddProcessor()
        {
            motherBoard.Processor = "Intel";
        }
        public override void AddCooler()
        {
            motherBoard.Cooler = "Cooler Box";
        }
        public override void AddMemory()
        {
            motherBoard.Memory = 16;
        }
        public override void AddPSU()
        {
            motherBoard.Psu_wats = 500;
        }
        public override void CountFPS()
        {
            motherBoard.Fps = 90;
        }
    }
    public class CPUAMD : CPU {
        public CPUAMD(MotherBoard motherBoard) : base(motherBoard){}

        public override void AddProcessor()
        {
            motherBoard.Processor = "AMD";
        }
        public override void AddCooler()
        {
            motherBoard.Cooler = "Cooler Box";
        }
        public override void AddMemory()
        {
            motherBoard.Memory = 16;
        }
        public override void AddPSU()
        {
            motherBoard.Psu_wats = 500;
        }
        public override void CountFPS()
        {
            motherBoard.Fps = 120;
        }
    }
}