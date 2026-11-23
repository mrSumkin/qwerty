using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002F8 RID: 760
[apc("sower")]
public sealed class gh : cqw
{
	// Token: 0x06001606 RID: 5638 RVA: 0x00069778 File Offset: 0x00067978
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0006977C File Offset: 0x0006797C
	public gh()
	{
		gh.a a = new gh.a();
		a.a = new TryInvokeSpecialAbilityNode<azf>();
		a.a.a = this.j;
		a.a.b = this.j;
		fh fh = new fh(new arr[0]);
		fh.a(new arr[]
		{
			new arr(a.a, new Func<e1k, bool>(a.a)),
			new arr(this.i.b, null)
		});
		this.h.b = fh;
		this.i.b = fh;
	}

	// Token: 0x020002F9 RID: 761
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x00069828 File Offset: 0x00067A28
		internal bool a(e1k A_0)
		{
			return this.a.b(A_0) && new bzv(A_0.c().y6()).g() != null;
		}

		// Token: 0x04000C9C RID: 3228
		public TryInvokeSpecialAbilityNode<azf> a;
	}
}
