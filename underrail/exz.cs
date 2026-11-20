using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001538 RID: 5432
[eiz("SGAWA")]
[Serializable]
public sealed class exz : d64, ISerializable
{
	// Token: 0x0600794C RID: 31052 RVA: 0x0032CBF4 File Offset: 0x0032ADF4
	private exz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600794D RID: 31053 RVA: 0x0032CC00 File Offset: 0x0032AE00
	public exz()
	{
	}

	// Token: 0x0600794E RID: 31054 RVA: 0x0032CC0C File Offset: 0x0032AE0C
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
			cwt.k = "Усиленная волна";
			base.c().a8().c().a("Xpbl_Sonocaster_amp_attack");
			List<string> list = dxr.c();
			amc a_3 = base.c();
			amc a_4 = base.b();
			cwt a_5 = cwt;
			cd1 a_6 = cd;
			aig[] a_7 = new aig[]
			{
				new cgw(base.c(), base.b(), cd, false, 0.175, "xpbl_SoundGunWaveHitAmplifiedSmall", list.ToArray())
			};
			awq.a(a_3, a_4, a_5, a_6, new duk(list, null), true, null, "xpbl_SoundGunWaveAmplified", a_7, false, false, true, "xpbl_SoundGunWaveHitAmplified", null);
			return true;
		}
		return false;
	}
}
