using System;
using System.Runtime.Serialization;

// Token: 0x02001732 RID: 5938
[eiz("ROJYCA")]
[Serializable]
public sealed class etv : a6k
{
	// Token: 0x0600802B RID: 32811 RVA: 0x00362520 File Offset: 0x00360720
	private etv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x0036252C File Offset: 0x0036072C
	public etv()
	{
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x00362538 File Offset: 0x00360738
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null)
		{
			if (base.vg().e() != null && base.vg().e().b9() is coh)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					string text;
					if (base.vg().q().Area.y8() == "ojy-c1")
					{
						base.vg().e().a(true);
						base.vg().q().c().a("ArmTntCharge");
						text = "Вы закладываете взрывчатку на потолке пещеры.";
						serviceOrThrow.aqu().r()["quest_jyrigTheCavern_rigged"] = true;
					}
					else
					{
						text = "Необходимо заложить это в пещере под воротами на Старую Свалку.";
					}
					if (!string.IsNullOrEmpty(text))
					{
						a7v.a(new h0(text, null));
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
