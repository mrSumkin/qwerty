using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001561 RID: 5473
[eiz("XWA")]
[Serializable]
public sealed class v : d64, ISerializable
{
	// Token: 0x060079E4 RID: 31204 RVA: 0x003301DC File Offset: 0x0032E3DC
	private v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079E5 RID: 31205 RVA: 0x003301E8 File Offset: 0x0032E3E8
	public v()
	{
	}

	// Token: 0x060079E6 RID: 31206 RVA: 0x003301F4 File Offset: 0x0032E3F4
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.k = "Раскрыть уязвимость";
			awq.a(base.c(), base.b(), cwt, cd, new v.a());
		}
	}

	// Token: 0x02001562 RID: 5474
	[eiz("XWA1")]
	[Serializable]
	private new class a : enp, ISerializable
	{
		// Token: 0x060079E7 RID: 31207 RVA: 0x003302F8 File Offset: 0x0032E4F8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00330300 File Offset: 0x0032E500
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00330304 File Offset: 0x0032E504
		public a()
		{
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x00330310 File Offset: 0x0032E510
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				if (A_1.aa().Passive || A_1.aa().d(CharacterImmunities.Dismantle))
				{
					etm a_ = new etm(new ap9(A_1.aa()), "эффекту разборки");
					bey.a(a_, A_0.aa(), A_1.aa(), A_1);
					a7v.a(a_);
					bmj.a(A_1.a8(), new ba0());
					return;
				}
				double num = csr.b(new eoj(A_0.aa(), null, null));
				if (A_1.aa().b(d8o.e))
				{
					num *= 0.5;
				}
				A_1.aa().StatusEffects.a(new ht(csr.a(new eoj(A_0.aa(), null, null)) * d0u.b, num), false, false, false);
			}
		}
	}
}
