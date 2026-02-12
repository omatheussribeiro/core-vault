using CoreVault.Domain.Entities.Base;

namespace CoreVault.Domain.Entities.Credentials
{
    public class CredentialType : EntityBase
    {
        public string Name { get; private set; } = string.Empty;

        private CredentialType() { }

        public CredentialType(string name)
        {
            Name = name;
        }
    }
}
