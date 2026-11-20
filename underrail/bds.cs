using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x0200012D RID: 301
[DebuggerDisplay("Count = {Count}")]
public sealed class bds : a1y
{
	// Token: 0x06000735 RID: 1845 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
	public int a()
	{
		return this.a.Count;
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
	internal void a(e6d A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 105))
		{
			cvq.n7(LogSeverity.Verbose, 105, "[Logic Manager] ExecuteAll begun...");
		}
		this.b.AcquireReaderLock(-1);
		try
		{
			foreach (z6 z in this.a)
			{
				z.d1(A_0);
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 105))
				{
					cvq.n7(LogSeverity.Verbose, 105, "[Logic Manager] Logic provider executed successfully: (" + z.qe().ToString() + ") " + z.y8());
				}
			}
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 105))
			{
				cvq.n7(LogSeverity.Verbose, 105, "[Logic Manager] ExecuteAll ended.");
			}
		}
		finally
		{
			this.b.ReleaseReaderLock();
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x0001DC08 File Offset: 0x0001BE08
	public void xf(z6 A_0)
	{
		cvq cvq = dr3.e();
		this.b.AcquireWriterLock(-1);
		try
		{
			this.a.Add(A_0);
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 105))
			{
				cvq.n7(LogSeverity.Information, 105, "[Logic Manager] New provider registered: (" + A_0.qe().ToString() + ") " + A_0.y8());
			}
		}
		finally
		{
			this.b.ReleaseWriterLock();
		}
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x0001DCA8 File Offset: 0x0001BEA8
	public void xg(z6 A_0)
	{
		cvq cvq = dr3.e();
		this.b.AcquireWriterLock(-1);
		try
		{
			if (this.a.Contains(A_0))
			{
				this.a.Remove(A_0);
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 105))
				{
					cvq.n7(LogSeverity.Information, 105, "[Logic Manager] Provider unregistered: (" + A_0.qe().ToString() + ") " + A_0.y8());
				}
			}
			else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 105))
			{
				cvq.n7(LogSeverity.Warning, 105, "[Logic Manager] Attempted to unregister unregistered provider: (" + A_0.qe().ToString() + ") " + A_0.y8());
			}
		}
		finally
		{
			this.b.ReleaseWriterLock();
		}
	}

	// Token: 0x04000553 RID: 1363
	private List<z6> a = new List<z6>();

	// Token: 0x04000554 RID: 1364
	private ReaderWriterLock b = new ReaderWriterLock();
}
