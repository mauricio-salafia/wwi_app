namespace WideWordImporter.Domain.Enums
{
    /// <summary>
    /// Transaction Type enumeration
    /// </summary>
    public enum TransactionType
    {
        Unknown = 0,
        CustomerInvoice = 1,
        CustomerCreditNote = 2,
        CustomerPaymentReceived = 3,
        CustomerRefund = 4,
        SupplierInvoice = 5,
        SupplierCreditNote = 6,
        SupplierPaymentIssued = 7,
        SupplierRefund = 8,
        StockTransfer = 9,
        StockIssue = 10,
        StockReceipt = 11,
        StockAdjustmentAtStockable = 12,
        CustomerContra = 13
    }
}
