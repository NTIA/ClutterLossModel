# ClutterLossModel

This model implements an ITU clutter loss calculation for terrestrial paths and frequency ranges from 2 to 67 GHz.

## Some Implementation Details
The clutter loss model comes directly from ITU-R P.2108-0, Section 3.2. 


## Example
Here's a sample on how to use it:
```C#
Random randomNumber = new Random();

StreamWriter swClutterLoss = new StreamWriter("ClutterLoss.csv");
swClutterLoss.WriteLine("Distance km, Clutter Loss dB, Frequency GHz, N");
			
ITUClutterLoss.ClutterLoss clutterloss = new ClutterLoss(randomNumber);

double FrequencyGHz = 37;

for (double distancekm = 0.25; distancekm <= 300; distancekm*=1.5)
{
	swClutterLoss.WriteLine(
	distancekm + "," + clutterloss.TerrestrialtoTerrestrialClutterLoss(FrequencyGHz, distancekm) +
		"," + FrequencyGHz + "," + clutterloss.LastGeneratedNormalValue);
}
```