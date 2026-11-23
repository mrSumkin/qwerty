using System;
using System.Runtime.Serialization;

// Token: 0x020004D9 RID: 1241
[eiz("FR0")]
[Serializable]
public sealed class a7a : dnh, ISerializable
{
	// Token: 0x06001FE6 RID: 8166 RVA: 0x000AE7A4 File Offset: 0x000AC9A4
	private a7a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("FR0:S");
		this.b = A_0.GetString("FR0:T");
		this.c = (h)A_0.GetValue("FR0:A", typeof(h));
		this.d = (ei6)A_0.GetValue("FR0:C", typeof(ei6));
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000AE81C File Offset: 0x000ACA1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FR0:S", this.a);
		info.AddValue("FR0:T", this.b);
		info.AddValue("FR0:A", this.c);
		info.AddValue("FR0:C", this.d);
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000AE880 File Offset: 0x000ACA80
	public h c()
	{
		return this.c;
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000AE888 File Offset: 0x000ACA88
	public void a(h A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x000AE894 File Offset: 0x000ACA94
	public string b()
	{
		return this.a;
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000AE89C File Offset: 0x000ACA9C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000AE8A8 File Offset: 0x000ACAA8
	public string d()
	{
		return this.b;
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000AE8BC File Offset: 0x000ACABC
	public ei6 a()
	{
		return this.d;
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000AE8C4 File Offset: 0x000ACAC4
	public void a(ei6 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000AE8D0 File Offset: 0x000ACAD0
	public a7a()
	{
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x000AE8DC File Offset: 0x000ACADC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null)
		{
			return false;
		}
		cky cky = (serviceOrThrow.aqu().ac() as bv9).abu(this.a, this.b);
		h h;
		if (cky != null)
		{
			h = cky.a;
		}
		else
		{
			h = global::h.c;
		}
		switch (this.d)
		{
		case ei6.a:
			return h == this.c;
		case ei6.b:
			return h > this.c;
		case ei6.c:
			return h < this.c;
		case ei6.d:
			return h >= this.c;
		case ei6.e:
			return h <= this.c;
		case ei6.f:
			return h != this.c;
		default:
			return false;
		}
	}

	// Token: 0x040013EE RID: 5102
	private string a;

	// Token: 0x040013EF RID: 5103
	private string b;

	// Token: 0x040013F0 RID: 5104
	private h c;

	// Token: 0x040013F1 RID: 5105
	private ei6 d;
}
