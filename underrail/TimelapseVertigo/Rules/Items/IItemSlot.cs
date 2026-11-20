using System;
using System.Runtime.CompilerServices;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x0200222F RID: 8751
	[eiz("iIS")]
	public interface IItemSlot<out T> where T : coh
	{
		// Token: 0x0600CB15 RID: 51989
		T pp();

		// Token: 0x0600CB16 RID: 51990
		[CompilerGenerated]
		void pm(EventHandler<c1> A_0);

		// Token: 0x0600CB17 RID: 51991
		[CompilerGenerated]
		void pn(EventHandler<c1> A_0);

		// Token: 0x0600CB18 RID: 51992
		bool ph();

		// Token: 0x0600CB19 RID: 51993
		void pi(bool A_0);
	}
}
