using System;
using TimelapseVertigo.Rules.Items;
using TimelapseVertigo.UI.Controls;

// Token: 0x02001FE7 RID: 8167
public sealed class b75 : PlayerGearItemSlotControl<coh>
{
	// Token: 0x0600BFDF RID: 49119 RVA: 0x00428534 File Offset: 0x00426734
	public b75(ItemSlot<coh> A_0, string A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600BFE0 RID: 49120 RVA: 0x00428540 File Offset: 0x00426740
	public b75(ItemSlot<coh> A_0, string A_1, esj A_2, esj A_3) : base(A_0, A_1, A_2, A_3)
	{
	}

	// Token: 0x0600BFE1 RID: 49121 RVA: 0x00428550 File Offset: 0x00426750
	protected override bool aek(coh A_0)
	{
		return A_0 != null && (A_0 is acz || A_0.Definition.v);
	}
}
