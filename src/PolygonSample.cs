using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;
using System.Collections.Generic;

namespace PolygonSample
{
    public static class PolygonSample
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A PolygonSampleOutputs instance containing computed results and the model with any new elements.</returns>
        public static PolygonSampleOutputs Execute(Dictionary<string, Model> inputModels, PolygonSampleInputs input)
        {
            // Your code here.
            var output = new PolygonSampleOutputs();

            // Gather inputs.
            var polygons = input.Polygons;

            foreach (var poly in polygons)
            {
                output.Model.AddElement(poly);
            }

            return output;
        }
    }
}