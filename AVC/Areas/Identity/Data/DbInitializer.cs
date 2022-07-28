﻿using System.Linq;
using System;
using AVC.Models;
using AVC.Data;

namespace AVC.Areas.Identity.Data
{
    public static class DbInitializer
    {
        public static void AVCInitialize(AVCContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }
        }
    }
}
