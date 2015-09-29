using System;
using System.Linq;
using HtmlAgilityPack;
using LambdaMicrobenchmarking;

static class TestCases {
	public static int TestPath(){
		var text = System.IO.File.ReadAllText("Project-less scripted C# with ScriptCS and Roslyn - Scott Hanselman.htm");

		var htmlDocument = new HtmlDocument {OptionOutputOriginalCase = true};
		htmlDocument.LoadHtml(text);
		var htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='commentBodyStyle']");
		if(htmlNodeCollection == null){
			return 0;
		}else{
			return htmlNodeCollection.Count;
		}
	}

	public static int TestIteration(){
		var text = System.IO.File.ReadAllText("Project-less scripted C# with ScriptCS and Roslyn - Scott Hanselman.htm");

		var htmlDocument = new HtmlDocument {OptionOutputOriginalCase = true};
		htmlDocument.LoadHtml(text);
		var htmlNodeCollection = htmlDocument.DocumentNode.Descendants("div").Where(a => a.HasAttributes && a.Attributes.Contains("class") && a.Attributes["class"].Value == "commentBodyStyle").ToList();
		if(htmlNodeCollection == null){
			return 0;
		}else{
			return htmlNodeCollection.Count();
		}
	}
}

public static class MainClass {
	public static void Main(string[] args){
		Script
	      .Of("TestIteration", () => { return TestCases.TestIteration(); })
	      .Of("TestPath", () => { return TestCases.TestPath(); } )
	      .WithHead()
	      .RunAll();

	}
}

MainClass.Main(null);