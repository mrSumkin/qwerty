using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001779 RID: 6009
[eiz("CSBA")]
[Serializable]
public sealed class bei : a6k, ISerializable
{
	// Token: 0x0600810C RID: 33036 RVA: 0x003670B4 File Offset: 0x003652B4
	private bei(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600810D RID: 33037 RVA: 0x003670C0 File Offset: 0x003652C0
	public bei()
	{
	}

	// Token: 0x0600810E RID: 33038 RVA: 0x003670C8 File Offset: 0x003652C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("statBooster");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Booster
				});
				coh coh = base.vg().e().b9() as coh;
				if (coh != null)
				{
					string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("StateOfMatter");
					if (classPropertyValue.Contains("solid"))
					{
						bfq bfq = new bfq();
						bfq.c("Swallow");
						bfq.ym(base.vg().q(), c5x, null);
					}
					else if (classPropertyValue.Contains("liquid"))
					{
						bfq bfq2 = new bfq();
						bfq2.c("HypoUse");
						bfq2.ym(base.vg().q(), c5x, null);
					}
					else
					{
						bfq bfq3 = new bfq();
						bfq3.c("PsionicInhalantInhale");
						bfq3.ym(base.vg().q(), c5x, null);
						c5x c5x2 = boj.a(c5x, "CigarSmoke", 2, double.MaxValue, true, false, new Vector3?(new Vector3(0.45f, 0f, 0.6f)), null, null, null, false);
						if (c5x2 != null)
						{
							c5x2.ad = new Color?(new Color(138, 187, 116));
							c5x2.ae = new float?(0.2f);
						}
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
