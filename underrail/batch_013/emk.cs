using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005F9 RID: 1529
[e7l(SpellTargetType.Thing)]
public class emk : d0m
{
	// Token: 0x0600280F RID: 10255 RVA: 0x000E78E8 File Offset: 0x000E5AE8
	public override int atg()
	{
		eu7 eu = this.a as eu7;
		if (eu != null)
		{
			return eu.g();
		}
		return 0;
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x000E7910 File Offset: 0x000E5B10
	protected av a()
	{
		return this.a;
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x000E7918 File Offset: 0x000E5B18
	public emk(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400164F RID: 5711
	private av a;
}
