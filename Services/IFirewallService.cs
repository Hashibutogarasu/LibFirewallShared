using MagicOnion;

namespace LibFirewall.Shared.Services
{
    public interface IFirewallService : IService<IFirewallService>
    {
        UnaryResult<List<FirewallInboundRule>> GetInboundRulesAsync();
        UnaryResult<bool> AddInboundRuleAsync(FirewallInboundRule rule);
        UnaryResult<bool> UpdateInboundRuleAsync(FirewallInboundRule rule);
        UnaryResult<bool> DeleteInboundRuleAsync(string name);

        UnaryResult<List<FirewallOutboundRule>> GetOutboundRulesAsync();
        UnaryResult<bool> AddOutboundRuleAsync(FirewallOutboundRule rule);
        UnaryResult<bool> UpdateOutboundRuleAsync(FirewallOutboundRule rule);
        UnaryResult<bool> DeleteOutboundRuleAsync(string name);

        UnaryResult<List<FirewallConnectionRule>> GetConnectionRulesAsync();
        UnaryResult<bool> AddConnectionRuleAsync(FirewallConnectionRule rule);
        UnaryResult<bool> UpdateConnectionRuleAsync(FirewallConnectionRule rule);
        UnaryResult<bool> DeleteConnectionRuleAsync(string name);
    }
}
