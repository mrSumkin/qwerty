using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002EE RID: 750
[apc("cryoPrimeTentacle")]
public sealed class bce : ft
{
	// Token: 0x060015DE RID: 5598 RVA: 0x00068144 File Offset: 0x00066344
	public bce()
	{
		this.b = new TryInvokePsiAbilityNode<h7>();
		this.c = new TryInvokePsiAbilityNode<cmp>();
		this.a = new fh(new arr[0]);
		this.p.a = this.a;
		this.a.a(new arr[]
		{
			new arr(this.c, new Func<e1k, bool>(this.b)),
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.b.a = this.c;
		this.b.b = this.c;
		this.c.a = this.c;
		this.c.b = this.c;
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x00068228 File Offset: 0x00066428
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.c.a(A_0) && cuo.a.NextDouble() < 0.3)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.Freeze) && amc.aa().IsInControl)
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
				if (aw1.b(A_0.g().a8(), amc.a8()) <= 7.5)
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						d4n d4n = service.ahu(A_0.g().aa());
						if (d4n == null || d4n.c > 30.0)
						{
							return false;
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00068384 File Offset: 0x00066584
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

	// Token: 0x04000C7A RID: 3194
	private new fh a;

	// Token: 0x04000C7B RID: 3195
	private new TryInvokePsiAbilityNode<h7> b;

	// Token: 0x04000C7C RID: 3196
	private new TryInvokePsiAbilityNode<cmp> c;
}
