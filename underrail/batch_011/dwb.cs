using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B56 RID: 6998
[eiz("M21")]
[Serializable]
public sealed class dwb : ani
{
	// Token: 0x06009787 RID: 38791 RVA: 0x003B1144 File Offset: 0x003AF344
	private dwb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M21:B");
	}

	// Token: 0x06009788 RID: 38792 RVA: 0x003B1160 File Offset: 0x003AF360
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("M21:B", this.a);
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06009789 RID: 38793 RVA: 0x003B117C File Offset: 0x003AF37C
	// (set) Token: 0x0600978A RID: 38794 RVA: 0x003B1184 File Offset: 0x003AF384
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

	// Token: 0x0600978B RID: 38795 RVA: 0x003B1190 File Offset: 0x003AF390
	public dwb()
	{
	}

	// Token: 0x0600978C RID: 38796 RVA: 0x003B1198 File Offset: 0x003AF398
	public override void ah7(Dictionary<DamageType, du2> A_0, cwt A_1, cgk A_2, efk A_3)
	{
		if (eub.f(A_1.x))
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
					du2 a_ = new du2(DamageType.Mechanical, (int)((double)du2.a() * this.a * num), 0.0);
					du2 value = A_0[DamageType.Mechanical];
					value.a(a_);
					A_0[DamageType.Mechanical] = value;
					break;
				}
			}
		}
	}

	// Token: 0x0600978D RID: 38797 RVA: 0x003B1290 File Offset: 0x003AF490
	public override string xq()
	{
		if (dk2.f())
		{
			return qv.a("Items\\ArmorItemModifier/ThresholdBonusVsBulletsAndShellsBonus", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("Items\\ArmorItemModifier/ThresholdBonusVsBulletsBonus", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x0600978E RID: 38798 RVA: 0x003B12FC File Offset: 0x003AF4FC
	public override c3e xr()
	{
		dwb dwb = new dwb();
		this.ael(dwb);
		return dwb;
	}

	// Token: 0x0600978F RID: 38799 RVA: 0x003B1318 File Offset: 0x003AF518
	public override c3e xs(int A_0)
	{
		return new dwb
		{
			a = this.a
		};
	}

	// Token: 0x06009790 RID: 38800 RVA: 0x003B1330 File Offset: 0x003AF530
	public void b(c3e A_0)
	{
		dwb dwb = A_0 as dwb;
		if (dwb != null)
		{
			this.a += dwb.a;
		}
	}

	// Token: 0x06009791 RID: 38801 RVA: 0x003B1360 File Offset: 0x003AF560
	public bool a(c3e A_0)
	{
		return A_0 is dwb;
	}

	// Token: 0x06009792 RID: 38802 RVA: 0x003B136C File Offset: 0x003AF56C
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		((dwb)A_0).a = this.a;
	}

	// Token: 0x04003A33 RID: 14899
	private double a;
}
