using System;
using System.Collections.Generic;
using MusicXmlParser.generator;
using MusicXmlParser.symbol;
using MusicXmlParser.xmlParser;

namespace MusicXmlParser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            XmlFacade xmlFacade = new XmlFacade("polka.xml");
            List<Measure> measureList = xmlFacade.GetMeasureList();
            ScoreGenerator scoreGenerator = new ScoreGenerator(xmlFacade.GetBeat().GetBeats(), xmlFacade.GetBeat().GetBeatType());
            List<List<List<List<List<Symbol>>>>> scoreList = scoreGenerator.Generate(xmlFacade.GetHighSymbolList(), xmlFacade.GetLowSymbolList());

            List<List<Measure>> scoreList2 = scoreGenerator.Generate(xmlFacade.GetMeasureList(), 600);

            Console.WriteLine("test");
        }
    }
}