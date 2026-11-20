using System;
using System.Runtime.Serialization;

// Token: 0x02001585 RID: 5509
[eiz("E08")]
[Serializable]
public sealed class jd : d64, ISerializable
{
	// Token: 0x06007A6A RID: 31338 RVA: 0x00333A68 File Offset: 0x00331C68
	private jd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A6B RID: 31339 RVA: 0x00333A74 File Offset: 0x00331C74
	public jd()
	{
	}

	// Token: 0x06007A6C RID: 31340 RVA: 0x00333A7C File Offset: 0x00331C7C
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
			bool flag = false;
			if ((!base.b().aa().Passive && !base.b().aa().b(d8o.e) && base.b().aa().SpecialStates.a) || base.b().aa().SpecialStates.c)
			{
				cmn.b += base.c().aa().Offense.an();
				flag = true;
			}
			else
			{
				cmn.b += base.c().aa().Offense.an();
			}
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			if (flag)
			{
				for (int i = 0; i < cwt.f.Count; i++)
				{
					cwt.f[i] = new csk(cwt.f[i].DamageType, (int)((double)cwt.f[i].Amount * b13.a(base.vg().e())));
				}
				cwt.k = "Казнь";
			}
			awq.a(base.c(), base.b(), cwt, cd, new jd.a(), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001586 RID: 5510
	[eiz("E08b")]
	[Serializable]
	private new class a : enp, ISerializable
	{
		// Token: 0x06007A6D RID: 31341 RVA: 0x00333D1C File Offset: 0x00331F1C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x00333D24 File Offset: 0x00331F24
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x00333D28 File Offset: 0x00331F28
		public a()
		{
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x00333D34 File Offset: 0x00331F34
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_0 != null && A_0.aa() is e3q && A_1 != null && A_1.aa().Dead && A_1.aa().c(d8o.b))
			{
				cxc.a(eyy.b4);
			}
		}
	}
}
