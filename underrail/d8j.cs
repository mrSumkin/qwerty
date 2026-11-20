using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B49 RID: 6985
[eiz("K21")]
[Serializable]
public sealed class d8j : ani
{
	// Token: 0x06009712 RID: 38674 RVA: 0x003AFDE8 File Offset: 0x003ADFE8
	private d8j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("K21:B");
	}

	// Token: 0x06009713 RID: 38675 RVA: 0x003AFE04 File Offset: 0x003AE004
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("K21:B", this.a);
	}

	// Token: 0x06009714 RID: 38676 RVA: 0x003AFE20 File Offset: 0x003AE020
	public double a()
	{
		return this.a;
	}

	// Token: 0x06009715 RID: 38677 RVA: 0x003AFE28 File Offset: 0x003AE028
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009716 RID: 38678 RVA: 0x003AFE34 File Offset: 0x003AE034
	public d8j()
	{
	}

	// Token: 0x06009717 RID: 38679 RVA: 0x003AFE40 File Offset: 0x003AE040
	public override void ah7(Dictionary<DamageType, du2> A_0, cwt A_1, cgk A_2, efk A_3)
	{
		if (A_2 != null && ((A_1.ae != null && euf.a(A_1.ae.Value, WeaponAggregateSubtype.BladedMelee)) || euf.c(A_1.x)))
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

	// Token: 0x06009718 RID: 38680 RVA: 0x003AFF74 File Offset: 0x003AE174
	public override string xq()
	{
		return qv.a("Items\\ArmorItemModifier/MeleeEdgedResistanceBonus", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x06009719 RID: 38681 RVA: 0x003AFFA0 File Offset: 0x003AE1A0
	public override c3e xr()
	{
		d8j d8j = new d8j();
		this.ael(d8j);
		return d8j;
	}

	// Token: 0x0600971A RID: 38682 RVA: 0x003AFFBC File Offset: 0x003AE1BC
	public override c3e xs(int A_0)
	{
		return new d8j
		{
			a = this.a
		};
	}

	// Token: 0x0600971B RID: 38683 RVA: 0x003AFFD0 File Offset: 0x003AE1D0
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		((d8j)A_0).a = this.a;
	}

	// Token: 0x04003A1B RID: 14875
	private double a;
}
