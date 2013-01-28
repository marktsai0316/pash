using System;

namespace System.Runtime.Diagnostics
{
	internal enum EventLogEventId : uint
	{
		ServiceAuthorizationSuccess = 1074135041,
		MessageAuthenticationSuccess = 1074135043,
		SecurityNegotiationSuccess = 1074135045,
		TransportAuthenticationSuccess = 1074135047,
		ImpersonationSuccess = 1074135049,
		WebHostNotLoggingInsufficientMemoryExceptionsOnActivationForNextTimeInterval = 2147614748,
		FailedToSetupTracing = 3221291108,
		FailedToInitializeTraceSource = 3221291109,
		FailFast = 3221291110,
		FailFastException = 3221291111,
		FailedToTraceEvent = 3221291112,
		FailedToTraceEventWithException = 3221291113,
		InvariantAssertionFailed = 3221291114,
		PiiLoggingOn = 3221291115,
		PiiLoggingNotAllowed = 3221291116,
		WebHostUnhandledException = 3221356545,
		WebHostHttpError = 3221356546,
		WebHostFailedToProcessRequest = 3221356547,
		WebHostFailedToListen = 3221356548,
		FailedToLogMessage = 3221356549,
		RemovedBadFilter = 3221356550,
		FailedToCreateMessageLoggingTraceSource = 3221356551,
		MessageLoggingOn = 3221356552,
		MessageLoggingOff = 3221356553,
		FailedToLoadPerformanceCounter = 3221356554,
		FailedToRemovePerformanceCounter = 3221356555,
		WmiGetObjectFailed = 3221356556,
		WmiPutInstanceFailed = 3221356557,
		WmiDeleteInstanceFailed = 3221356558,
		WmiCreateInstanceFailed = 3221356559,
		WmiExecQueryFailed = 3221356560,
		WmiExecMethodFailed = 3221356561,
		WmiRegistrationFailed = 3221356562,
		WmiUnregistrationFailed = 3221356563,
		WmiAdminTypeMismatch = 3221356564,
		WmiPropertyMissing = 3221356565,
		ComPlusServiceHostStartingServiceError = 3221356566,
		ComPlusDllHostInitializerStartingError = 3221356567,
		ComPlusTLBImportError = 3221356568,
		ComPlusInvokingMethodFailed = 3221356569,
		ComPlusInstanceCreationError = 3221356570,
		ComPlusInvokingMethodFailedMismatchedTransactions = 3221356571,
		UnhandledStateMachineExceptionRecordDescription = 3221422081,
		FatalUnexpectedStateMachineEvent = 3221422082,
		ParticipantRecoveryLogEntryCorrupt = 3221422083,
		CoordinatorRecoveryLogEntryCorrupt = 3221422084,
		CoordinatorRecoveryLogEntryCreationFailure = 3221422085,
		ParticipantRecoveryLogEntryCreationFailure = 3221422086,
		ProtocolInitializationFailure = 3221422087,
		ProtocolStartFailure = 3221422088,
		ProtocolRecoveryBeginningFailure = 3221422089,
		ProtocolRecoveryCompleteFailure = 3221422090,
		TransactionBridgeRecoveryFailure = 3221422091,
		ProtocolStopFailure = 3221422092,
		NonFatalUnexpectedStateMachineEvent = 3221422093,
		PerformanceCounterInitializationFailure = 3221422094,
		ProtocolRecoveryComplete = 3221422095,
		ProtocolStopped = 3221422096,
		ThumbPrintNotFound = 3221422097,
		ThumbPrintNotValidated = 3221422098,
		SslNoPrivateKey = 3221422099,
		SslNoAccessiblePrivateKey = 3221422100,
		MissingNecessaryKeyUsage = 3221422101,
		MissingNecessaryEnhancedKeyUsage = 3221422102,
		StartErrorPublish = 3221487617,
		BindingError = 3221487618,
		LAFailedToListenForApp = 3221487619,
		UnknownListenerAdapterError = 3221487620,
		WasDisconnected = 3221487621,
		WasConnectionTimedout = 3221487622,
		ServiceStartFailed = 3221487623,
		MessageQueueDuplicatedSocketLeak = 3221487624,
		MessageQueueDuplicatedPipeLeak = 3221487625,
		SharingUnhandledException = 3221487626,
		ServiceAuthorizationFailure = 3221618690,
		MessageAuthenticationFailure = 3221618692,
		SecurityNegotiationFailure = 3221618694,
		TransportAuthenticationFailure = 3221618696,
		ImpersonationFailure = 3221618698
	}
}