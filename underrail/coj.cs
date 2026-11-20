using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000704 RID: 1796
[eiz("PG")]
[Serializable]
public sealed class coj : d1k, ISerializable
{
	// Token: 0x06002EA0 RID: 11936 RVA: 0x0010825C File Offset: 0x0010645C
	private coj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 67)
		{
			this.b = (A_0.GetValue("PG:B", typeof(BarrelType?)) as BarrelType?);
			this.a = A_0.GetString("PG:F");
		}
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x001082B4 File Offset: 0x001064B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PG:B", this.b);
		info.AddValue("PG:F", this.a);
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x001082E8 File Offset: 0x001064E8
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x001082F0 File Offset: 0x001064F0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002EA4 RID: 11940 RVA: 0x001082FC File Offset: 0x001064FC
	public BarrelType? a()
	{
		return this.b;
	}

	// Token: 0x06002EA5 RID: 11941 RVA: 0x00108304 File Offset: 0x00106504
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002EA6 RID: 11942 RVA: 0x00108310 File Offset: 0x00106510
	public coj()
	{
	}

	// Token: 0x06002EA7 RID: 11943 RVA: 0x0010831C File Offset: 0x0010651C
	public override aw4 a1()
	{
		coj coj = new coj();
		this.rg(coj);
		return coj;
	}

	// Token: 0x06002EA8 RID: 11944 RVA: 0x00108338 File Offset: 0x00106538
	protected override cd1 rf(int A_0)
	{
		ezh ezh = d79.Get<ezh>();
		if (ezh != null)
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
					return ezh.a(null, new Dictionary<string, coh>
					{
						{
							ezh.a,
							fv
						},
						{
							ezh.b,
							fv2
						},
						{
							ezh.c,
							fv3
						},
						{
							ezh.d,
							fv4
						}
					}).a() as cd1;
				}
			}
		}
		return null;
	}

	// Token: 0x06002EA9 RID: 11945 RVA: 0x0010841C File Offset: 0x0010661C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		coj coj = A_0 as coj;
		coj.b = this.b;
		coj.a = this.a;
	}

	// Token: 0x06002EAA RID: 11946 RVA: 0x00108444 File Offset: 0x00106644
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
				0,
				int.MaxValue
			},
			new int[]
			{
				50,
				int.MaxValue
			}
		};
		for (int i = 1; i <= array.Length; i++)
		{
			fv fv = y8.a("Weapons\\PistolFrame" + i.ToString(), null);
			if (fv != null)
			{
				if (A_1 != null)
				{
					List<BarrelType> classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
					if (classPropertyValue != null && !classPropertyValue.Contains(A_1.Value))
					{
						goto IL_101;
					}
				}
				itemPoolForQuality.a(fv, array[i - 1][0], array[i - 1][1], 1);
			}
			IL_101:;
		}
		return itemPoolForQuality.a();
	}

	// Token: 0x06002EAB RID: 11947 RVA: 0x00108568 File Offset: 0x00106768
	private fv a(fv A_0, int A_1)
	{
		if (A_0.Definition.a5() == "FirearmBarrel5" && zp.a.NextDouble() < 0.05)
		{
			return y8.a("Weapons\\Silencer", null);
		}
		if (A_1 >= 4 && zp.a.NextDouble() < 0.1)
		{
			return y8.a("Weapons\\LaserSight", null);
		}
		if (A_1 >= 6 && zp.a.NextDouble() < 0.1)
		{
			return y8.a("Weapons\\ExtendedPistolMagazine", null);
		}
		return null;
	}

	// Token: 0x040019F1 RID: 6641
	private new string a;

	// Token: 0x040019F2 RID: 6642
	private BarrelType? b;
}
