﻿using Microsoft.EntityFrameworkCore;
using VetClinic.Modules.Organizations.Domain.Entities;
using VetClinic.Modules.Organizations.Domain.Enums;
using VetClinic.Shared.Initializer;

namespace VetClinic.Modules.Organizations.Infrastructure.DAL.Initializers;

public class OrganizationInitializer : IInitializer
{
    private readonly OrganizationsDbContext _context;

    public OrganizationInitializer(OrganizationsDbContext context)
    {
        _context = context;
    }
    
    public async Task InitAsync()
    {
        var count = await _context.Organizations.CountAsync();

        if (count == 0)
        {
            var organization = Organization.CreateOrganization(
                "ASO Poland - Warsaw",
                "0xA8D44403E8CADf114F49F14Ae0f4F66F9D332e37",
                Trustiness.Verified
            );
            await _context.Organizations.AddAsync(organization);
            await _context.SaveChangesAsync();
        }
    }
}