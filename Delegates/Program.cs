// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");

var photoProcessor = new PhotoProcessor();

//photoProcessor.Process("path");

//var filters = new PhotoFilters();
//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
//filterHandler += filters.ApplyHue;
//photoProcessor.Process_UsingDelegate("path", filterHandler);




// using action
var filters = new PhotoFilters();
Action<Photo> filterHandler = filters.ApplySaturation;
filterHandler += filters.ApplyContrast;
photoProcessor.Process_UsingAction("path", filterHandler);


