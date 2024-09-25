﻿global using Asp.Versioning;
global using MediatR;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi.Models;
global using oni.Application;
global using oni.Application.Exceptions;
global using oni.Application.Features.Departments.Queries.GetDepartments;
global using oni.Application.Features.Employees.Queries.GetEmployees;
global using oni.Application.Features.Positions.Commands.CreatePosition;
global using oni.Application.Features.Positions.Commands.DeletePositionById;
global using oni.Application.Features.Positions.Commands.UpdatePosition;
global using oni.Application.Features.Positions.Queries.GetPositionById;
global using oni.Application.Features.Positions.Queries.GetPositions;
global using oni.Application.Features.SalaryRanges.Queries.GetSalaryRanges;
global using oni.Application.Wrappers;
global using oni.Infrastructure.Persistence;
global using oni.Infrastructure.Persistence.Contexts;
global using oni.Infrastructure.Persistence.SeedData;
global using oni.Infrastructure.Shared;
global using oni.WebApi.Extensions;
global using oni.WebApi.Middlewares;
global using Serilog;
global using System;
global using System.Collections.Generic;
global using System.Diagnostics;
global using System.Net;
global using System.Text.Json;
global using System.Threading.Tasks;
