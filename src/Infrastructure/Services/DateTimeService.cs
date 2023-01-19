﻿using Order.Application.Common.Interfaces;

namespace Order.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
