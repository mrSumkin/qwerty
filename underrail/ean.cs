using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B55 RID: 6997
[eiz("M22")]
[Serializable]
public sealed class ean : d09, y3
{
	// Token: 0x0600976F RID: 38767 RVA: 0x003B0C54 File Offset: 0x003AEE54
	private ean(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (DamageType)A_0.GetValue("M22:A", typeof(DamageType));
		this.b = A_0.GetDouble("M22:B");
		this.c = A_0.GetDouble("M22:C");
		this.d = A_0.GetInt32("M22:D");
		this.e = A_0.GetInt32("M22:E");
		this.f = (a1q?)A_0.GetValue("M22:F", typeof(a1q?));
		if (ell.a() >= 114)
		{
			this.g = A_0.GetBoolean("M22:U");
		}
	}

	// Token: 0x06009770 RID: 38768 RVA: 0x003B0D0C File Offset: 0x003AEF0C
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("M22:A", this.a);
		info.AddValue("M22:B", this.b);
		info.AddValue("M22:C", this.c);
		info.AddValue("M22:D", this.d);
		info.AddValue("M22:E", this.e);
		info.AddValue("M22:F", this.f);
		info.AddValue("M22:U", this.g);
	}

	// Token: 0x06009771 RID: 38769 RVA: 0x003B0DA4 File Offset: 0x003AEFA4
	public DamageType c()
	{
		return this.a;
	}

	// Token: 0x06009772 RID: 38770 RVA: 0x003B0DAC File Offset: 0x003AEFAC
	public void a(DamageType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009773 RID: 38771 RVA: 0x003B0DB8 File Offset: 0x003AEFB8
	public double b()
	{
		return this.b;
	}

	// Token: 0x06009774 RID: 38772 RVA: 0x003B0DC0 File Offset: 0x003AEFC0
	public void b(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009775 RID: 38773 RVA: 0x003B0DCC File Offset: 0x003AEFCC
	public double g()
	{
		return this.c;
	}

	// Token: 0x06009776 RID: 38774 RVA: 0x003B0DD4 File Offset: 0x003AEFD4
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009777 RID: 38775 RVA: 0x003B0DE0 File Offset: 0x003AEFE0
	public int a()
	{
		return this.d;
	}

	// Token: 0x06009778 RID: 38776 RVA: 0x003B0DE8 File Offset: 0x003AEFE8
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06009779 RID: 38777 RVA: 0x003B0DF4 File Offset: 0x003AEFF4
	public int e()
	{
		return this.e;
	}

	// Token: 0x0600977A RID: 38778 RVA: 0x003B0DFC File Offset: 0x003AEFFC
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600977B RID: 38779 RVA: 0x003B0E08 File Offset: 0x003AF008
	public a1q? f()
	{
		return this.f;
	}

	// Token: 0x0600977C RID: 38780 RVA: 0x003B0E10 File Offset: 0x003AF010
	public void a(a1q? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600977D RID: 38781 RVA: 0x003B0E1C File Offset: 0x003AF01C
	public bool d()
	{
		return this.g;
	}

	// Token: 0x0600977E RID: 38782 RVA: 0x003B0E24 File Offset: 0x003AF024
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600977F RID: 38783 RVA: 0x003B0E30 File Offset: 0x003AF030
	public ean()
	{
	}

	// Token: 0x06009780 RID: 38784 RVA: 0x003B0E3C File Offset: 0x003AF03C
	public override List<cwt> ar5(cwt A_0)
	{
		if (this.f != null && A_0 != null && A_0.b && (this.g ? (A_0.aa || euf.c(A_0.ae)) : A_0.z))
		{
			cwt cwt = new cwt();
			cwt.i = A_0.i;
			cwt.j = A_0.j;
			cwt.b = true;
			cwt.h = ImpactSpeed.VeryLow;
			cwt.k = "armor";
			cwt.z = true;
			csk item = euf.a(this.f.Value, 1.0);
			cwt.f.Add(item);
			return new List<cwt>
			{
				cwt
			};
		}
		return null;
	}

	// Token: 0x06009781 RID: 38785 RVA: 0x003B0F14 File Offset: 0x003AF114
	public override string xq()
	{
		if (this.f() == null)
		{
			return null;
		}
		if (this.g)
		{
			return qv.a("Items\\ArmorItemModifier/ExtraUnarmedAndFistWeaponDamage", new object[]
			{
				this.f
			});
		}
		return qv.a("Items\\ArmorItemModifier/ExtraMeleeDamage", new object[]
		{
			this.f
		});
	}

	// Token: 0x06009782 RID: 38786 RVA: 0x003B0F80 File Offset: 0x003AF180
	public override c3e xs(int A_0)
	{
		return new ean
		{
			f = new a1q?(new a1q(this.a, (int)((double)this.d + (double)A_0 * this.b), (int)((double)this.e + (double)A_0 * this.c)))
		};
	}

	// Token: 0x06009783 RID: 38787 RVA: 0x003B0FCC File Offset: 0x003AF1CC
	public override c3e xr()
	{
		ean ean = new ean();
		this.ael(ean);
		return ean;
	}

	// Token: 0x06009784 RID: 38788 RVA: 0x003B0FE8 File Offset: 0x003AF1E8
	public void ao1(c3e A_0)
	{
		ean ean = A_0 as ean;
		if (ean != null)
		{
			this.f = new a1q?(new a1q(this.f.Value.DamageType, this.f().Value.LowerBoundary + ean.f.Value.LowerBoundary, this.f().Value.UpperBoundary + ean.f.Value.UpperBoundary));
		}
	}

	// Token: 0x06009785 RID: 38789 RVA: 0x003B107C File Offset: 0x003AF27C
	public bool ao2(c3e A_0)
	{
		ean ean = A_0 as ean;
		return ean != null && ean.f != null && ean.f.Value.DamageType == this.a && ean.g == this.g;
	}

	// Token: 0x06009786 RID: 38790 RVA: 0x003B10D4 File Offset: 0x003AF2D4
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		ean ean = (ean)A_0;
		ean.f = this.f;
		ean.a = this.a;
		ean.d = this.d;
		ean.b = this.b;
		ean.g = this.g;
		ean.e = this.e;
		ean.c = this.c;
	}

	// Token: 0x04003A2C RID: 14892
	private DamageType a;

	// Token: 0x04003A2D RID: 14893
	private double b;

	// Token: 0x04003A2E RID: 14894
	private double c;

	// Token: 0x04003A2F RID: 14895
	private int d;

	// Token: 0x04003A30 RID: 14896
	private int e;

	// Token: 0x04003A31 RID: 14897
	private a1q? f;

	// Token: 0x04003A32 RID: 14898
	private bool g;
}
