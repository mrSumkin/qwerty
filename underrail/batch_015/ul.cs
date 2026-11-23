using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002EC RID: 748
[apc("electroPrimeTentacle")]
public sealed class ul : ft
{
	// Token: 0x060015D5 RID: 5589 RVA: 0x00067814 File Offset: 0x00065A14
	protected override int l7()
	{
		return 8;
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x0006781C File Offset: 0x00065A1C
	public ul()
	{
		this.b = new TryInvokePsiAbilityNode<dl3>();
		this.a = new fh(new arr[0]);
		this.p.a = this.a;
		this.a.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.b.a = this.c;
		this.b.b = this.c;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x000678B8 File Offset: 0x00065AB8
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (A_0.c().ai())
				{
					bool flag = false;
					foreach (ak1 a_ in amc.a8().l)
					{
						if (A_0.c().a(a_))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						return false;
					}
				}
				double num = aw1.b(A_0.c().a8(), amc.a8());
				eu7 eu = this.b.b(A_0);
				if (eu != null && (double)eu.c(amc.a8()) >= num)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04000C74 RID: 3188
	private new fh a;

	// Token: 0x04000C75 RID: 3189
	private new TryInvokePsiAbilityNode<dl3> b;
}
