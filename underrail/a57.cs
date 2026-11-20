using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017AB RID: 6059
internal class a57 : ak9
{
	// Token: 0x06008196 RID: 33174 RVA: 0x00368FD4 File Offset: 0x003671D4
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Acid, -0.35),
			new dxd(-20),
			new b2g(-0.35)
		};
		A_1 = null;
		A_1 = new wq[0];
		A_2 = null;
	}

	// Token: 0x06008197 RID: 33175 RVA: 0x00369024 File Offset: 0x00367224
	public override string o6()
	{
		return "Xpbl_SoupSip";
	}
}
