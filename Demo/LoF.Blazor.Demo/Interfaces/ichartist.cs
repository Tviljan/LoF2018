public interface IChartist {
  void Line(string element, ILineData data, ILineOptions options);
}

public interface ILineData {
  string[] labels { get; set; }
  double[][] series { get; set; }
}

public interface ILineOptions {
  bool fullWidth { get; set; }
}