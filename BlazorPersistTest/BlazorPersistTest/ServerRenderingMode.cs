using BlazorPersistTest.Client;

namespace BlazorPersistTest;

public class ServerRenderingMode : IRenderingMode
{
    public bool IsClient => false;
    private int _counter = 0;

    public int Counter => ++_counter;
}
