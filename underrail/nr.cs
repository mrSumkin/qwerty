using System;
using System.Runtime.Serialization;

// Token: 0x020004D6 RID: 1238
[eiz("YE")]
[Serializable]
public sealed class nr : dnh, ISerializable
{
	// Token: 0x06001FC8 RID: 8136 RVA: 0x000AE328 File Offset: 0x000AC528
	private nr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("YE:I", typeof(Guid?));
		this.b = A_0.GetString("YE:A");
		this.c = A_0.GetBoolean("YE:N");
		this.d = A_0.GetString("YE:W");
		this.e = A_0.GetBoolean("YE:D");
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000AE3A4 File Offset: 0x000AC5A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YE:I", this.a);
		info.AddValue("YE:A", this.b);
		info.AddValue("YE:N", this.c);
		info.AddValue("YE:W", this.d);
		info.AddValue("YE:D", this.e);
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000AE414 File Offset: 0x000AC614
	public string b()
	{
		return this.b;
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000AE41C File Offset: 0x000AC61C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000AE428 File Offset: 0x000AC628
	public Guid? e()
	{
		return this.a;
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000AE430 File Offset: 0x000AC630
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000AE43C File Offset: 0x000AC63C
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000AE444 File Offset: 0x000AC644
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000AE450 File Offset: 0x000AC650
	public string c()
	{
		return this.d;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000AE458 File Offset: 0x000AC658
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000AE464 File Offset: 0x000AC664
	public bool d()
	{
		return this.e;
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000AE46C File Offset: 0x000AC66C
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000AE478 File Offset: 0x000AC678
	public nr()
	{
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000AE480 File Offset: 0x000AC680
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() != null)
			{
				b0b b0b = null;
				if (this.a != null && !string.IsNullOrEmpty(this.b))
				{
					aud aud = serviceOrThrow.aqw().n(this.b);
					if (aud != null)
					{
						b0b = new ar7(this.a.Value, aud).ao();
					}
				}
				else
				{
					b0b = (A_0.GetPropertyValue(c49.b) as b0b);
				}
				if (b0b != null)
				{
					flag = aw1.a(b0b, new bt4(this.d), this.e);
				}
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x040013E5 RID: 5093
	private Guid? a;

	// Token: 0x040013E6 RID: 5094
	private string b;

	// Token: 0x040013E7 RID: 5095
	private bool c;

	// Token: 0x040013E8 RID: 5096
	private string d;

	// Token: 0x040013E9 RID: 5097
	private bool e;
}
