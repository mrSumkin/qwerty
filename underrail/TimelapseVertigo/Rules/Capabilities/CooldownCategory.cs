using System;

namespace TimelapseVertigo.Rules.Capabilities
{
	// Token: 0x02000062 RID: 98
	[eiz("eCC")]
	[Serializable]
	public enum CooldownCategory
	{
		// Token: 0x040002FE RID: 766
		None,
		// Token: 0x040002FF RID: 767
		Sprint,
		// Token: 0x04000300 RID: 768
		DirtyKick,
		// Token: 0x04000301 RID: 769
		Stealth,
		// Token: 0x04000302 RID: 770
		EvasiveManeuvers,
		// Token: 0x04000303 RID: 771
		TrapArming = 100,
		// Token: 0x04000304 RID: 772
		Bilocation = 201,
		// Token: 0x04000305 RID: 773
		PseudoSpatialProjection
	}
}
