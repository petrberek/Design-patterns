using System.Diagnostics;

namespace DesignPatterns.Command
{
    //Base class which can start tf.exe with arguments
    public abstract class TfsCommand
    {
        private readonly string tfExePath;
        //Each class have to implement Arguments string
        protected abstract string Arguments { get; }
        //ctor has parameter path to tf.exe
        public TfsCommand(string tfExePath)
        {
            this.tfExePath = tfExePath;
        }
        //Execute method. Each class derived from this class has it and
        //you can execute command by this method.
        //Arguments are given by concrete class.
        public virtual void Execute()
        {
            ProcessStartInfo processStartInfo = 
              new ProcessStartInfo(tfExePath, Arguments);
            Process process = new Process(processStartInfo);
            process.Start();
        }
    }
}