using System;
using System.Collections.Generic;

namespace INTEX_II;

public partial class Lineitem
{
    public int TransactionId { get; set; }

    public byte ProductId { get; set; }

    public byte Qty { get; set; }

    public byte Rating { get; set; }
}
