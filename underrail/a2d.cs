using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000624 RID: 1572
[e7l(SpellTargetType.CreatureOrWaterTile)]
public class a2d : lu
{
	// Token: 0x0600287C RID: 10364 RVA: 0x000E8EEC File Offset: 0x000E70EC
	public int a()
	{
		eu7 eu = this.a as eu7;
		if (eu != null)
		{
			return eu.g();
		}
		return 0;
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x000E8F14 File Offset: 0x000E7114
	public a2d(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x000E8F24 File Offset: 0x000E7124
	public override bcw c5()
	{
		return bcw.d;
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x000E8F2C File Offset: 0x000E712C
	public override bool cg(object A_0)
	{
		ak1 ak = A_0 as ak1;
		if (ak != null && ak.Formation.b(64L))
		{
			return true;
		}
		b0b b0b = A_0 as b0b;
		return b0b != null && b0b.GetAspect<amc>() != null;
	}

	// Token: 0x04001659 RID: 5721
	private av a;
}
