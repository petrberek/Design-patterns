namespace DesignPattern.Command
{
    //https://docs.microsoft.com/en-us/azure/devops/repos/tfvc/get-command?view=vsts
    public class GetCommand : TfsCommand
    {
        //Argument string
        protected override string Arguments
        {
            get 
            { 
                return string.Format("get {0}{1}{2}{3}{4}{5}",
                  item,
                  All? " /all" : string.Empty,
                  OverWrite? " /overwrite" : string.Empty,
                  Force? " /force": string.Empty,
                  Recursive? " /recursive" : string.Empty,
                  string.IsNullOrEmty(Version)?string.Empty : "/ version:"+Version);
            }
        }
        //Set of properties which you can set up and it changes arguments string
        public string Version { get;set; } = string.Empty;
        public bool All { get; set; } = false;
        public bool OverWrite { get; set; } = false;
        public bool Force { get; set; } = false;
        public bool Recursive { get; set; } = false;
        private readonly string item;
        //Ctor has item parameter which you can get from server
        public GetCommand(string item)
        {
            this.item = item;
        }

    }
}