using System;
using System.IO;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x020004B6 RID: 1206
[eiz("TS")]
[Serializable]
public sealed class ls : ISerializable
{
	// Token: 0x06001ED2 RID: 7890 RVA: 0x000AADC4 File Offset: 0x000A8FC4
	private ls(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (a94)A_0.GetValue("TS:G", typeof(a94));
		this.b = (cnt)A_0.GetValue("TS:V", typeof(cnt));
		this.c = (cic)A_0.GetValue("TS:A", typeof(cic));
		this.d = (a6t)A_0.GetValue("TS:I", typeof(a6t));
		if (ell.a() >= 140)
		{
			this.e = (A_0.GetValue("TS:S", typeof(edf)) as edf);
		}
		else
		{
			this.e = new edf();
		}
		if (ell.a() >= 179)
		{
			this.f = (A_0.GetValue("TS:C", typeof(b6i)) as b6i);
		}
		else
		{
			this.f = new b6i();
		}
		if (this.d.y() != this)
		{
			this.d.b(this);
		}
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x000AAEF4 File Offset: 0x000A90F4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TS:G", this.a);
		info.AddValue("TS:V", this.b);
		info.AddValue("TS:A", this.c);
		info.AddValue("TS:I", this.d);
		info.AddValue("TS:S", this.e);
		info.AddValue("TS:C", this.f);
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x000AAF68 File Offset: 0x000A9168
	public a94 c()
	{
		return this.a;
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000AAF70 File Offset: 0x000A9170
	public void a(a94 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000AAF7C File Offset: 0x000A917C
	public cnt g()
	{
		return this.b;
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000AAF84 File Offset: 0x000A9184
	public void a(cnt A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x000AAF90 File Offset: 0x000A9190
	public a6t b()
	{
		return this.d;
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000AAF98 File Offset: 0x000A9198
	public void a(a6t A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000AAFA4 File Offset: 0x000A91A4
	public cic h()
	{
		return this.c;
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000AAFAC File Offset: 0x000A91AC
	public void a(cic A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x000AAFB8 File Offset: 0x000A91B8
	public edf d()
	{
		return this.e;
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000AAFC0 File Offset: 0x000A91C0
	public void a(edf A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000AAFCC File Offset: 0x000A91CC
	public b6i e()
	{
		return this.f;
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000AAFD4 File Offset: 0x000A91D4
	public void a(b6i A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000AAFE0 File Offset: 0x000A91E0
	public ls()
	{
		this.a = new a94();
		this.b = new cnt();
		this.c = new cic();
		this.d = new a6t(this);
		this.e = new edf();
		this.f = new b6i();
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000AB038 File Offset: 0x000A9238
	public ls f()
	{
		ls ls = new ls();
		ls.a = this.a.b();
		ls.b = this.b.a();
		ls.c = this.c.a();
		ls.d = this.d.a(ls);
		ls.e = this.e.a();
		ls.f = this.f.e();
		return ls;
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x000AB0B4 File Offset: 0x000A92B4
	public static ls a()
	{
		string text = d5x.f();
		ls ls = null;
		try
		{
			if (File.Exists(text))
			{
				ls = eoq.DeserializeFromBinaryFileCompressed<ls>(text, dds.a(), true);
			}
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Не удалось загрузить файл конфигурации.", new object[0]);
		}
		if (ls == null)
		{
			ls = new ls();
			if (cxc.a())
			{
				ls.g().e = true;
			}
			if (cxc.b())
			{
				ls.b().q = true;
			}
		}
		return ls;
	}

	// Token: 0x04001391 RID: 5009
	private a94 a;

	// Token: 0x04001392 RID: 5010
	private cnt b;

	// Token: 0x04001393 RID: 5011
	private cic c;

	// Token: 0x04001394 RID: 5012
	private a6t d;

	// Token: 0x04001395 RID: 5013
	private edf e;

	// Token: 0x04001396 RID: 5014
	private b6i f;
}
