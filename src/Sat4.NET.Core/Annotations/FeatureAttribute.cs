namespace Sat4.NET.Core.Annotations;

/**
 * Architectural information about the design of Sat4j.
 * 
 * @author chiefmonk, leberre
 * @since 2.3.6
 */
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class FeatureAttribute : Attribute
{
    public FeatureAttribute(string value)
    {
        Value = value;
    }

    public FeatureAttribute(string parent, string value)
    {
        Parent = parent;
        Value = value;
    }

    public string Value { get; set; }
    public string Parent { get; set; } = "user";


}
