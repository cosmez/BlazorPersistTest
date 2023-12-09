namespace BlazorPersistTest.Client;


public interface IRenderingMode
{
    bool IsClient { get; }
    int Counter { get;  }
}

public class ClientRenderingMode : IRenderingMode
{
    public bool IsClient => true;

    public int Counter => 0;
}
