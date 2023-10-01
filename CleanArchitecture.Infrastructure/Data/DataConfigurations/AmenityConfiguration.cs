﻿using CleanArchitecture.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.DataConfigurations
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasData(new Amenity
            {
                Id = 1,
                VillaId = 1,
                Name = "Private Pool"
            }, new Amenity
            {
                Id = 2,
                VillaId = 1,
                Name = "Microwave"
            }, new Amenity
            {
                Id = 3,
                VillaId = 1,
                Name = "Private Balcony"
            }, new Amenity
            {
                Id = 4,
                VillaId = 1,
                Name = "1 king bed and 1 sofa bed"
            },

              new Amenity
              {
                  Id = 5,
                  VillaId = 2,
                  Name = "Private Plunge Pool"
              }, new Amenity
              {
                  Id = 6,
                  VillaId = 2,
                  Name = "Microwave and Mini Refrigerator"
              }, new Amenity
              {
                  Id = 7,
                  VillaId = 2,
                  Name = "Private Balcony"
              }, new Amenity
              {
                  Id = 8,
                  VillaId = 2,
                  Name = "king bed or 2 double beds"
              },

              new Amenity
              {
                  Id = 9,
                  VillaId = 3,
                  Name = "Private Pool"
              }, new Amenity
              {
                  Id = 10,
                  VillaId = 3,
                  Name = "Jacuzzi"
              }, new Amenity
              {
                  Id = 11,
                  VillaId = 3,
                  Name = "Private Balcony"
              });
        }
    }
}
