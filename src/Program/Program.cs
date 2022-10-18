//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductCatalog.AddProductToCatalog("Café", 100);
            ProductCatalog.AddProductToCatalog("Leche", 200);
            ProductCatalog.AddProductToCatalog("Café con leche", 300);

            EquipmentCatalog.AddEquipmentToCatalog("Cafetera", 1000);
            EquipmentCatalog.AddEquipmentToCatalog("Hervidor", 2000);
            
            Recipe recipe = new Recipe();
            recipe.FinalProduct = ProductCatalog.GetProduct("Café con leche");
            recipe.AddStep(ProductCatalog.GetProduct("Café"), 100, EquipmentCatalog.GetEquipment("Cafetera"), 120);
            recipe.AddStep(ProductCatalog.GetProduct("Leche"), 200, EquipmentCatalog.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);

            
        }

        
            
        
        
    }
}
