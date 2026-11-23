using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C5D RID: 3165
public sealed class agl : jn
{
	// Token: 0x0600471A RID: 18202 RVA: 0x001D5644 File Offset: 0x001D3844
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x0600471B RID: 18203 RVA: 0x001D564C File Offset: 0x001D384C
	public agl() : base("xphw_spanner", "creature\\characters\\xphw\\spanner")
	{
	}

	// Token: 0x0600471C RID: 18204 RVA: 0x001D5660 File Offset: 0x001D3860
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_theTripContinues", new bool?(false)).Value)
		{
			return "xphw_exobase_tun";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_started", new bool?(false)).Value)
		{
			return "xphw_darkTer2";
		}
		return "xphw_up";
	}

	// Token: 0x0600471D RID: 18205 RVA: 0x001D56C4 File Offset: 0x001D38C4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.w] = CharacterState.Operating;
			aspect.y6()[ddq.ay] = new bt4("global:xphw_spanner");
		}
	}
}
