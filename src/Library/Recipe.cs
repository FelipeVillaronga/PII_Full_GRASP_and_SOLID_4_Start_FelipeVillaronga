//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        public Recipe()
        {
            this.Steps= new List<Step>();
        }
        public IList<Step> Steps {get; set;}

        public Product FinalProduct { get; set; }

        //  Agregado por Creator
        public Step AddStep(Product input, double quantity, Equipment equipment, int time)
        {
            Step step= new Step(input, quantity, equipment, time);
            this.Steps.Add(step);
            return step;

        }

        public void RemoveStep(Step step)
        {
            this.Steps.Remove(step);
        }

        // Agregado por SRP
        public string GetTextToPrint()
        {
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (Step step in this.Steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
        }

        // Agregado por Expert
        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.Steps)
            {
                result = result + step.GetStepCost();
            }

            return result;
        }
    }
}