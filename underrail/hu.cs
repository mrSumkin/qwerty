using System;
using Ouroboros.Core.Logging;

// Token: 0x02000FFF RID: 4095
public static class hu
{
	// Token: 0x0600542E RID: 21550 RVA: 0x002541CC File Offset: 0x002523CC
	public static esl a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string str = d5x.b(A_0);
			try
			{
				return eoq.DeserializeFromBinaryFileCompressed<esl>(str + ".char", dds.a(), true);
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "Failed to load character definition '{0}'.", new object[]
				{
					A_0
				});
			}
		}
		return null;
	}
}
