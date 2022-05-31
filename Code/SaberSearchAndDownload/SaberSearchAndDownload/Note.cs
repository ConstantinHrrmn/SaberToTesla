using System;
namespace SaberSearchAndDownload
{
	public class Note
	{
        private double _ti;
        private int _lI;
        private int _lL;
        private int _ty;
        private int _cD;

        private double _startTime;
        private int _duration;

        #region JSON Setter
        public double _time { get => _ti; set => _ti = value; }
        public int _lineIndex { get => _lI; set => _lI = value; }
        public int _lineLayer { get => _lI; set => _lI = value; }
        public int _type { get => _ty; set => _ty = value; }
        public int _cutDirection { get => _cD; set => _cD = value; }
        #endregion

        #region Public Getter Setter
        public double Time { get => _ti; set => _ti = value; }
        public int LineIndex { get => _lI; set => _lI = value; }
        public int LineLayer { get => _lL; set => _lL = value; }
        public int Type { get => _ty; set => _ty = value; }
        public int CutDirection { get => _cD; set => _cD = value; }
        public bool IsRed { get => this.Type == 0; }
        public double StartTime { get => _startTime; set => _startTime = value; }
        public double EndTime { get => this.StartTime + this.Duration; }
        public string Position { get => this.LineLayer.ToString() + this.LineIndex.ToString(); }
        public int Duration { get => _duration; set => _duration = value; }
        #endregion

        public Note() { }

        public Note(double a_time, int a_lineIndex, int a_lineLayer, int a_type, int a_cutDirection)
        {
            this.Time = a_time;
            this.LineIndex = a_lineIndex;
            this.LineLayer = a_lineLayer;
            this.Type = a_type;
            this.CutDirection = a_cutDirection;
        }

        public override string ToString()
        {
            return string.Format("[Time] = {0} |  [Type] = {1} | [Start] = {2} | [End] = {3} || [Position] = {4}", this.Time, this.Type, this.StartTime, this.EndTime, this.Position);
        }

        public string ToWrite()
        {
            return string.Format("<Effect ref=\"0\" name=\"On\" selected=\"1\" startTime= \"{0}\" endTime= \"{1}\" palette=\"0\"/>", this.StartTime, this.EndTime);
        }
    }
}

