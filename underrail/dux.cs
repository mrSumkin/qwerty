using System;
using Ouroboros.Core.Logging;

// Token: 0x02000493 RID: 1171
public static class dux
{
	// Token: 0x06001DF4 RID: 7668 RVA: 0x000A6408 File Offset: 0x000A4608
	public static void b(LogSeverity A_0, string A_1, params object[] A_2)
	{
		try
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(A_0, 40000))
			{
				string a_ = "[Timelapse Vertigo] - " + string.Format(A_1, A_2);
				cvq.n7(A_0, 40000, a_);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000A6478 File Offset: 0x000A4678
	public static void a(LogSeverity A_0, Exception A_1, string A_2, params object[] A_3)
	{
		try
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(A_0, 40000))
			{
				string a_ = "[Timelapse Vertigo] - " + string.Format(A_2, A_3) + " Exception: " + A_1.ToString();
				cvq.n7(A_0, 40000, a_);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x000A64F4 File Offset: 0x000A46F4
	public static void LogAndThrow<T>(Exception innerException, LogSeverity severity, string message, params object[] messageArgs) where T : Exception
	{
		string text = string.Format(message, messageArgs);
		T t = Activator.CreateInstance(typeof(T), new object[]
		{
			text,
			innerException
		}) as T;
		try
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(severity, 40000))
			{
				string a_ = "[Timelapse Vertigo] - " + text + ". Exception: " + t.ToString();
				cvq.n7(severity, 40000, a_);
			}
		}
		catch
		{
		}
		throw t;
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000A65A4 File Offset: 0x000A47A4
	public static void LogAndThrow<T>(LogSeverity severity, string message, params object[] messageArgs) where T : Exception
	{
		dux.LogAndThrow<T>(null, severity, message, messageArgs);
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000A65B0 File Offset: 0x000A47B0
	public static void a(LogSeverity A_0, string A_1, params object[] A_2)
	{
		dux.LogAndThrow<Exception>(null, A_0, A_1, A_2);
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000A65BC File Offset: 0x000A47BC
	public static void a(Exception A_0, LogSeverity A_1, string A_2, params object[] A_3)
	{
		dux.LogAndThrow<Exception>(A_0, A_1, A_2, A_3);
	}

	// Token: 0x04001293 RID: 4755
	public const int a = 40000;
}
