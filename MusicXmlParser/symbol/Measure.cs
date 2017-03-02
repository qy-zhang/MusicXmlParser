using System.Collections.Generic;

namespace MusicXmlParser.symbol
{
    public class Measure
    {
        private List<List<List<Symbol>>> _measureSymbolList;
        private Beat _beat;
        private Head _highHead;
        private Head _lowHead;
        private bool _hasHead; // 小节首部是否有头部信息
        private bool _hasBeat; // 小节首部是否有拍号信息
        private int _measureUnit; // 小节中乐符占用多少个unit

        public Measure(List<List<List<Symbol>>> measureSymbolList)
        {
            _measureSymbolList = measureSymbolList;
        }

        public List<List<List<Symbol>>> GetMeasureSymbolList() { return _measureSymbolList; }

        public bool HasHead() { return _hasHead; }

        public void SetHasHead(bool hasHead) { _hasHead = hasHead; }

        public bool HasBeat() { return _hasBeat; }

        public void SetHasBeat(bool hasBeat) { _hasBeat = hasBeat; }

        public Beat GetBeat() { return _beat; }

        public void SetBeat(Beat beat) { _beat = beat; }

        public List<Head> GetHead()
        {
            List<Head> headList = new List<Head>();
            headList.Add(_highHead);
            headList.Add(_lowHead);
            return headList;
        }

        public void SetHead(Head highHead, Head lowHead) { _highHead = highHead; _lowHead = lowHead; }

        public void SetMeasureUnit(int totalDuration)
        {
//            _measureUnit = Math.Max()
        }

        public int GetMeasureUnit() { return _measureUnit; }
    }
}