using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C8B RID: 3211
[eiz("ARSIDLE")]
[Serializable]
public sealed class c88 : d4
{
	// Token: 0x060048CA RID: 18634 RVA: 0x001DB058 File Offset: 0x001D9258
	private c88(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetBoolean("ARSIDLE:S");
	}

	// Token: 0x060048CB RID: 18635 RVA: 0x001DB074 File Offset: 0x001D9274
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ARSIDLE:S", this.b);
	}

	// Token: 0x060048CC RID: 18636 RVA: 0x001DB090 File Offset: 0x001D9290
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060048CD RID: 18637 RVA: 0x001DB098 File Offset: 0x001D9298
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060048CE RID: 18638 RVA: 0x001DB0A4 File Offset: 0x001D92A4
	public override TimeSpan ge()
	{
		if (this.b)
		{
			return TimeSpan.FromMinutes(2.0);
		}
		return TimeSpan.FromMinutes(10.0);
	}

	// Token: 0x060048CF RID: 18639 RVA: 0x001DB0D0 File Offset: 0x001D92D0
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060048D0 RID: 18640 RVA: 0x001DB0E0 File Offset: 0x001D92E0
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060048D1 RID: 18641 RVA: 0x001DB0F0 File Offset: 0x001D92F0
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060048D2 RID: 18642 RVA: 0x001DB100 File Offset: 0x001D9300
	public c88(bool A_0) : base(c88.a)
	{
		this.b = A_0;
	}

	// Token: 0x060048D3 RID: 18643 RVA: 0x001DB114 File Offset: 0x001D9314
	public c88() : base(c88.a)
	{
	}

	// Token: 0x060048D4 RID: 18644 RVA: 0x001DB124 File Offset: 0x001D9324
	protected override bool ez(cyt A_0)
	{
		if (base.ez(A_0))
		{
			List<string> list = new List<string>
			{
				"D5",
				"D6",
				"E5",
				"E6"
			};
			string text = e3m.a();
			return text == null || !list.Contains(text);
		}
		return false;
	}

	// Token: 0x060048D5 RID: 18645 RVA: 0x001DB18C File Offset: 0x001D938C
	protected override void gg(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
		{
			new bzs().ym(null, null, null);
			if (A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value)
			{
				bv9 bv = A_0.ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.f5, asp.a, h.a, null, true, false, false);
					bv.a(asp.f7, asp.a, h.a, null, true, false, false);
					bv.a(asp.f6, asp.a, h.a, null, true, false, false);
					A_0.r()["faction_xpbl_aegis_betrayed"] = true;
					A_0.r()["loc_xpbl_camp_allowed"] = false;
				}
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_cutCommunication", new bool?(false)).Value)
			{
				bjv.a(A_0, "interfacing_xpbl_navcom_reportAutoResolve");
			}
		}
	}

	// Token: 0x04001CC3 RID: 7363
	public new static readonly string a = "autoResolveSavageInvasion";

	// Token: 0x04001CC4 RID: 7364
	private bool b;
}
