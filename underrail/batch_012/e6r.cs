using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001413 RID: 5139
[eiz("SPXPA")]
[bs6("SpiritPoisonExpiresAction")]
[Serializable]
public sealed class e6r : bhv, ISerializable
{
	// Token: 0x0600735C RID: 29532 RVA: 0x0030A044 File Offset: 0x00308244
	private e6r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600735D RID: 29533 RVA: 0x0030A050 File Offset: 0x00308250
	public e6r()
	{
	}

	// Token: 0x0600735E RID: 29534 RVA: 0x0030A05C File Offset: 0x0030825C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && base.x2() != null && base.x2().a8() != null)
		{
			efk efk = base.x2().aa();
			if (efk.Passive || !efk.b(d8o.b | d8o.c) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Bilocation) || efk.Vehicle != null)
			{
				etm a_ = new etm(new ap9(efk), "билокации");
				bey.a(a_, efk, base.x2());
				a7v.a(a_);
				bmj.a(base.x2().a8(), new ba0());
			}
			else
			{
				List<ak1> list = aw1.a(base.x2().a8(), null);
				if (list.Count > 0)
				{
					ak1 ak = list[cuo.a.Next(list.Count)];
					a1q value = eq6.a(ezx.k);
					new d8g(null, base.x2().a8(), new bt4(base.x2().a8().Area.y8(), ak.Location.a()), new a1q?(value), false, null, null, null, null).ym(null, null, null);
				}
			}
		}
		return dc4.c;
	}
}
