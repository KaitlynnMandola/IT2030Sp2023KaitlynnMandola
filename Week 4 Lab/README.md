File Syntax Errors (Error List Window):
*     wwwroot/css/site.css
     *     Line 13: width was spelled as width
*     Controllers/HomeController.cs
     *     Line 10: Included "return" is this line so that Index() returns a value.
     *     Line 14: ViewBag.TwentyFive was coded as Viewbag.TwentyFive. It is case-sensitive.
*     Models/TipCalculator.cs
     *     Line 16: The semi-colon was missing at the end of this line of code.
-------------------------------------------------------------------------
Internal Server Error Page Errors:
*     Views/Home/Index.cshtml
*     Line 16: Changed spelling from Fifteem to Fifteen.
-------------------------------------------------------------------------
Set a breakpoint in the model class and step through its code to find the error that leads to the app calculating an incorrect tip amount.
*     Inserted breakpoint at Line 15 in the Models/TipCalculator.cs file.
*     The error that leads to the app calculating an incorrect tip amount is that the code is dividing the MealCost value by the specified tip percentage. 
*     Instead, the code should be corrected to where the MealCost value is being multiplied by the tip percentage.
*     Example of New Line 15 code: var tip = MealCost.Value * percent;
-------------------------------------------------------------------------
