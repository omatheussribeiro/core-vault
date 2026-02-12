using CoreVault.Domain.Entities.Base;
using CoreVault.Domain.Entities.Credentials;

namespace CoreVault.Domain.Entities.Vaults
{
    public class Vault : EntityBase
    {
        public string Name { get; private set; } = string.Empty;
        public int UserId { get; private set; }
        private readonly List<Credential> _credentials = new();
        public IReadOnlyCollection<Credential> Credentials => _credentials;

        private Vault() { }

        public Vault(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }
    }
}
