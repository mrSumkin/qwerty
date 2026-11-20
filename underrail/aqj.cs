using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C75 RID: 3189
[eiz("BCAMDE")]
[Serializable]
public sealed class aqj : d4
{
	// Token: 0x060047E5 RID: 18405 RVA: 0x001D8C38 File Offset: 0x001D6E38
	private aqj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetBoolean("BCAMDE:CA");
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x001D8C54 File Offset: 0x001D6E54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BCAMDE:CA", this.b);
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x001D8C70 File Offset: 0x001D6E70
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060047E8 RID: 18408 RVA: 0x001D8C78 File Offset: 0x001D6E78
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x001D8C84 File Offset: 0x001D6E84
	public override TimeSpan ge()
	{
		if (this.b)
		{
			return TimeSpan.FromMinutes(3.0);
		}
		return TimeSpan.FromMinutes(10.0);
	}

	// Token: 0x060047EA RID: 18410 RVA: 0x001D8CB0 File Offset: 0x001D6EB0
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x001D8CC0 File Offset: 0x001D6EC0
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x001D8CD0 File Offset: 0x001D6ED0
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x001D8CE0 File Offset: 0x001D6EE0
	public aqj() : base(aqj.a)
	{
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x001D8CF0 File Offset: 0x001D6EF0
	public aqj(bool A_0) : base(aqj.a)
	{
		this.b = A_0;
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x001D8D08 File Offset: 0x001D6F08
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

	// Token: 0x060047F0 RID: 18416 RVA: 0x001D8D70 File Offset: 0x001D6F70
	protected override void gg(cyt A_0)
	{
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (cky != null && cky.a != h.a && A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_cutCommunication", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
		{
			bjv.a(A_0, "interfacing_xpbl_navcom_briggsCallsAboutFirstMission");
		}
	}

	// Token: 0x04001CA7 RID: 7335
	public new static readonly string a = "briggsCallsAboutMicrochip";

	// Token: 0x04001CA8 RID: 7336
	private bool b;
}
