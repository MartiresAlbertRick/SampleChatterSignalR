using System.ComponentModel;

namespace SampleChatter.Entities.Enums
{
    public enum LoanStatus
    {
        [Description("Loan is approved")]
        Approved,
        [Description("Loan is for quotation")]
        ForQuotation,
        [Description("Loan is under review")]
        InProgress,
        [Description("Loan is declined")]
        Declined
    }
}