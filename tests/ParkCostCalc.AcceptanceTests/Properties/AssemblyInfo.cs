using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework;


[assembly: Parallelizable(ParallelScope.Fixtures)]

[assembly: LevelOfParallelism(5)]

[assembly: ComVisible(false)]

[assembly: Guid("2ff50688-c53f-4b11-8d86-6ff1549b88b3")]