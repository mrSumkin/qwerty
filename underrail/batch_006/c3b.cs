using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x02000315 RID: 789
[apc("siphoner")]
public class c3b : or
{
	// Token: 0x060016A1 RID: 5793 RVA: 0x0006FD44 File Offset: 0x0006DF44
	public c3b()
	{
		this.b = new TryInvokeSpecialAbilityNode<aso>();
		this.b.a = this.p.a;
		this.b.b = this.p.a;
		this.c = new TryInvokeSpecialAbilityNode<ctx>();
		this.c.a = this.p.a;
		this.c.b = this.p.a;
		this.a = new fh(new arr[]
		{
			new arr(this.c, new Func<e1k, bool>(this.b)),
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.p.a, null)
		});
		this.p.a = this.a;
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x0006FE30 File Offset: 0x0006E030
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (!this.c.b(A_0))
		{
			return false;
		}
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && !amc.aa().Passive && !amc.aa().b(d8o.e | d8o.s))
		{
			float num = A_0.g().aa().Defense.q().zo() / Math.Max(1f, A_0.g().aa().Defense.q().zm());
			if (num <= 0.5f)
			{
				return true;
			}
			if (num <= 0.75f)
			{
				bfm bfm = Enumerable.FirstOrDefault<bfm>(amc.aa().StatusEffects.Get<bfm>());
				if (bfm != null && bfm.Stacks >= 7)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0006FF18 File Offset: 0x0006E118
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (!this.b.b(A_0))
		{
			return false;
		}
		amc amc = new bzv(A_0.c().y6()).g();
		return amc != null && !amc.aa().SpecialStates.a && cuo.a.NextDouble() < 0.5;
	}

	// Token: 0x04000D42 RID: 3394
	public new fh a;

	// Token: 0x04000D43 RID: 3395
	public new TryInvokeSpecialAbilityNode<aso> b;

	// Token: 0x04000D44 RID: 3396
	public new TryInvokeSpecialAbilityNode<ctx> c;
}
