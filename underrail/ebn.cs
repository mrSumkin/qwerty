using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x02000316 RID: 790
[apc("mutatedHuman")]
public class ebn : or
{
	// Token: 0x060016A4 RID: 5796 RVA: 0x0006FF84 File Offset: 0x0006E184
	public ebn()
	{
		this.a = new fh(new arr[0]);
		this.b = new TryInvokeSpecialAbilityNode<cv5>();
		this.b.a = e8t.b;
		this.b.a = this.a;
		this.b.b = this.p.a;
		this.c = new TryInvokeSpecialAbilityNode<bdk>();
		this.c.a = this.p.a;
		this.c.b = this.p.a;
		this.a.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.b)),
			new arr(this.c, new Func<e1k, bool>(this.a)),
			new arr(this.p.a, null)
		});
		this.p.a = this.a;
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00070088 File Offset: 0x0006E288
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (!this.b.b(A_0))
		{
			return false;
		}
		bzv bzv = new bzv(A_0.c().y6());
		amc amc = bzv.g();
		if (amc != null)
		{
			blk blk = bzv.c(amc.a8().qe());
			double num = aw1.b(A_0.g().a8(), amc.a8());
			if (blk != null && blk.b() && num > 3.0 && num <= (double)(cv5.f - 1) && !amc.aa().StatusEffects.a(ef2.a))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x0007013C File Offset: 0x0006E33C
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (!this.c.b(A_0))
		{
			return false;
		}
		bzv bzv = new bzv(A_0.c().y6());
		amc amc = bzv.g();
		if (amc != null)
		{
			blk blk = bzv.c(amc.a8().qe());
			double num = aw1.b(A_0.g().a8(), amc.a8());
			cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
			if (blk != null && blk.b() && (num > 3.0 || (num > 1.4 && A_0.g().aa().SpecialStates.b && num <= (double)bdk.f) || (classPropertyValue != null && classPropertyValue.b(0) == -1f && classPropertyValue.b(bdk.f) != -1f)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000D45 RID: 3397
	public new fh a;

	// Token: 0x04000D46 RID: 3398
	public new TryInvokeSpecialAbilityNode<cv5> b;

	// Token: 0x04000D47 RID: 3399
	public new TryInvokeSpecialAbilityNode<bdk> c;
}
