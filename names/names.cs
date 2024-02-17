using System.Collections.Generic;

public class Names
{

    public Names(string name, string region)
    {
        _name = name;
        _region = region;
    }
 
    public string ResourceGroup => $"{_name}-rg-{_region}";

    private readonly string _name;
    private readonly string _region;

 
}