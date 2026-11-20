using System;
using System.Collections.Generic;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x02000189 RID: 393
public sealed class ajd : d9d
{
	// Token: 0x06000BAC RID: 2988 RVA: 0x0002FAE8 File Offset: 0x0002DCE8
	public void o7(aiu A_0)
	{
		czh.a(A_0, "cursor");
		if (string.IsNullOrEmpty(A_0.y8()))
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
			{
				string a_ = "[GUI] - Cursor Manager was unable to add or update cursor because its name was either null or an empty string.";
				cvq.n7(LogSeverity.Error, 110, a_);
				return;
			}
		}
		else
		{
			this.a.a(A_0.y8(), A_0, this.b);
		}
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0002FB60 File Offset: 0x0002DD60
	public aiu o8(string A_0)
	{
		return this.a.SafeGet(A_0, this.b);
	}

	// Token: 0x040006E6 RID: 1766
	private Dictionary<string, aiu> a = new Dictionary<string, aiu>();

	// Token: 0x040006E7 RID: 1767
	private ReaderWriterLock b = new ReaderWriterLock();
}
