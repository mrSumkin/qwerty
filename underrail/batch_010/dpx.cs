using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B51 RID: 6993
[eiz("M23")]
[Serializable]
public sealed class dpx : d09, y3
{
	// Token: 0x0600974A RID: 38730 RVA: 0x003B0528 File Offset: 0x003AE728
	private dpx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M23:B");
		this.b = A_0.GetDouble("M23:C");
		this.c = A_0.GetInt32("M23:D");
		this.d = A_0.GetInt32("M23:E");
		this.e = (a1q?)A_0.GetValue("M23:F", typeof(a1q?));
		this.f = A_0.GetDouble("M23:G");
		this.g = A_0.GetInt32("M23:H");
		if (ell.a() >= 114)
		{
			this.h = A_0.GetBoolean("M23:U");
		}
	}

	// Token: 0x0600974B RID: 38731 RVA: 0x003B05E0 File Offset: 0x003AE7E0
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("M23:B", this.a);
		info.AddValue("M23:C", this.b);
		info.AddValue("M23:D", this.c);
		info.AddValue("M23:E", this.d);
		info.AddValue("M23:F", this.e);
		info.AddValue("M23:G", this.f);
		info.AddValue("M23:H", this.g);
		info.AddValue("M23:U", this.h);
	}

	// Token: 0x0600974C RID: 38732 RVA: 0x003B0684 File Offset: 0x003AE884
	public double c()
	{
		return this.a;
	}

	// Token: 0x0600974D RID: 38733 RVA: 0x003B068C File Offset: 0x003AE88C
	public void b(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600974E RID: 38734 RVA: 0x003B0698 File Offset: 0x003AE898
	public double h()
	{
		return this.b;
	}

	// Token: 0x0600974F RID: 38735 RVA: 0x003B06A0 File Offset: 0x003AE8A0
	public void c(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009750 RID: 38736 RVA: 0x003B06AC File Offset: 0x003AE8AC
	public int a()
	{
		return this.c;
	}

	// Token: 0x06009751 RID: 38737 RVA: 0x003B06B4 File Offset: 0x003AE8B4
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009752 RID: 38738 RVA: 0x003B06C0 File Offset: 0x003AE8C0
	public int e()
	{
		return this.d;
	}

	// Token: 0x06009753 RID: 38739 RVA: 0x003B06C8 File Offset: 0x003AE8C8
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06009754 RID: 38740 RVA: 0x003B06D4 File Offset: 0x003AE8D4
	public a1q? f()
	{
		return this.e;
	}

	// Token: 0x06009755 RID: 38741 RVA: 0x003B06DC File Offset: 0x003AE8DC
	public void a(a1q? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06009756 RID: 38742 RVA: 0x003B06E8 File Offset: 0x003AE8E8
	public double d()
	{
		return this.f;
	}

	// Token: 0x06009757 RID: 38743 RVA: 0x003B06F0 File Offset: 0x003AE8F0
	public void a(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06009758 RID: 38744 RVA: 0x003B06FC File Offset: 0x003AE8FC
	public int g()
	{
		return this.g;
	}

	// Token: 0x06009759 RID: 38745 RVA: 0x003B0704 File Offset: 0x003AE904
	public void a(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600975A RID: 38746 RVA: 0x003B0710 File Offset: 0x003AE910
	public bool b()
	{
		return this.h;
	}

	// Token: 0x0600975B RID: 38747 RVA: 0x003B0718 File Offset: 0x003AE918
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600975C RID: 38748 RVA: 0x003B0724 File Offset: 0x003AE924
	public dpx()
	{
	}

	// Token: 0x0600975D RID: 38749 RVA: 0x003B0730 File Offset: 0x003AE930
	public override void ao0(cwt A_0, efk A_1, List<csk> A_2)
	{
		if (cuo.a.NextDouble() < this.f && A_2 != null && A_0 != null && A_0.b && (this.h ? A_0.aa : A_0.z) && !A_1.c(d8o.e) && !A_1.d(CharacterImmunities.Bleeding))
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_2, new Func<csk, bool>(dpx.a.a.a)), new Func<csk, int>(dpx.a.a.b)) > 0)
			{
				int num = euf.a(this.e.Value, 1.0).Amount;
				if (num > 0)
				{
					a5e a5e = new a5e((A_0.i != null) ? A_0.i.b : null, this.g * d0u.b, (int)Math.Max(1.0, (double)num / (double)this.g), "armorBleedingWound", null);
					a5e.Origin = A_0.i.d.ToString();
					a5e.AppliedAction = "applyBleed";
					A_1.StatusEffects.a(a5e, false, false, false);
					if (A_0.i != null && A_0.i.h.Contains("VileWeaponry") && A_1 != null)
					{
						List<a5e> list = A_1.StatusEffects.Get<a5e>();
						if (list.Count > 0)
						{
							e1l a_ = new e1l((int)Enumerable.Max<a5e>(list, new Func<a5e, double>(dpx.a.a.a)), c6t.a + (double)A_0.i.GetSpec<del>() * del.a, c6t.b + (double)A_0.i.GetSpec<b09>() * b09.a);
							A_1.StatusEffects.a(a_, false, false, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600975E RID: 38750 RVA: 0x003B0960 File Offset: 0x003AEB60
	public override string xq()
	{
		if (this.f() == null)
		{
			return null;
		}
		if (this.h)
		{
			return qv.a("Items\\ArmorItemModifier/UnarmedAttackBleedingEffect", new object[]
			{
				(int)(this.f * 100.0),
				this.e,
				this.g
			});
		}
		return qv.a("Items\\ArmorItemModifier/MeleeAttackBleedingEffect", new object[]
		{
			(int)(this.f * 100.0),
			this.e,
			this.g
		});
	}

	// Token: 0x0600975F RID: 38751 RVA: 0x003B0A18 File Offset: 0x003AEC18
	public override c3e xr()
	{
		dpx dpx = new dpx();
		this.ael(dpx);
		return dpx;
	}

	// Token: 0x06009760 RID: 38752 RVA: 0x003B0A34 File Offset: 0x003AEC34
	public override c3e xs(int A_0)
	{
		return new dpx
		{
			e = new a1q?(new a1q(DamageType.Mechanical, (int)((double)this.c + (double)A_0 * this.a), (int)((double)this.d + (double)A_0 * this.b))),
			f = this.f,
			g = this.g
		};
	}

	// Token: 0x06009761 RID: 38753 RVA: 0x003B0A94 File Offset: 0x003AEC94
	public void ao1(c3e A_0)
	{
		dpx dpx = A_0 as dpx;
		if (dpx != null)
		{
			this.e = new a1q?(new a1q(this.e.Value.DamageType, this.f().Value.LowerBoundary + dpx.e.Value.LowerBoundary, this.f().Value.UpperBoundary + dpx.e.Value.UpperBoundary));
			this.f = (this.f + dpx.f) / 2.0;
			this.g = (this.g + dpx.g) / 2;
		}
	}

	// Token: 0x06009762 RID: 38754 RVA: 0x003B0B58 File Offset: 0x003AED58
	public bool ao2(c3e A_0)
	{
		dpx dpx = A_0 as dpx;
		return dpx != null && dpx.h == this.h;
	}

	// Token: 0x06009763 RID: 38755 RVA: 0x003B0B84 File Offset: 0x003AED84
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		dpx dpx = (dpx)A_0;
		dpx.e = this.e;
		dpx.f = this.f;
		dpx.g = this.g;
		dpx.c = this.c;
		dpx.a = this.a;
		dpx.h = this.h;
		dpx.d = this.d;
		dpx.b = this.b;
	}

	// Token: 0x04003A20 RID: 14880
	private double a;

	// Token: 0x04003A21 RID: 14881
	private double b;

	// Token: 0x04003A22 RID: 14882
	private int c;

	// Token: 0x04003A23 RID: 14883
	private int d;

	// Token: 0x04003A24 RID: 14884
	private a1q? e;

	// Token: 0x04003A25 RID: 14885
	private double f;

	// Token: 0x04003A26 RID: 14886
	private int g;

	// Token: 0x04003A27 RID: 14887
	private bool h;

	// Token: 0x02001B54 RID: 6996
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600976C RID: 38764 RVA: 0x003B0C30 File Offset: 0x003AEE30
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x003B0C3C File Offset: 0x003AEE3C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x003B0C48 File Offset: 0x003AEE48
		internal double a(a5e A_0)
		{
			return A_0.TimeLeft;
		}

		// Token: 0x04003A28 RID: 14888
		public static readonly dpx.a a = new dpx.a();

		// Token: 0x04003A29 RID: 14889
		public static Func<csk, bool> b;

		// Token: 0x04003A2A RID: 14890
		public static Func<csk, int> c;

		// Token: 0x04003A2B RID: 14891
		public static Func<a5e, double> d;
	}
}
