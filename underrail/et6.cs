using System;
using System.Runtime.Serialization;

// Token: 0x02000FC1 RID: 4033
[eiz("CHSEC")]
[Serializable]
public sealed class et6 : dnh, ISerializable
{
	// Token: 0x060052C0 RID: 21184 RVA: 0x0024EC08 File Offset: 0x0024CE08
	private et6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CHSEC:CIP");
		this.b = (Guid?)A_0.GetValue("CHSEC:I", typeof(Guid?));
		this.c = A_0.GetString("CHSEC:A");
		this.d = A_0.GetBoolean("CHSEC:N");
		this.e = A_0.GetString("CHSEC:S");
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x0024EC84 File Offset: 0x0024CE84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHSEC:CIP", this.a);
		info.AddValue("CHSEC:I", this.b);
		info.AddValue("CHSEC:A", this.c);
		info.AddValue("CHSEC:N", this.d);
		info.AddValue("CHSEC:S", this.e);
	}

	// Token: 0x060052C2 RID: 21186 RVA: 0x0024ECF4 File Offset: 0x0024CEF4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060052C3 RID: 21187 RVA: 0x0024ECFC File Offset: 0x0024CEFC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052C4 RID: 21188 RVA: 0x0024ED08 File Offset: 0x0024CF08
	public string c()
	{
		return this.c;
	}

	// Token: 0x060052C5 RID: 21189 RVA: 0x0024ED10 File Offset: 0x0024CF10
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060052C6 RID: 21190 RVA: 0x0024ED1C File Offset: 0x0024CF1C
	public Guid? e()
	{
		return this.b;
	}

	// Token: 0x060052C7 RID: 21191 RVA: 0x0024ED24 File Offset: 0x0024CF24
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052C8 RID: 21192 RVA: 0x0024ED30 File Offset: 0x0024CF30
	public bool a()
	{
		return this.d;
	}

	// Token: 0x060052C9 RID: 21193 RVA: 0x0024ED38 File Offset: 0x0024CF38
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x0024ED44 File Offset: 0x0024CF44
	public string d()
	{
		return this.e;
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x0024ED4C File Offset: 0x0024CF4C
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060052CC RID: 21196 RVA: 0x0024ED58 File Offset: 0x0024CF58
	public et6()
	{
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x0024ED60 File Offset: 0x0024CF60
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrWhiteSpace(this.e))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() != null)
			{
				b0b b0b = null;
				if (this.a)
				{
					b0b = serviceOrThrow.aqu().v().b();
				}
				else if (this.b != null && !string.IsNullOrEmpty(this.c))
				{
					aud aud = serviceOrThrow.aqw().n(this.c);
					if (aud != null)
					{
						b0b = new ar7(this.b.Value, aud).ao();
					}
				}
				else if (!(A_0.get_Item(c49.a) as c5x).IsPlayer)
				{
					b0b = (A_0.GetPropertyValue(c49.a) as b0b);
				}
				else
				{
					b0b = (A_0.GetPropertyValue(c49.b) as b0b);
				}
				if (b0b != null)
				{
					amc aspect = b0b.GetAspect<amc>();
					if (aspect != null)
					{
						flag = aspect.aa().StatusEffects.a(this.e);
					}
				}
			}
		}
		return flag ^ this.d;
	}

	// Token: 0x040021DF RID: 8671
	private bool a;

	// Token: 0x040021E0 RID: 8672
	private Guid? b;

	// Token: 0x040021E1 RID: 8673
	private string c;

	// Token: 0x040021E2 RID: 8674
	private bool d;

	// Token: 0x040021E3 RID: 8675
	private string e;
}
