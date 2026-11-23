using System;
using Ouroboros.Core.Logging;

// Token: 0x0200066D RID: 1645
public static class c8j
{
	// Token: 0x060029DC RID: 10716 RVA: 0x000ED814 File Offset: 0x000EBA14
	public static p9 a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		string filePath = d5x.f(A_0) + ".store";
		try
		{
			return eoq.DeserializeFromBinaryFileCompressed<p9>(filePath, dds.a(), true);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Failed to load store: '{0}'", new object[]
			{
				A_0
			});
		}
		return null;
	}
}
