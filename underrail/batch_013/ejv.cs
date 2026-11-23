using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001536 RID: 5430
[eiz("SGDWA")]
[Serializable]
public sealed class ejv : d64, ISerializable
{
	// Token: 0x06007946 RID: 31046 RVA: 0x0032C700 File Offset: 0x0032A900
	private ejv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x0032C70C File Offset: 0x0032A90C
	public ejv()
	{
	}

	// Token: 0x06007948 RID: 31048 RVA: 0x0032C718 File Offset: 0x0032A918
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
			cwt.k = "Разрядная волна";
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				cwt.f[i] = new csk(csk.DamageType, Convert.ToInt32(Math.Max(1.0, (double)csk.Amount * (1.0 - bc9.b))));
			}
			base.c().a8().c().a("Xpbl_Sonocaster_ds_attack");
			List<string> list = dxr.a();
			amc a_3 = base.c();
			amc a_4 = base.b();
			cwt a_5 = cwt;
			cd1 a_6 = cd;
			aig[] a_7 = new aig[]
			{
				new cgw(base.c(), base.b(), cd, true, 0.35 * (1.0 - bc9.b), "xpbl_SoundGunWaveHitDisruptiveSmall", list.ToArray())
			};
			awq.a(a_3, a_4, a_5, a_6, new duk(list, new cgw.b()), true, null, "xpbl_SoundGunWaveDisruptive", a_7, false, false, true, "xpbl_SoundGunWaveHitDisruptive", null);
			return true;
		}
		return false;
	}
}
