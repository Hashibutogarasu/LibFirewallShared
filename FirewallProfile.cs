namespace LibFirewall.Shared;

[Flags]
public enum FirewallProfile
{
    Domain = 1,
    Private = 2,
    Public = 4,
    All = Domain | Private | Public
}
