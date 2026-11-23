using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001097 RID: 4247
[eiz("FMCFZ")]
[Serializable]
public sealed class dqd : cze, ISerializable
{
	// Token: 0x060058FD RID: 22781 RVA: 0x00268AB4 File Offset: 0x00266CB4
	private dqd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("FMCFZ:FI");
		this.b = A_0.GetString("FMCFZ:GP");
		this.c = A_0.GetString("FMCFZ:GPISE");
		this.d = A_0.GetString("FMCFZ:AOO");
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x00268B10 File Offset: 0x00266D10
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FMCFZ:FI", this.a);
		info.AddValue("FMCFZ:GP", this.b);
		info.AddValue("FMCFZ:GPISE", this.c);
		info.AddValue("FMCFZ:AOO", this.d);
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x00268B6C File Offset: 0x00266D6C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005900 RID: 22784 RVA: 0x00268B74 File Offset: 0x00266D74
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x00268B80 File Offset: 0x00266D80
	public string d()
	{
		return this.b;
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x00268B88 File Offset: 0x00266D88
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x00268B94 File Offset: 0x00266D94
	public string c()
	{
		return this.c;
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x00268B9C File Offset: 0x00266D9C
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x00268BA8 File Offset: 0x00266DA8
	public string b()
	{
		return this.d;
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x00268BB0 File Offset: 0x00266DB0
	public void d(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x00268BBC File Offset: 0x00266DBC
	public dqd()
	{
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x00268BC4 File Offset: 0x00266DC4
	public dqd(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x00268BDC File Offset: 0x00266DDC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		string name;
		if (this.c != null && !string.IsNullOrWhiteSpace(this.c))
		{
			name = this.c;
		}
		else
		{
			name = this.b;
		}
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == this.a)
				{
					if (this.d == null || string.IsNullOrWhiteSpace(this.d))
					{
						serviceOrThrow.aqu().r()[this.b] = false;
						return;
					}
					if (d4n.b.a8().Area.ToString() == this.d)
					{
						serviceOrThrow.aqu().r()[this.b] = false;
						return;
					}
				}
			}
			serviceOrThrow.aqu().r()[this.b] = true;
		}
	}

	// Token: 0x040023D3 RID: 9171
	private new string a;

	// Token: 0x040023D4 RID: 9172
	private string b;

	// Token: 0x040023D5 RID: 9173
	private string c;

	// Token: 0x040023D6 RID: 9174
	private string d;
}
