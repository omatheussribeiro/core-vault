using CoreVault.Domain.Entities.Base;

namespace CoreVault.Domain.Entities.Credentials
{
    public class Credential : EntityBase
    {
        public string Title { get; private set; } = string.Empty;
        public string Username { get; private set; } = string.Empty;
        public string EncryptedPassword { get; private set; } = string.Empty;
        public bool IsTwoFactorEnabled { get; private set; }
        public Guid CredentialTypeId { get; private set; }
        public CredentialType CredentialType { get; private set; } = new CredentialType(string.Empty);

        private Credential() { }

        public Credential(
            string title,
            string username,
            string encryptedPassword,
            bool isTwoFactorEnabled,
            Guid credentialTypeId)
        {
            Title = title;
            Username = username;
            EncryptedPassword = encryptedPassword;
            IsTwoFactorEnabled = isTwoFactorEnabled;
            CredentialTypeId = credentialTypeId;
        }
    }
}
