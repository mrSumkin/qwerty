using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x02000130 RID: 304
public class aa5 : cvq
{
	// Token: 0x06000757 RID: 1879 RVA: 0x0001F698 File Offset: 0x0001D898
	private a0j a()
	{
		return this.c;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
	public aa5()
	{
		this.c = new a0j();
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
	public aa5(a0j A_0)
	{
		if (A_0 != null)
		{
			this.c = A_0;
		}
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x0001F6CC File Offset: 0x0001D8CC
	public void n7(LogSeverity A_0, int A_1, string A_2)
	{
		if (!this.n8() || !this.n9(A_0, A_1))
		{
			return;
		}
		b1o b1o = new b1o();
		b1o.a(A_0);
		b1o.a(A_1);
		b1o.a(A_2);
		if (this.a().d() > 0)
		{
			aa5.b.AcquireReaderLock(-1);
			try
			{
				if (aa5.a.ContainsKey(b1o))
				{
					return;
				}
			}
			finally
			{
				aa5.b.ReleaseReaderLock();
			}
		}
		string text = string.Concat(new string[]
		{
			this.c.c(),
			" (Ouroboros) - ",
			A_0.ToString(),
			" - ",
			A_1.ToString(CultureInfo.InvariantCulture),
			" : ",
			A_2,
			"\n"
		});
		if (A_0 >= this.a().e())
		{
			Trace.WriteLine(text);
		}
		this.a().a();
		this.a().f();
		e0r service = bpo.GetService<e0r>();
		if (service != null)
		{
			cvq cvq = service.atj();
			if (cvq != null && cvq.n8() && cvq.n9(A_0, A_1))
			{
				cvq.n7(A_0, A_1, A_2);
			}
		}
		if (this.a().d() > 0)
		{
			aa5.b.AcquireWriterLock(-1);
			try
			{
				aa5.a.Add(b1o, DateTime.Now + TimeSpan.FromMilliseconds((double)this.a().d()));
			}
			finally
			{
				aa5.b.ReleaseWriterLock();
			}
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x0001F888 File Offset: 0x0001DA88
	public bool n8()
	{
		return this.c.g();
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x0001F898 File Offset: 0x0001DA98
	public bool n9(LogSeverity A_0, int A_1)
	{
		bool flag = false;
		bool flag2 = false;
		if (A_0 >= this.c.f())
		{
			flag = true;
		}
		else if (A_0 >= this.c.e())
		{
			flag = true;
		}
		else if (A_0 >= this.c.a())
		{
			flag = true;
		}
		if (!this.c.b().Contains(A_1))
		{
			flag2 = true;
		}
		return flag && flag2;
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x0001F908 File Offset: 0x0001DB08
	public void b()
	{
		aa5.b.AcquireWriterLock(-1);
		List<b1o> list = new List<b1o>();
		try
		{
			foreach (KeyValuePair<b1o, DateTime> keyValuePair in aa5.a)
			{
				if (DateTime.Now > keyValuePair.Value)
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (b1o key in list)
			{
				aa5.a.Remove(key);
			}
		}
		finally
		{
			aa5.b.ReleaseWriterLock();
		}
	}

	// Token: 0x0400055A RID: 1370
	private static Dictionary<b1o, DateTime> a = new Dictionary<b1o, DateTime>();

	// Token: 0x0400055B RID: 1371
	private static ReaderWriterLock b = new ReaderWriterLock();

	// Token: 0x0400055C RID: 1372
	private a0j c;
}
