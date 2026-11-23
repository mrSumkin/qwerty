using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000613 RID: 1555
[e7l(SpellTargetType.MinableRockOrDestrucableRockOrDebris)]
public sealed class crk : emk
{
	// Token: 0x0600284A RID: 10314 RVA: 0x000E8174 File Offset: 0x000E6374
	public crk(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x000E8180 File Offset: 0x000E6380
	public override bool f8(b0b A_0)
	{
		ei7 aspect = A_0.GetAspect<ei7>();
		if (aspect != null && aspect.d())
		{
			return true;
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null)
		{
			if (A_0.TileFormationModifiers.b(32768L))
			{
				return true;
			}
			if (aspect2.aa().Passive && aspect2.aa().Name == "Груда камней")
			{
				a3f aspect3 = A_0.GetAspect<a3f>();
				return aspect3 == null || !aspect3.a().GetPrimitivePropertyValue<bool>("unminable", new bool?(false)).Value;
			}
		}
		return false;
	}
}
