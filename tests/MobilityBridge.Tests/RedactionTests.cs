namespace MobilityBridge.Tests;
public sealed class RedactionTests{private static decimal Score(decimal observed,decimal baseline,decimal confidence)=>Math.Abs(observed-baseline)*confidence;[Fact]public void DetectsMaterialDeviation()=>Assert.True(Score(12m,10m,.8m)>1.5m);[Fact]public void IsZeroAtBaseline()=>Assert.Equal(0m,Score(10m,10m,1m));}
