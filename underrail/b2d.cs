using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F2 RID: 1778
[eiz("A29")]
[Serializable]
public sealed class b2d : d1k, ISerializable
{
	// Token: 0x06002DE0 RID: 11744 RVA: 0x00104CCC File Offset: 0x00102ECC
	private b2d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("A29:B", typeof(BarrelType?)) as BarrelType?);
		this.a = A_0.GetString("A29:F");
	}

	// Token: 0x06002DE1 RID: 11745 RVA: 0x00104D0C File Offset: 0x00102F0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A29:B", this.b);
		info.AddValue("A29:F", this.a);
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x00104D40 File Offset: 0x00102F40
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x00104D48 File Offset: 0x00102F48
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x00104D54 File Offset: 0x00102F54
	public BarrelType? a()
	{
		return this.b;
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x00104D5C File Offset: 0x00102F5C
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x00104D68 File Offset: 0x00102F68
	public b2d()
	{
	}

	// Token: 0x06002DE7 RID: 11751 RVA: 0x00104D74 File Offset: 0x00102F74
	protected override cd1 rf(int A_0)
	{
		dp dp = d79.Get<dp>();
		if (dp != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.a(a_, this.b);
			if (fv != null)
			{
				fv fv2 = d1k.a(fv, this.b);
				if (fv2 != null)
				{
					fv.QualityLevel = a_;
					fv fv3 = this.a(A_0);
					fv fv4 = this.a(A_0);
					if (fv3 != null && fv4 != null && fv3.TypedDefinition.i() == fv4.TypedDefinition.i())
					{
						fv4 = null;
					}
					return dp.a(null, new Dictionary<string, coh>
					{
						{
							dp.a,
							fv
						},
						{
							dp.b,
							fv2
						},
						{
							dp.c,
							fv3
						},
						{
							dp.d,
							fv4
						}
					}).a() as cd1;
				}
			}
		}
		return null;
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x00104E54 File Offset: 0x00103054
	public override aw4 a1()
	{
		b2d b2d = new b2d();
		this.rg(b2d);
		return b2d;
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x00104E70 File Offset: 0x00103070
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		b2d b2d = A_0 as b2d;
		b2d.b = this.b;
		b2d.a = this.a;
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x00104E9C File Offset: 0x0010309C
	private fv a(int A_0, BarrelType? A_1)
	{
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			return y8.a("Weapons\\" + this.a, null);
		}
		ItemPoolForQuality<fv> itemPoolForQuality = new ItemPoolForQuality<fv>(A_0);
		int[][] array = new int[][]
		{
			new int[]
			{
				0,
				int.MaxValue
			},
			new int[]
			{
				45,
				int.MaxValue
			},
			new int[]
			{
				65,
				int.MaxValue
			}
		};
		for (int i = 1; i <= array.Length; i++)
		{
			fv fv = y8.a("Weapons\\AssaultRifleFrame" + i.ToString(), null);
			if (fv != null)
			{
				if (A_1 != null)
				{
					List<BarrelType> classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
					if (classPropertyValue != null && !classPropertyValue.Contains(A_1.Value))
					{
						goto IL_106;
					}
				}
				itemPoolForQuality.a(fv, array[i - 1][0], array[i - 1][1], 1);
			}
			IL_106:;
		}
		return itemPoolForQuality.a();
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x00104FC4 File Offset: 0x001031C4
	private fv a(int A_0)
	{
		if (zp.a.NextDouble() < 0.1)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("Scope", 25, int.MaxValue, 1);
			itemPoolForQuality.a("ExtendedRifleMagazine", 40, int.MaxValue, 1);
			itemPoolForQuality.a("Bipod", 30, int.MaxValue, 1);
			itemPoolForQuality.a("ReflexSight", 30, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x040019D0 RID: 6608
	private new string a;

	// Token: 0x040019D1 RID: 6609
	private BarrelType? b;
}
