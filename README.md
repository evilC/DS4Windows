# DS4WindowsApi

An attempt to be able to read the full range of DS4 inputs in my own C# code.  
Basically I took [Ryochan7/DS4Windows](https://github.com/Ryochan7/DS4Windows) and ripped out the front-end.  

## WARNING
This is NOT an application like DS4Windows, it is only useful to coders.  

## Requirements

- [Microsoft .NET 4.5.2 or higher (needed to unzip the driver and for macros to work properly)](http://www.microsoft.com/en-us/download/details.aspx?id=42642)
- Sony DualShock 4 (This should be obvious)
- Micro USB cable
- (Optional)Bluetooth 2.1+, via adapter or built in pc [(My recommendation)](http://www.amazon.com/gp/product/B004LNXO28/ref=oh_aui_search_detailpage?ie=UTF8&psc=1) (Toshiba's bluetooth & Bluetooth adapters using CSR currently does not work)

## Pull Requests

Pull requests for DS4WindowsApi are welcome. Before making a pull request, please
test your changes to ensure that the changes made do not negatively affect
the performance of other parts of the application. Some consideration will
be made during code review to try to tweak the changes in order to improve
application performance. However, there is a chance that a pull request will be
rejected if no reasonable solution can be found to incorporate code changes.

