using System;
using ZomboMod;
using ZomboMod.Plugin;

namespace ExamplePlugin
{
    [PluginInfo("ExamplePlugin", "leonardosnt", "1.0.0")]
    public class ExamplePlugin : PluginBase
    {
        public override void OnLoad()
        {
            Console.WriteLine( "Working :D" );

            Zombo.Server.Name = "That is working!!";
        }
    }
}
