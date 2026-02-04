namespace LibFirewall.Shared;

public class FirewallInboundRule
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public RuleAction Action { get; set; } = RuleAction.Block;
    public bool Enabled { get; set; } = true;
    public int Protocol { get; set; } = 256;
    public string LocalPorts { get; set; } = "";
    public string RemotePorts { get; set; } = "";
    public string LocalAddresses { get; set; } = "";
    public string RemoteAddresses { get; set; } = "";
    public int Profiles { get; set; } = int.MaxValue;
    public string InterfaceTypes { get; set; } = "All";
    public bool EdgeTraversal { get; set; } = false;
    public string ApplicationName { get; set; } = "";
    public string ServiceName { get; set; } = "";
    public string Grouping { get; set; } = "@FirewallAPI.dll,-23255";
}

public class FirewallOutboundRule
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public RuleAction Action { get; set; } = RuleAction.Block;
    public bool Enabled { get; set; } = true;
    public int Protocol { get; set; } = 256;
    public string LocalPorts { get; set; } = "";
    public string RemotePorts { get; set; } = "";
    public string LocalAddresses { get; set; } = "";
    public string RemoteAddresses { get; set; } = "";
    public int Profiles { get; set; } = int.MaxValue;
    public string InterfaceTypes { get; set; } = "All";
    public bool EdgeTraversal { get; set; } = false;
    public string ApplicationName { get; set; } = "";
    public string ServiceName { get; set; } = "";
    public string Grouping { get; set; } = "@FirewallAPI.dll,-23255";
}

public class FirewallConnectionRule
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public ConnectionSecurityRuleType RuleType { get; set; } = ConnectionSecurityRuleType.Custom;
    public bool Enabled { get; set; } = true;
    public int Profiles { get; set; } = int.MaxValue;
    public string LocalAddresses { get; set; } = "";
    public string RemoteAddresses { get; set; } = "";
    public string Endpoint1Ports { get; set; } = "";
    public string Endpoint2Ports { get; set; } = "";
    public int Protocol { get; set; } = 256;
    public int AuthType { get; set; } = 0;
}
