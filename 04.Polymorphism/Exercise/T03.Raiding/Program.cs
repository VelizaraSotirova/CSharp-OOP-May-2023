using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.IO;
using Raiding.IO.Interfaces;

IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter(), new HeroFactory());
engine.Run();