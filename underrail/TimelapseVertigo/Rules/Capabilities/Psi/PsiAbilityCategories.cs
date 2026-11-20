using System;

namespace TimelapseVertigo.Rules.Capabilities.Psi
{
	// Token: 0x02002235 RID: 8757
	[Flags]
	[eiz("ePAC")]
	[Serializable]
	public enum PsiAbilityCategories : long
	{
		// Token: 0x04004B65 RID: 19301
		None = 0L,
		// Token: 0x04004B66 RID: 19302
		NonDamaging = 1L,
		// Token: 0x04004B67 RID: 19303
		Damaging = 2L,
		// Token: 0x04004B68 RID: 19304
		Telekinetic = 4L
	}
}
