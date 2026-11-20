using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000132 RID: 306
[eiz("LC")]
[Serializable]
public sealed class a0j : ICloneable, ISerializable
{
	// Token: 0x06000768 RID: 1896 RVA: 0x0001FB2C File Offset: 0x0001DD2C
	private a0j(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("LC:AN");
			this.b = A_0.GetBoolean("LC:E");
			this.c = (LogSeverity)A_0.GetValue("LC:WELL", typeof(LogSeverity));
			this.d = (LogSeverity)A_0.GetValue("LC:TLL", typeof(LogSeverity));
			this.e = (LogSeverity)A_0.GetValue("LC:FLL", typeof(LogSeverity));
			this.f = (HashSet<int>)A_0.GetValue("LC:EC", typeof(HashSet<int>));
			this.g = A_0.GetInt32("LC:SRF");
			return;
		}
		if (base.GetType() == typeof(a0j))
		{
			this.a = A_0.GetString("_AppName");
			this.b = A_0.GetBoolean("_Enabled");
			this.c = (LogSeverity)A_0.GetValue("_WindowsEventLoggingLevel", typeof(LogSeverity));
			this.d = (LogSeverity)A_0.GetValue("_TraceLoggingLevel", typeof(LogSeverity));
			this.e = (LogSeverity)A_0.GetValue("_FileLoggingLevel", typeof(LogSeverity));
			this.f = (HashSet<int>)A_0.GetValue("_ExcludedCodes", typeof(HashSet<int>));
			this.g = A_0.GetInt32("_SuppressRepeatedFor");
			return;
		}
		this.a = A_0.GetString("LoggingConfiguration+_AppName");
		this.b = A_0.GetBoolean("LoggingConfiguration+_Enabled");
		this.c = (LogSeverity)A_0.GetValue("LoggingConfiguration+_WindowsEventLoggingLevel", typeof(LogSeverity));
		this.d = (LogSeverity)A_0.GetValue("LoggingConfiguration+_TraceLoggingLevel", typeof(LogSeverity));
		this.e = (LogSeverity)A_0.GetValue("LoggingConfiguration+_FileLoggingLevel", typeof(LogSeverity));
		this.f = (HashSet<int>)A_0.GetValue("LoggingConfiguration+_ExcludedCodes", typeof(HashSet<int>));
		this.g = A_0.GetInt32("LoggingConfiguration+_SuppressRepeatedFor");
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LC:AN", this.a);
		info.AddValue("LC:E", this.b);
		info.AddValue("LC:WELL", this.c);
		info.AddValue("LC:TLL", this.d);
		info.AddValue("LC:FLL", this.e);
		info.AddValue("LC:EC", this.f);
		info.AddValue("LC:SRF", this.g);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x0001FE34 File Offset: 0x0001E034
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x0001FE3C File Offset: 0x0001E03C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x0001FE48 File Offset: 0x0001E048
	public LogSeverity a()
	{
		return this.c;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0001FE50 File Offset: 0x0001E050
	public void c(LogSeverity A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0001FE5C File Offset: 0x0001E05C
	public LogSeverity e()
	{
		return this.d;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x0001FE64 File Offset: 0x0001E064
	public void b(LogSeverity A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x0001FE70 File Offset: 0x0001E070
	public LogSeverity f()
	{
		return this.e;
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x0001FE78 File Offset: 0x0001E078
	public void a(LogSeverity A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0001FE84 File Offset: 0x0001E084
	public HashSet<int> b()
	{
		return this.f;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0001FE8C File Offset: 0x0001E08C
	public bool g()
	{
		return this.b;
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0001FE94 File Offset: 0x0001E094
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
	public int d()
	{
		return this.g;
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
	public void a(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
	public a0j()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
	public object Clone()
	{
		a0j a0j = new a0j();
		a0j.a = this.a;
		a0j.b = this.b;
		a0j.e = this.e;
		a0j.g = this.g;
		a0j.d = this.d;
		a0j.c = this.c;
		if (this.f != null)
		{
			a0j.f = new HashSet<int>();
			foreach (int num in this.f)
			{
				a0j.f.Add(num);
			}
		}
		return a0j;
	}

	// Token: 0x04000560 RID: 1376
	private string a;

	// Token: 0x04000561 RID: 1377
	private bool b;

	// Token: 0x04000562 RID: 1378
	private LogSeverity c = LogSeverity.CriticalError;

	// Token: 0x04000563 RID: 1379
	private LogSeverity d = LogSeverity.Information;

	// Token: 0x04000564 RID: 1380
	private LogSeverity e = LogSeverity.Warning;

	// Token: 0x04000565 RID: 1381
	private HashSet<int> f = new HashSet<int>();

	// Token: 0x04000566 RID: 1382
	private int g;
}
