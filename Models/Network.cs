using System;
using System.Collections.Generic;

namespace ValegoProject.Models;

public partial class NetWork
{
    public int Id { get; set; }

    public string NetworkName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string NetworkSymbol { get; set; } = null!;

    public string? TransactionExplorer { get; set; }

    public string? TokenExplorer { get; set; }

    public int DepositConfirmations { get; set; }

    public bool? Enabled { get; set; }

    public static explicit operator NetWork(List<char> v)
    {
        throw new NotImplementedException();
    }

    public static explicit operator NetWork(List<NetWork> v)
    {
        throw new NotImplementedException();
    }
}
