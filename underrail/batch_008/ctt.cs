using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B4D RID: 6989
[eiz("K20")]
[Serializable]
public sealed class ctt : ani
{
	// Token: 0x0600972F RID: 38703 RVA: 0x003B0168 File Offset: 0x003AE368
	private ctt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("K20:B");
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x003B0184 File Offset: 0x003AE384
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("K20:B", this.a);
	}

	// Token: 0x06009731 RID: 38705 RVA: 0x003B01A0 File Offset: 0x003AE3A0
	public double a()
	{
		return this.a;
	}

	// Token: 0x06009732 RID: 38706 RVA: 0x003B01A8 File Offset: 0x003AE3A8
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009733 RID: 38707 RVA: 0x003B01B4 File Offset: 0x003AE3B4
	public ctt()
	{
	}

	// Token: 0x06009734 RID: 38708 RVA: 0x003B01BC File Offset: 0x003AE3BC
	public override void ah7(Dictionary<DamageType, du2> A_0, cwt A_1, cgk A_2, efk A_3)
	{
		if (A_2 != null && (A_1.ae.GetValueOrDefault() == WeaponSubtype.Knife || A_1.ae.GetValueOrDefault() == WeaponSubtype.SerratedKnife || A_1.ae.GetValueOrDefault() == WeaponSubtype.Dagger || A_1.x == AmmoType.Knife || A_1.x == AmmoType.Dagger))
		{
			du2 du = A_0[DamageType.Mechanical];
			foreach (du2 du2 in A_2.fu().i())
			{
				if (du2.b() == DamageType.Mechanical)
				{
					double num = 1.0;
					ht ht = Enumerable.FirstOrDefault<ht>(A_3.StatusEffects.Get<ht>());
					if (ht != null)
					{
						num *= 1.0 - ht.a();
					}
					du2 a_ = new du2(DamageType.Mechanical, (int)((double)du2.a() * this.a * num), du2.c() * this.a * num);
					du2 value = A_0[DamageType.Mechanical];
					value.a(a_);
					euf.a(A_3, ref value);
					A_0[DamageType.Mechanical] = value;
					break;
				}
			}
		}
	}

	// Token: 0x06009735 RID: 38709 RVA: 0x003B0318 File Offset: 0x003AE518
	public override string xq()
	{
		return qv.a("Items\\ArmorItemModifier/KnifeResistanceBonus", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x06009736 RID: 38710 RVA: 0x003B0344 File Offset: 0x003AE544
	public override c3e xr()
	{
		ctt ctt = new ctt();
		this.ael(ctt);
		return ctt;
	}

	// Token: 0x06009737 RID: 38711 RVA: 0x003B0360 File Offset: 0x003AE560
	public override c3e xs(int A_0)
	{
		return new ctt
		{
			a = this.a
		};
	}

	// Token: 0x06009738 RID: 38712 RVA: 0x003B0374 File Offset: 0x003AE574
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		((ctt)A_0).a = this.a;
	}

	// Token: 0x04003A1D RID: 14877
	private double a;
}
