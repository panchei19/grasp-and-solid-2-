//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        //expert (clase maestra es recipe ya que implemeta product y step quien implementa equipment)
        public double GetProductionCost()
        {
          Double costoInsumos = 0;
          Double costoEquipment = 0;
          Double total = 0;
          foreach(Step step in this.steps) 
          {
            costoInsumos = costoInsumos + step.Input.UnitCost;
            costoEquipment = costoEquipment + (step.Equipment.HourlyCost * (step.Time/60));
          }
          total = costoEquipment + costoInsumos;

          return total;
        }
        public string GetRecipeText()
        {
            StringBuilder text = new StringBuilder($"Receta de: {this.FinalProduct.Description}\n");
            foreach (Step step in AllSteps())
            {
               text.Append($"paso : {step}\n");
            }
            return Convert.ToString(text);
        }
        public string GetSteps(){
            ArrayList AllSteps = new ArrayList();
            foreach(Recipe Steps in this.steps){
                AllSteps.Add(Steps);
            }
            return Convert.ToString(AllSteps);
        }
    }
}