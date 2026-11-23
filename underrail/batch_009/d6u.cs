using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020004C7 RID: 1223
[eiz("EIIRC")]
[Serializable]
public sealed class d6u : dnh, ISerializable
{
	// Token: 0x06001F45 RID: 8005 RVA: 0x000ACC88 File Offset: 0x000AAE88
	private d6u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("EIIRC:D");
		this.b = A_0.GetBoolean("EIIRC:I");
		this.c = (A_0.GetValue("EIIRC:IN", typeof(Guid?)) as Guid?);
		this.d = (A_0.GetValue("EIIRC:T", typeof(Guid?)) as Guid?);
		this.e = A_0.GetString("EIIRC:IR");
		this.f = A_0.GetString("EIIRC:TR");
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x000ACD2C File Offset: 0x000AAF2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EIIRC:D", this.a);
		info.AddValue("EIIRC:I", this.b);
		info.AddValue("EIIRC:IN", this.c);
		info.AddValue("EIIRC:T", this.d);
		info.AddValue("EIIRC:IR", this.e);
		info.AddValue("EIIRC:TR", this.f);
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
	public double e()
	{
		return this.a;
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000ACDBC File Offset: 0x000AAFBC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x000ACDC8 File Offset: 0x000AAFC8
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x000ACDD0 File Offset: 0x000AAFD0
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x000ACDDC File Offset: 0x000AAFDC
	public Guid? f()
	{
		return this.c;
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000ACDE4 File Offset: 0x000AAFE4
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000ACDF0 File Offset: 0x000AAFF0
	public Guid? d()
	{
		return this.d;
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000ACDF8 File Offset: 0x000AAFF8
	public void b(Guid? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000ACE04 File Offset: 0x000AB004
	public string c()
	{
		return this.e;
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000ACE0C File Offset: 0x000AB00C
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000ACE18 File Offset: 0x000AB018
	public string b()
	{
		return this.f;
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x000ACE20 File Offset: 0x000AB020
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x000ACE2C File Offset: 0x000AB02C
	public d6u()
	{
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000ACE38 File Offset: 0x000AB038
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			b0b b0b = null;
			b0b b0b2 = null;
			if (this.c != null && this.d != null)
			{
				b0b = new ar7(this.c.Value, serviceOrThrow.aqu().v().b().Area).ao();
				b0b2 = new ar7(this.c.Value, serviceOrThrow.aqu().v().b().Area).ao();
			}
			else if (!string.IsNullOrWhiteSpace(this.e) && !string.IsNullOrWhiteSpace(this.f))
			{
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					b0b = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						this.e
					}));
					b0b2 = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						this.f
					}));
				}
			}
			else
			{
				b0b = (A_0.GetPropertyValue(c49.a) as b0b);
				b0b2 = (A_0.GetPropertyValue(c49.b) as b0b);
			}
			if (b0b != null && b0b2 != null)
			{
				ak1 ak = Enumerable.FirstOrDefault<ak1>(b0b2.l);
				if (ak != null)
				{
					flag = (aw1.a(b0b, ak) <= this.a);
				}
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013BF RID: 5055
	private double a;

	// Token: 0x040013C0 RID: 5056
	private bool b;

	// Token: 0x040013C1 RID: 5057
	private Guid? c;

	// Token: 0x040013C2 RID: 5058
	private Guid? d;

	// Token: 0x040013C3 RID: 5059
	private string e;

	// Token: 0x040013C4 RID: 5060
	private string f;
}
