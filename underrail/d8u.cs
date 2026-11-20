using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001795 RID: 6037
[eiz("CTJA")]
[Serializable]
public sealed class d8u : a6k, ISerializable
{
	// Token: 0x0600815D RID: 33117 RVA: 0x003682E0 File Offset: 0x003664E0
	private d8u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600815E RID: 33118 RVA: 0x003682EC File Offset: 0x003664EC
	public d8u()
	{
	}

	// Token: 0x0600815F RID: 33119 RVA: 0x003682F8 File Offset: 0x003664F8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("theJuice");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Booster
				});
				string path = "components\\Containers\\bottle";
				if (ez2.GetItemDefinition<a1k>(path, true) != null)
				{
					fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(path));
					mk mk = new mk();
					mk.StaticItems.z3(a_, true);
					mk.ym(null, base.vg().q(), null);
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					serviceOrThrow.aqu().r()["item_juice_drank"] = true;
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
