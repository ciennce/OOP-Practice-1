using System.Diagnostics;

namespace OOP_Practice_1.Bank
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ", nq}")]
    public partial class Account
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{nameof(Name)}={Name}, {nameof(Iban)}={Iban}, {nameof(Balance)}={Balance}";
    }
}
