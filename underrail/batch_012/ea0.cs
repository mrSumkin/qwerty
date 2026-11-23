using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

// Token: 0x02000FA3 RID: 4003
[eiz("MITA")]
[Serializable]
public sealed class ea0 : a6k, ISerializable
{
	// Token: 0x060051C7 RID: 20935 RVA: 0x0024C138 File Offset: 0x0024A338
	private ea0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x0024C144 File Offset: 0x0024A344
	public ea0()
	{
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x0024C150 File Offset: 0x0024A350
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
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
				c5x2.ad = new Color?(new Color(200, 230, 100));
				c5x2.ae = new float?(0.2f);
			}
		}
		else
		{
			c5x.c().a("psionicInhalantInhale", "PsionicInhalantInhale", 1f, c9z.a, false, false);
		}
		c7w.a(c5x, 1);
		return dc4.c;
	}
}
