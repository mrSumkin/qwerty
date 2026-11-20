using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B57 RID: 6999
[eiz("M20")]
[Serializable]
public sealed class eey : ani
{
	// Token: 0x06009793 RID: 38803 RVA: 0x003B1388 File Offset: 0x003AF588
	private eey(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M20:B");
	}

	// Token: 0x06009794 RID: 38804 RVA: 0x003B13A4 File Offset: 0x003AF5A4
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("M20:B", this.a);
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06009795 RID: 38805 RVA: 0x003B13C0 File Offset: 0x003AF5C0
	// (set) Token: 0x06009796 RID: 38806 RVA: 0x003B13C8 File Offset: 0x003AF5C8
	public double Bonus
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06009797 RID: 38807 RVA: 0x003B13D4 File Offset: 0x003AF5D4
	public eey()
	{
	}

	// Token: 0x06009798 RID: 38808 RVA: 0x003B13E0 File Offset: 0x003AF5E0
	public override void ah7(Dictionary<DamageType, du2> A_0, cwt A_1, cgk A_2, efk A_3)
	{
		if (A_2 != null && (A_1.h == ImpactSpeed.VeryLow || A_1.z))
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

	// Token: 0x06009799 RID: 38809 RVA: 0x003B14F4 File Offset: 0x003AF6F4
	public override string xq()
	{
		return qv.a("Items\\ArmorItemModifier/MeleeResistanceBonus", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x0600979A RID: 38810 RVA: 0x003B1520 File Offset: 0x003AF720
	public override c3e xr()
	{
		eey eey = new eey();
		this.ael(eey);
		return eey;
	}

	// Token: 0x0600979B RID: 38811 RVA: 0x003B153C File Offset: 0x003AF73C
	public override c3e xs(int A_0)
	{
		return new eey
		{
			a = this.a
		};
	}

	// Token: 0x0600979C RID: 38812 RVA: 0x003B1550 File Offset: 0x003AF750
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		((eey)A_0).a = this.a;
	}

	// Token: 0x04003A34 RID: 14900
	private double a;
}
