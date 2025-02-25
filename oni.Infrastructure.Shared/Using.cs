﻿global using AutoBogus;
global using Bogus;
global using Bogus.DataSets;
global using MailKit.Net.Smtp;
global using MailKit.Security;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using MimeKit;
global using oni.Application.DTOs.Email;
global using oni.Application.Exceptions;
global using oni.Application.Interfaces;
global using oni.Domain.Entities;
global using oni.Domain.Enums;
global using oni.Domain.Settings;
global using oni.Infrastructure.Shared.Mock;
global using oni.Infrastructure.Shared.Services;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading.Tasks;