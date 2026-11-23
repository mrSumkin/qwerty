using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000700 RID: 1792
[eiz("SMGG")]
[Serializable]
public sealed class cvs : d1k, ISerializable
{
	// Token: 0x06002E7E RID: 11902 RVA: 0x00107810 File Offset: 0x00105A10
	private cvs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("SMGG:B", typeof(BarrelType?)) as BarrelType?);
		this.a = A_0.GetString("SMGG:F");
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x00107850 File Offset: 0x00105A50
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SMGG:B", this.b);
		info.AddValue("SMGG:F", this.a);
	}

	// Token: 0x06002E80 RID: 11904 RVA: 0x00107884 File Offset: 0x00105A84
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x0010788C File Offset: 0x00105A8C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x00107898 File Offset: 0x00105A98
	public BarrelType? a()
	{
		return this.b;
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x001078A0 File Offset: 0x00105AA0
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E84 RID: 11908 RVA: 0x001078AC File Offset: 0x00105AAC
	public cvs()
	{
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x001078B8 File Offset: 0x00105AB8
	public override aw4 a1()
	{
		cvs cvs = new cvs();
		this.rg(cvs);
		return cvs;
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x001078D4 File Offset: 0x00105AD4
	protected override cd1 rf(int A_0)
	{
		d81 d = d79.Get<d81>();
		if (d != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.a(a_, this.b);
			if (fv != null)
			{
				fv fv2 = d1k.a(fv, this.b);
				if (fv2 != null)
				{
					fv.QualityLevel = a_;
					fv fv3 = this.a(fv2, A_0);
					fv fv4 = this.a(fv2, A_0);
					if (fv3 != null && fv4 != null && fv3.TypedDefinition.i() == fv4.TypedDefinition.i())
					{
						fv4 = null;
					}
					return d.a(null, new Dictionary<string, coh>
					{
						{
							d81.a,
							fv
						},
						{
							d81.b,
							fv2
						},
						{
							d81.c,
							fv3
						},
						{
							d81.d,
							fv4
						}
					}).a() as cd1;
				}
			}
		}
		return null;
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x001079B8 File Offset: 0x00105BB8
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		cvs cvs = A_0 as cvs;
		cvs.b = this.b;
		cvs.a = this.a;
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x001079E0 File Offset: 0x00105BE0
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
				40,
				int.MaxValue
			},
			new int[]
			{
				55,
				int.MaxValue
			}
		};
		for (int i = 1; i <= array.Length; i++)
		{
			fv fv = y8.a("Weapons\\SmgFrame" + i.ToString(), null);
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

	// Token: 0x06002E89 RID: 11913 RVA: 0x00107B08 File Offset: 0x00105D08
	private fv a(fv A_0, int A_1)
	{
		if (A_0.Definition.a5() == "FirearmBarrel5" && zp.a.NextDouble() < 0.05)
		{
			return y8.a("Weapons\\Silencer", null);
		}
		if (zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_1 * 5);
			itemPoolForQuality.a("LaserSight", 30, int.MaxValue, 1);
			itemPoolForQuality.a("ExtendedPistolMagazine", 35, int.MaxValue, 1);
			itemPoolForQuality.a("VerticalForegrip", 35, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x040019E7 RID: 6631
	private new string a;

	// Token: 0x040019E8 RID: 6632
	private BarrelType? b;
}
