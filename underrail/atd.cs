using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200063A RID: 1594
[e7l(SpellTargetType.Item)]
public class atd : lu
{
	// Token: 0x060028CB RID: 10443 RVA: 0x000E9978 File Offset: 0x000E7B78
	public override bool cg(object A_0)
	{
		coh coh = A_0 as coh;
		return coh != null && this.c4(coh);
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x000E999C File Offset: 0x000E7B9C
	protected virtual bool c4(coh A_0)
	{
		return true;
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x000E99A0 File Offset: 0x000E7BA0
	public override bcw c5()
	{
		return bcw.c;
	}
}
