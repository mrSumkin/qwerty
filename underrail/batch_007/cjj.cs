using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000701 RID: 1793
[eiz("SG")]
[Serializable]
public sealed class cjj : d1k, ISerializable
{
	// Token: 0x06002E8A RID: 11914 RVA: 0x00107BE0 File Offset: 0x00105DE0
	private cjj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("SG:B", typeof(BarrelType?)) as BarrelType?);
		this.a = A_0.GetString("SG:F");
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x00107C20 File Offset: 0x00105E20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SG:B", this.b);
		info.AddValue("SG:F", this.a);
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x00107C54 File Offset: 0x00105E54
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x00107C5C File Offset: 0x00105E5C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E8E RID: 11918 RVA: 0x00107C68 File Offset: 0x00105E68
	public BarrelType? b()
	{
		return this.b;
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x00107C70 File Offset: 0x00105E70
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x00107C7C File Offset: 0x00105E7C
	public cjj()
	{
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x00107C88 File Offset: 0x00105E88
	protected override cd1 rf(int A_0)
	{
		coo coo = d79.Get<coo>();
		if (coo != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.a(a_, this.b);
			if (fv != null)
			{
				fv fv2 = d1k.a(fv, this.b);
				fv value = this.a();
				if (fv2 != null)
				{
					fv.QualityLevel = a_;
					fv fv3 = this.a(fv.TypedDefinition, A_0);
					fv fv4 = this.a(fv.TypedDefinition, A_0);
					if (fv3 != null && fv4 != null && fv3.TypedDefinition.i() == fv4.TypedDefinition.i())
					{
						fv4 = null;
					}
					return coo.a(null, new Dictionary<string, coh>
					{
						{
							coo.a,
							fv
						},
						{
							coo.b,
							fv2
						},
						{
							coo.c,
							value
						},
						{
							coo.d,
							fv3
						},
						{
							coo.e,
							fv4
						}
					}).a() as cd1;
				}
			}
		}
		return null;
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x00107D8C File Offset: 0x00105F8C
	public override aw4 a1()
	{
		cjj cjj = new cjj();
		this.rg(cjj);
		return cjj;
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x00107DA8 File Offset: 0x00105FA8
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		cjj cjj = A_0 as cjj;
		cjj.b = this.b;
		cjj.a = this.a;
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x00107DD4 File Offset: 0x00105FD4
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
			fv fv = y8.a("Weapons\\SniperFrame" + i.ToString(), null);
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

	// Token: 0x06002E95 RID: 11925 RVA: 0x00107EFC File Offset: 0x001060FC
	private fv a(a1k A_0, int A_1)
	{
		if (!A_0.a7().GetPrimitivePropertyValue<bool>("CannotAttachBipod", new bool?(false)).Value && A_1 >= 4 && zp.a.NextDouble() < 0.1)
		{
			return y8.a("Weapons\\Bipod", null);
		}
		if (A_1 >= 6 && zp.a.NextDouble() < 0.1)
		{
			return y8.a("Weapons\\ExtendedRifleMagazine", null);
		}
		if (A_1 >= 8 && zp.a.NextDouble() < 0.1)
		{
			return y8.a("Weapons\\RifleBarrelRetractor", null);
		}
		return null;
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x00107FC8 File Offset: 0x001061C8
	private fv a()
	{
		List<fv> list = new List<fv>();
		list.Add(y8.a("Weapons\\Scope", null));
		return list[zp.a.Next(list.Count)];
	}

	// Token: 0x040019E9 RID: 6633
	private new string a;

	// Token: 0x040019EA RID: 6634
	private BarrelType? b;
}
