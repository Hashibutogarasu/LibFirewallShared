namespace LibFirewall.Shared;

public enum RuleDirection : uint
{
    Inbound = 1,
    Outbound = 2,
}

public enum RuleAction : uint
{
    Block = 0,
    Allow = 1,
}

public enum ConnectionSecurityRuleType : uint
{
    Isolation = 1,
    AuthenticationExemption = 2,
    ServerToServer = 3,
    Tunnel = 4,
    Custom = 5,
}
