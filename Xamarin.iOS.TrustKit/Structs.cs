using System;
using ObjCRuntime;
using Foundation;

namespace Xamarin.iOS.TrustKit
{
	[Native]
	public enum TSKTrustEvaluationResult : long
	{
		Success,
		FailedNoMatchingPin,
		FailedInvalidCertificateChain,
		ErrorInvalidParameters,
		FailedUserDefinedTrustAnchor,
		ErrorCouldNotGenerateSpkiHash
	}

	[Native]
	public enum TSKTrustDecision : long
	{
		ShouldAllowConnection,
		ShouldBlockConnection,
		DomainNotPinned
	}

}

