using Graph;

var type = typeof(IExecute);
var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

foreach (var t in types)
{
    if (t.Name == "BreadthFirstTraversal")
    {
        var initiatedObject = (IExecute?)Activator.CreateInstance(t);
        initiatedObject?.Execute();
    }
}