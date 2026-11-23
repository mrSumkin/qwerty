using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002EF RID: 751
[apc("scannerPrimeTentacle")]
public sealed class avb : ft
{
	// Token: 0x060015E1 RID: 5601 RVA: 0x00068480 File Offset: 0x00066680
	protected override int l7()
	{
		return 6;
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00068484 File Offset: 0x00066684
	public override bool ef()
	{
		return false;
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0006848C File Offset: 0x0006668C
	public avb()
	{
		this.b = new TryInvokePsiAbilityNode<dzs>();
		this.c = new TryInvokePsiAbilityNode<eq6>();
		this.d = new TryInvokePsiAbilityNode<px>();
		this.a = new fh(new arr[0]);
		this.p.a = this.a;
		this.a.a(new arr[]
		{
			new arr(this.c, new Func<e1k, bool>(this.c)),
			new arr(this.d, new Func<e1k, bool>(this.b)),
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.b.a = this.c;
		this.b.b = this.c;
		this.c.a = this.c;
		this.c.b = this.c;
		this.d.a = this.c;
		this.d.b = this.c;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000685B8 File Offset: 0x000667B8
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.c.a(A_0) && cuo.a.NextDouble() < 0.5)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().b(d8o.b) && !amc.aa().d(CharacterImmunities.MindAffecting) && amc.aa().Vehicle == null)
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
				eu7 eu = this.c.b(A_0);
				if (eu != null && (double)eu.c(amc.a8()) >= num)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00068700 File Offset: 0x00066900
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.d.a(A_0) && cuo.a.NextDouble() < 0.5)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().Feats.Contains<c3v>() && amc.aa().Offense.aa().zo() >= 20f && !amc.aa().SpecialStates.d && amc.aa().IsInControl)
			{
				double num = aw1.b(A_0.c().a8(), amc.a8());
				eu7 eu = this.d.b(A_0);
				if (eu != null && (double)eu.c(amc.a8()) >= num)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x000687EC File Offset: 0x000669EC
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().Passive && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.MindAffecting))
			{
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

	// Token: 0x04000C7D RID: 3197
	private new fh a;

	// Token: 0x04000C7E RID: 3198
	private new TryInvokePsiAbilityNode<dzs> b;

	// Token: 0x04000C7F RID: 3199
	private new TryInvokePsiAbilityNode<eq6> c;

	// Token: 0x04000C80 RID: 3200
	private new TryInvokePsiAbilityNode<px> d;
}
