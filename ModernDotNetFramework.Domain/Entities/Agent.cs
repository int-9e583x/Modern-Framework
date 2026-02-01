namespace ModernDotNetFramework.Domain.Entities;

public class Agent
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Status { get; set; } = "Idle";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public interface IAgentRepository
{
    Task<Agent> GetByIdAsync(Guid id);
    Task<IEnumerable<Agent>> GetAllAsync();
}
