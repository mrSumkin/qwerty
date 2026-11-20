using System;
using System.Runtime.Serialization;

// Token: 0x02000C78 RID: 3192
[eiz("OFNCDE")]
[Serializable]
public sealed class apf : cd2
{
	// Token: 0x06004803 RID: 18435 RVA: 0x001D9124 File Offset: 0x001D7324
	private apf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x001D9130 File Offset: 0x001D7330
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x001D913C File Offset: 0x001D733C
	public override TimeSpan ge()
	{
		return TimeSpan.FromHours(2.0);
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x001D914C File Offset: 0x001D734C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x001D915C File Offset: 0x001D735C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x06004808 RID: 18440 RVA: 0x001D916C File Offset: 0x001D736C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x001D917C File Offset: 0x001D737C
	public apf() : base(apf.a)
	{
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x001D918C File Offset: 0x001D738C
	public apf(bool A_0) : base(apf.a)
	{
	}

	// Token: 0x0600480B RID: 18443 RVA: 0x001D919C File Offset: 0x001D739C
	protected override void gg(cyt A_0)
	{
		string classPropertyValue = A_0.r().GetClassPropertyValue<string>("loc_cvw_dnd_newFestName");
		if (!(classPropertyValue == "HD"))
		{
			if (!(classPropertyValue == "OOW"))
			{
				if (!(classPropertyValue == "NC"))
				{
					A_0.r()["loc_cvw_dnd_newFestName"] = "Beer Fest";
				}
				else
				{
					A_0.r()["loc_cvw_dnd_newFestName"] = "No Cocktails";
				}
			}
			else
			{
				A_0.r()["loc_cvw_dnd_newFestName"] = "One Off Week";
			}
		}
		else
		{
			A_0.r()["loc_cvw_dnd_newFestName"] = "Hardcore Drop";
		}
		A_0.r()["loc_cvw_dragAndDrop_newFestName"] = true;
		A_0.r()["loc_cvw_dragAndDrop_shouldRefreshEvent"] = true;
	}

	// Token: 0x04001CAA RID: 7338
	public new static readonly string a = "OktoberFestNameChangeDelayedEvent";
}
