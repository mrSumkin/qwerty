using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001537 RID: 5431
[eiz("SGRWA")]
[Serializable]
public sealed class ctr : d64, ISerializable
{
	// Token: 0x06007949 RID: 31049 RVA: 0x0032C988 File Offset: 0x0032AB88
	private ctr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600794A RID: 31050 RVA: 0x0032C994 File Offset: 0x0032AB94
	public ctr()
	{
	}

	// Token: 0x0600794B RID: 31051 RVA: 0x0032C9A0 File Offset: 0x0032ABA0
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn cmn = awq.a(base.c(), base.b(), null, null);
			cmn.b += er6.a;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, AmmoType.SonicWave, awq.f(base.c()), a_2, false, null, null, true, null);
			cwt.k = "Резонирующая волна";
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				cwt.f[i] = new csk(csk.DamageType, Convert.ToInt32(Math.Max(1.0, (double)csk.Amount * 0.5)));
			}
			base.c().a8().c().a("Xpbl_Sonocaster_rs_attack");
			List<string> list = dxr.b();
			amc a_3 = base.c();
			amc a_4 = base.b();
			cwt a_5 = cwt;
			cd1 a_6 = cd;
			aig[] a_7 = new aig[]
			{
				new cgw(base.c(), base.b(), cd, false, 0.7, "xpbl_SoundGunWaveHitResonatingSmall", list.ToArray())
			};
			awq.a(a_3, a_4, a_5, a_6, new duk(list, null), true, null, "xpbl_SoundGunWaveResonating", a_7, false, false, true, "xpbl_SoundGunWaveHitResonating", null);
			return true;
		}
		return false;
	}
}
