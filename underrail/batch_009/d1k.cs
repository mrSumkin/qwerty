using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F1 RID: 1777
[eiz("WCGB")]
[Serializable]
public abstract class d1k : y8, ISerializable
{
	// Token: 0x06002DD7 RID: 11735 RVA: 0x00104850 File Offset: 0x00102A50
	protected d1k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 136)
		{
			this.a = A_0.GetInt32("WCGB:A");
		}
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x0010487C File Offset: 0x00102A7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WCGB:A", this.a);
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x00104898 File Offset: 0x00102A98
	public int e()
	{
		return this.a;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x001048A0 File Offset: 0x00102AA0
	public void d(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x001048AC File Offset: 0x00102AAC
	protected d1k()
	{
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x001048B4 File Offset: 0x00102AB4
	protected sealed override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		int a_ = base.i();
		cd1 cd = this.rf(a_);
		if (cd != null)
		{
			list.Add(cd);
			if (this.a > 0 && cd.TypedDefinition != null)
			{
				if (euf.j(cd))
				{
					AmmoType ammoType = AmmoType.Rocket_84_He;
					list.Insert(0, new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\" + Enum.GetName(typeof(AmmoType), ammoType)))
					{
						Stacks = this.a
					});
				}
				else if (euf.i(cd))
				{
					AmmoType ammoType2 = cd.TypedDefinition.ak() + 1 + cuo.a.Next(2);
					list.Insert(0, new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\" + Enum.GetName(typeof(AmmoType), ammoType2)))
					{
						Stacks = this.a
					});
				}
				else if (eub.c(cd.TypedDefinition.ak()))
				{
					AmmoType ammoType3 = AmmoType.ShotgunShell_6 + cuo.a.Next(3);
					list.Insert(0, new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\" + Enum.GetName(typeof(AmmoType), ammoType3)))
					{
						Stacks = this.a
					});
				}
				else if (eub.f(cd.TypedDefinition.ak()) || eub.d(cd.TypedDefinition.ak()))
				{
					AmmoType ammoType4 = cd.TypedDefinition.ak() / AmmoType.Caliber_5 * AmmoType.Caliber_5 + 1;
					list.Add(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\" + Enum.GetName(typeof(AmmoType), ammoType4)))
					{
						Stacks = this.a
					});
				}
				else if (cd.TypedDefinition.ak() == AmmoType.Bolts)
				{
					list.Add(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Bolt"))
					{
						Stacks = this.a
					});
				}
				else if (cd.TypedDefinition.ak() == AmmoType.Energy)
				{
					string str;
					int a_2;
					if (cd.TypedDefinition.a8() > 10)
					{
						str = "FusionCell";
						a_2 = Math.Max(1, this.a / 3);
					}
					else
					{
						str = "ScLiCell";
						a_2 = this.a;
					}
					list.Add(new d48(ez2.CreateDefinitonProvider<sz>("Expendables\\EnergySources\\" + str))
					{
						Stacks = a_2
					});
				}
			}
		}
		return list;
	}

	// Token: 0x06002DDD RID: 11741
	protected abstract cd1 rf(int A_0);

	// Token: 0x06002DDE RID: 11742 RVA: 0x00104B70 File Offset: 0x00102D70
	protected static fv a(fv A_0, BarrelType? A_1 = null)
	{
		BarrelType barrelType;
		if (A_1 != null)
		{
			barrelType = A_1.Value;
		}
		else
		{
			List<BarrelType> list = new List<BarrelType>();
			List<BarrelType> classPropertyValue = A_0.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
			if (classPropertyValue == null || classPropertyValue.Count == 0)
			{
				return null;
			}
			foreach (object obj in Enum.GetValues(typeof(BarrelType)))
			{
				BarrelType item = (BarrelType)obj;
				if (classPropertyValue.Contains(item))
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			if (list.Count == 1)
			{
				barrelType = Enumerable.First<BarrelType>(list);
			}
			else
			{
				barrelType = list[zp.a.Next(list.Count)];
			}
		}
		return y8.a("Weapons\\Barrel" + barrelType.ToString().Split(new char[]
		{
			'_'
		})[1], null);
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x00104CB0 File Offset: 0x00102EB0
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		((d1k)A_0).a = this.a;
	}

	// Token: 0x040019CF RID: 6607
	private new int a;
}
