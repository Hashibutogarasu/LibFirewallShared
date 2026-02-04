namespace LibFirewall.Shared;

[MessagePack.MessagePackObject(true)]
public class FirewallInboundRule
{
    [MessagePack.Key(0)] public string Name { get; set; } = "";
    [MessagePack.Key(1)] public string Description { get; set; } = "";
    [MessagePack.Key(2)] public RuleAction Action { get; set; } = RuleAction.Block;
    [MessagePack.Key(3)] public bool Enabled { get; set; } = true;
    [MessagePack.Key(4)] public int Protocol { get; set; } = 256;
    [MessagePack.Key(5)] public string LocalPorts { get; set; } = "";
    [MessagePack.Key(6)] public string RemotePorts { get; set; } = "";
    [MessagePack.Key(7)] public string LocalAddresses { get; set; } = "";
    [MessagePack.Key(8)] public string RemoteAddresses { get; set; } = "";
    [MessagePack.Key(9)] public int Profiles { get; set; } = int.MaxValue;
    [MessagePack.Key(10)] public string InterfaceTypes { get; set; } = "All";
    [MessagePack.Key(11)] public bool EdgeTraversal { get; set; } = false;
    [MessagePack.Key(12)] public string ApplicationName { get; set; } = "";
    [MessagePack.Key(13)] public string ServiceName { get; set; } = "";
    [MessagePack.Key(14)] public string Grouping { get; set; } = "@FirewallAPI.dll,-23255";
}

[MessagePack.MessagePackObject(true)]
public class FirewallOutboundRule
{
    [MessagePack.Key(0)] public string Name { get; set; } = "";
    [MessagePack.Key(1)] public string Description { get; set; } = "";
    [MessagePack.Key(2)] public RuleAction Action { get; set; } = RuleAction.Block;
    [MessagePack.Key(3)] public bool Enabled { get; set; } = true;
    [MessagePack.Key(4)] public int Protocol { get; set; } = 256;
    [MessagePack.Key(5)] public string LocalPorts { get; set; } = "";
    [MessagePack.Key(6)] public string RemotePorts { get; set; } = "";
    [MessagePack.Key(7)] public string LocalAddresses { get; set; } = "";
    [MessagePack.Key(8)] public string RemoteAddresses { get; set; } = "";
    [MessagePack.Key(9)] public int Profiles { get; set; } = int.MaxValue;
    [MessagePack.Key(10)] public string InterfaceTypes { get; set; } = "All";
    [MessagePack.Key(11)] public bool EdgeTraversal { get; set; } = false;
    [MessagePack.Key(12)] public string ApplicationName { get; set; } = "";
    [MessagePack.Key(13)] public string ServiceName { get; set; } = "";
    [MessagePack.Key(14)] public string Grouping { get; set; } = "@FirewallAPI.dll,-23255";
}

[MessagePack.MessagePackObject(true)]
public class FirewallConnectionRule
{
    [MessagePack.Key(0)] public string Name { get; set; } = "";
    [MessagePack.Key(1)] public string Description { get; set; } = "";
    [MessagePack.Key(2)] public ConnectionSecurityRuleType RuleType { get; set; } = ConnectionSecurityRuleType.Custom;
    [MessagePack.Key(3)] public bool Enabled { get; set; } = true;
    [MessagePack.Key(4)] public int Profiles { get; set; } = int.MaxValue;
    [MessagePack.Key(5)] public string LocalAddresses { get; set; } = "";
    [MessagePack.Key(6)] public string RemoteAddresses { get; set; } = "";
    [MessagePack.Key(7)] public string Endpoint1Ports { get; set; } = "";
    [MessagePack.Key(8)] public string Endpoint2Ports { get; set; } = "";
    [MessagePack.Key(9)] public int Protocol { get; set; } = 256;
    [MessagePack.Key(10)] public int AuthType { get; set; } = 0;
}
