namespace MobilityBridge.Domain.Services;
public sealed record RecurringTripExpanderInput(decimal Observed,decimal Baseline,decimal Threshold,decimal Confidence);
public sealed record RecurringTripExpanderDecision(decimal Score,bool Triggered,string Reason);
public static class RecurringTripExpander{public static RecurringTripExpanderDecision Evaluate(RecurringTripExpanderInput i){if(i.Threshold<0||i.Confidence is <0 or >1)throw new ArgumentOutOfRangeException(nameof(i));var score=Math.Abs(i.Observed-i.Baseline)*i.Confidence;return new(score,score>=i.Threshold,score>=i.Threshold?"Operational threshold exceeded.":"Within operating range.");}}
