using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020010E2 RID: 4322
[eiz("XC8")]
[Serializable]
public sealed class adn : cze, ISerializable
{
	// Token: 0x06005B27 RID: 23335 RVA: 0x0027360C File Offset: 0x0027180C
	private adn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("XC8:I", typeof(Guid?));
		this.b = A_0.GetString("XC8:A");
		this.d = A_0.GetBoolean("XC8:M");
		this.c = A_0.GetInt32("XC8:D");
	}

	// Token: 0x06005B28 RID: 23336 RVA: 0x00273674 File Offset: 0x00271874
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XC8:I", this.a);
		info.AddValue("XC8:A", this.b);
		info.AddValue("XC8:M", this.d);
		info.AddValue("XC8:D", this.c);
	}

	// Token: 0x06005B29 RID: 23337 RVA: 0x002736D4 File Offset: 0x002718D4
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005B2A RID: 23338 RVA: 0x002736DC File Offset: 0x002718DC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B2B RID: 23339 RVA: 0x002736E8 File Offset: 0x002718E8
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005B2C RID: 23340 RVA: 0x002736F0 File Offset: 0x002718F0
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B2D RID: 23341 RVA: 0x002736FC File Offset: 0x002718FC
	public int d()
	{
		return this.c;
	}

	// Token: 0x06005B2E RID: 23342 RVA: 0x00273704 File Offset: 0x00271904
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B2F RID: 23343 RVA: 0x00273710 File Offset: 0x00271910
	public bool c()
	{
		return this.d;
	}

	// Token: 0x06005B30 RID: 23344 RVA: 0x00273718 File Offset: 0x00271918
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B31 RID: 23345 RVA: 0x00273724 File Offset: 0x00271924
	public adn()
	{
	}

	// Token: 0x06005B32 RID: 23346 RVA: 0x00273730 File Offset: 0x00271930
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null)
		{
			amc amc = c5x.h.b;
			if (!this.d && (amc.aa().Passive || (amc.aa().c(d8o.e) && amc.aa().d(CharacterImmunities.ShortCircuiting)) || (!amc.aa().c(d8o.e) && amc.aa().d(CharacterImmunities.Stun))))
			{
				etm etm;
				if (amc.aa().c(d8o.e))
				{
					etm = new etm(new ap9(amc.aa()), "короткому замыканию");
				}
				else
				{
					etm = new etm(new ap9(amc.aa()), "оглушению");
				}
				etm.j().a(true);
				a7v.a(etm);
				bmj.a(c5x, new ba0());
				return;
			}
			els a_;
			if (amc.aa().c(d8o.e))
			{
				a_ = new clt(this.c);
			}
			else
			{
				a_ = new ab3(this.c);
			}
			amc.aa().StatusEffects.a(a_, false, false, false);
		}
	}

	// Token: 0x0400246B RID: 9323
	private new Guid? a;

	// Token: 0x0400246C RID: 9324
	private string b;

	// Token: 0x0400246D RID: 9325
	private int c;

	// Token: 0x0400246E RID: 9326
	private bool d;
}
