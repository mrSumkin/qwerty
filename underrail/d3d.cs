using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000607 RID: 1543
[e7l(SpellTargetType.EnergyStorageObject)]
public sealed class d3d : emk
{
	// Token: 0x0600282E RID: 10286 RVA: 0x000E7D1C File Offset: 0x000E5F1C
	public d3d(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x000E7D28 File Offset: 0x000E5F28
	public override bool f8(b0b A_0)
	{
		bbw aspect = A_0.GetAspect<bbw>();
		if (aspect != null && aspect.tb())
		{
			return true;
		}
		amc aspect2 = A_0.GetAspect<amc>();
		return aspect2 != null && aspect2.aa().Vehicle != null && aspect2.aa().Vehicle.g() < (double)aspect2.aa().Vehicle.am();
	}
}
