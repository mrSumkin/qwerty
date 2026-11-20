using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

// Token: 0x02001790 RID: 6032
[eiz("BI7")]
[Serializable]
public sealed class d30 : a6k, ISerializable
{
	// Token: 0x0600814E RID: 33102 RVA: 0x00367D04 File Offset: 0x00365F04
	private d30(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600814F RID: 33103 RVA: 0x00367D10 File Offset: 0x00365F10
	public d30()
	{
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x00367D1C File Offset: 0x00365F1C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		if (c5x.h.b.aa().Passive || !c5x.h.b.aa().Feats.Contains<c3v>())
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "psionic inhalant");
			bey.a(a_, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
			return dc4.e;
		}
		SoundState? soundState = c5x.c().b("psionicInhalantInhale");
		SoundState soundState2 = SoundState.Playing;
		if (soundState.GetValueOrDefault() == soundState2 & soundState != null)
		{
			c5x.c().a("psionicInhalantExhale", "PsionicInhalantExhale", 1f, c9z.a, false, false);
			c5x c5x2 = boj.a(c5x, "CigarSmoke", 2, double.MaxValue, true, false, new Vector3?(new Vector3(0.45f, 0f, 0.6f)), null, null, null, false);
			if (c5x2 != null)
			{
				c5x2.ad = new Color?(new Color(100, 0, 100));
				c5x2.ae = new float?(0.2f);
			}
		}
		else
		{
			c5x.c().a("psionicInhalantInhale", "PsionicInhalantInhale", 1f, c9z.a, false, false);
		}
		eqq eqq = base.vg().e().p() as eqq;
		int a_2 = eqq.a(base.vg().e());
		int a_3 = eqq.b(base.vg().e());
		c5x.h.b.aa().Offense.b(a_2, true);
		c5x.h.b.aa().Offense.d(a_3, true);
		return dc4.c;
	}
}
