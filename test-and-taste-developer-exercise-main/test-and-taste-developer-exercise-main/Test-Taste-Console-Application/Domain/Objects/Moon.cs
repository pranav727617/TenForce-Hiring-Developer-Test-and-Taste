using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public float radiusInMeters { get; set; }
        public float Gravity { get; set; }

        
        public Moon(MoonDto moonDto)
        {
            
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            //Added a new Property radius in meters which takes Mean radius from API Response
            //Console.WriteLine($"Loading data for Moon {Id}");
            radiusInMeters = moonDto.MeanRadius;
            try
            {
                if(MassValue<=0||MassExponent<=0||radiusInMeters<=0)
                {
                    Gravity = 0.0f;
                    return;
                }
                //Calculating new Mass Value in KG with help of Exponent
                MassValue = (float)(MassValue * Math.Pow(10, moonDto.MassExponent));

                //Converting mean Radius to Meters as Gravity SI unit is m/s^2
                radiusInMeters = radiusInMeters * 1000;

                //Declaring Gravitational Constant
                const double G = 6.67430e-11;
                if (MassValue > 0 && radiusInMeters > 0)
                {
                    //Calculating Gravity by Formula gravity= (gravitational Constant * Moon Mass / radius^2)
                    Gravity = (float)(G * MassValue / (radiusInMeters * radiusInMeters));
                    //Console.WriteLine($"Calculated Gravity for {Id}: {Gravity}");
                }
                else
                {
                    Gravity = 0.0f;
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error calculating gravity for moon {Id}: {ex.Message}");
                Gravity = 0.0f;
            }


        }
    }
}
