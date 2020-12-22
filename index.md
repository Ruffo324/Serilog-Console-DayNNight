## Welcome to DayNNight

### How to use.

**TODO: NUGET!**

```cs
Log.Logger = new LoggerConfiguration()
  .WriteTo.Console(theme: DayNNight.Theme.CoderNotDesigner)
  .CreateLogger();
```


### FAQ
#### Does the logic behind `DayNNight` switch the themes automatic at runtime?
Not yet.  
However, every time the property `DayNNight.Models.DayNNightTheme.Auto` is called, it will be checked again what the current console background color is.
However, it is still planned to switch automatically later.


```cs
// TODO: write more informations.
```
