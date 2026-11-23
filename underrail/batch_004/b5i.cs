using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002F1 RID: 753
[apc("shroomlingChomper")]
public sealed class b5i : cqw
{
	// Token: 0x060015EA RID: 5610 RVA: 0x00068914 File Offset: 0x00066B14
	public override bool ef()
	{
		return false;
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x00068918 File Offset: 0x00066B18
	public b5i()
	{
		this.a = new fh(new arr[0]);
		this.b = new TryInvokeSpecialAttackNode<ceg>();
		this.a.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.p.a, null)
		});
		this.b.a = this.p.a;
		this.b.b = this.p.a;
		this.p.a = this.a;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000689C4 File Offset: 0x00066BC4
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null)
			{
				int count = amc.aa().StatusEffects.Get<a5e>().Count;
				float num = euf.f(A_0.g().aa());
				if (count > 0 && (double)num < 0.8)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04000C83 RID: 3203
	private new fh a;

	// Token: 0x04000C84 RID: 3204
	private new TryInvokeSpecialAttackNode<ceg> b;
}
