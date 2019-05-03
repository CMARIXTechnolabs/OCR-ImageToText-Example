## OCR-ImageToText-Example ##
<a target="_blank" href="LICENSE"><img src="https://img.shields.io/badge/licence-MIT-brightgreen.svg" alt="license : MIT"></a>
<a target="_blank" href="https://www.cmarix.com/aspdotnet-web-application-development-services.html"><img src="https://img.shields.io/badge/aspdotnet-4.0%2B-blue.svg" alt="aspdotnet : 4.0+"></a>

This repository contains sample window applicaiton in c# to read the image form the URL and convert Image to text using IronOCR. [https://ironsoftware.com/csharp/ocr/#autoocr](https://ironsoftware.com/csharp/ocr/#autoocr "https://ironsoftware.com/csharp/ocr/#autoocr")

## Why we choose IronOCR? ##

- Iron OCR is easy-to-install. Install the Iron OCR library for .Net package from nuget - [https://www.nuget.org/packages/IronOcr/](https://www.nuget.org/packages/IronOcr/ "https://www.nuget.org/packages/IronOcr/") 

	`PM > Install-Package IronOcr`

- Complete and well-documented .NET software library. Here are the Object Reference documentation for the developer([https://ironsoftware.com/csharp/ocr/object-reference/html/N_IronOcr.htm](https://ironsoftware.com/csharp/ocr/object-reference/html/N_IronOcr.htm "https://ironsoftware.com/csharp/ocr/object-reference/html/N_IronOcr.htm")). 
- Support for multiple languages image([https://ironsoftware.com/csharp/ocr/languages/](https://ironsoftware.com/csharp/ocr/languages/ "https://ironsoftware.com/csharp/ocr/languages/")).
- Performs multiple Images simultaneously using parallel multi threading.

## Basic Example ##
AutoOcr is easy to use and develop. In this source code we are converting the Image URL into System.Drawing.Image and read image usign autoOcr.

    using IronOcr;
    
    AutoOcr autoOcr = new AutoOcr();
    var result = autoOcr.Read(##IMAGE##);
    Console.WriteLine(result.Text);

Where ##IMAGE## is one of the following

1. ImageFilePath - local file path
2. System.Drawing.Bitmap
3. System.Drawing.Image 

## Let us know! ##
We’d be really happy if you sent us links to your projects where you use our component. Just send an email to [biz@cmarix.com](mailto:biz@cmarix.com "biz@cmarix.com") and do let us know if you have any questions or suggestion regarding OCR Image reader.

P.S. We’re going to publish more awesomeness examples on third party libraries, coding standards, plugins etc, in all the technology. Stay tuned!

## Stay Socially Connected ##

Get more familiar with our work by visiting few of our portfolio links.

[Portfolio](https://www.cmarix.com/portfolio.html) | [Facebook](https://www.facebook.com/CMARIXTechnoLabs/) | [Twitter](https://twitter.com/CMARIXTechLabs) | [Linkedin](https://www.linkedin.com/company/cmarix-technolabs-pvt-ltd-) | [Behance](https://www.behance.net/CMARIXTechnoLabs/) | [Instagram](https://instagram.com/cmarixtechnolabs/) | [Dribbble](https://dribbble.com/CMARIXTechnoLabs) | [Uplabs](https://www.uplabs.com/cmarixtechnolabs)

Please don’t forget to follow them.

## License ##

	MIT License
	
	Copyright © 2019 CMARIX TechnoLabs
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:
	
	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.
	
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.

