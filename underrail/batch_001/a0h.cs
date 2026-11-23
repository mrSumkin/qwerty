using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000631 RID: 1585
[e7l(SpellTargetType.Spot)]
public class a0h : rl
{
	// Token: 0x060028A0 RID: 10400 RVA: 0x000E9400 File Offset: 0x000E7600
	public override int th()
	{
		eu7 eu = this.a as eu7;
		if (eu != null)
		{
			return eu.g();
		}
		return 0;
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x000E9428 File Offset: 0x000E7628
	protected av a()
	{
		return this.a;
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x000E9430 File Offset: 0x000E7630
	public a0h(av A_0)
	{
		czh.a(A_0, "proxy");
		this.a = A_0;
	}

	// Token: 0x0400165B RID: 5723
	private av a;
}
