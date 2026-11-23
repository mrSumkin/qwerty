using System;
using Ouroboros.Core.Logging;

// Token: 0x02000131 RID: 305
internal class b1o
{
	// Token: 0x0600075F RID: 1887 RVA: 0x0001FA08 File Offset: 0x0001DC08
	public LogSeverity b()
	{
		return this.a;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0001FA10 File Offset: 0x0001DC10
	public void a(LogSeverity A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0001FA1C File Offset: 0x0001DC1C
	public int c()
	{
		return this.b;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0001FA24 File Offset: 0x0001DC24
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x0001FA30 File Offset: 0x0001DC30
	public string a()
	{
		return this.c;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0001FA38 File Offset: 0x0001DC38
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x0001FA44 File Offset: 0x0001DC44
	public override bool Equals(object obj)
	{
		b1o b1o = obj as b1o;
		if (b1o == null)
		{
			return false;
		}
		if (this.c() != b1o.c())
		{
			return false;
		}
		if (this.b() != b1o.b())
		{
			return false;
		}
		if (this.a() == null)
		{
			if (b1o.a() != null)
			{
				return false;
			}
		}
		else
		{
			if (b1o.a() == null)
			{
				return false;
			}
			if (!this.a().Equals(b1o.a(), StringComparison.Ordinal))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0001FAC8 File Offset: 0x0001DCC8
	public override int GetHashCode()
	{
		int num = 0;
		if (this.a() != null)
		{
			num += this.a().GetHashCode();
		}
		num += this.c().GetHashCode() * 10;
		return num + this.b().GetHashCode() * 100;
	}

	// Token: 0x0400055D RID: 1373
	private LogSeverity a;

	// Token: 0x0400055E RID: 1374
	private int b;

	// Token: 0x0400055F RID: 1375
	private string c;
}
