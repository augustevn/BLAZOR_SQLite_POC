﻿namespace EpicPoC.Spa.Data;

public record Token
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public DateTime ExpiresAt { get; set; }
}