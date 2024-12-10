namespace One.Health.ICICI;
public class GUIDBuilder
{
    public string UUIDV4()
    {
        Guid uuidV4 = Guid.NewGuid();
        return uuidV4.ToString();
    }
}