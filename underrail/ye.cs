using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x0200012F RID: 303
[DebuggerDisplay("Count = {Count}")]
public sealed class ye : s6
{
	// Token: 0x06000752 RID: 1874 RVA: 0x0001F2DC File Offset: 0x0001D4DC
	public int a()
	{
		return this.a.Count;
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0001F30C File Offset: 0x0001D50C
	internal void a(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		this.b.AcquireReaderLock(-1);
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 106))
		{
			cvq.n7(LogSeverity.Verbose, 106, "[Rendering Manager] RenderAll begun...");
		}
		try
		{
			foreach (ajx ajx in this.a)
			{
				try
				{
					ajx.q0(A_0, A_1);
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 106))
					{
						cvq.n7(LogSeverity.Verbose, 106, "[Rendering Manager] Renderer executed successfully: (" + ajx.qe().ToString() + ") " + ajx.y8());
					}
				}
				catch (Exception ex)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 106))
					{
						cvq.n7(LogSeverity.Error, 106, string.Concat(new string[]
						{
							"[Rendering Manager] Error occurred while executing renderer: (",
							ajx.qe().ToString(),
							") ",
							ajx.y8(),
							". Exception: ",
							ex.ToString()
						}));
					}
				}
			}
		}
		finally
		{
			this.b.ReleaseReaderLock();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 106))
			{
				cvq.n7(LogSeverity.Verbose, 106, "[Rendering Manager] RenderAll ended.");
			}
		}
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0001F4F0 File Offset: 0x0001D6F0
	public void m6(ajx A_0)
	{
		cvq cvq = dr3.e();
		this.b.AcquireWriterLock(-1);
		try
		{
			this.a.Add(A_0);
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 106))
			{
				cvq.n7(LogSeverity.Information, 106, "[Rendering Manager] New renderer registered: (" + A_0.qe().ToString() + ") " + A_0.y8());
			}
		}
		finally
		{
			this.b.ReleaseWriterLock();
		}
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0001F590 File Offset: 0x0001D790
	public void m7(ajx A_0)
	{
		cvq cvq = dr3.e();
		this.b.AcquireWriterLock(-1);
		try
		{
			if (this.a.Contains(A_0))
			{
				this.a.Remove(A_0);
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 106))
				{
					cvq.n7(LogSeverity.Information, 106, "[Rendering Manager] Renderer unregistered: (" + A_0.qe().ToString() + ") " + A_0.y8());
				}
			}
			else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 106))
			{
				cvq.n7(LogSeverity.Warning, 106, "[Rendering Manager] Attempted to unregister unregistered renderer: (" + A_0.qe().ToString() + ") " + A_0.y8());
			}
		}
		finally
		{
			this.b.ReleaseWriterLock();
		}
	}

	// Token: 0x04000558 RID: 1368
	private List<ajx> a = new List<ajx>();

	// Token: 0x04000559 RID: 1369
	private ReaderWriterLock b = new ReaderWriterLock();
}
