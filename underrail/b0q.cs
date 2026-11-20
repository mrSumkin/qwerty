using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001446 RID: 5190
[eiz("SHSCB")]
[Serializable]
public sealed class b0q : bvd, ISerializable
{
	// Token: 0x060074AF RID: 29871 RVA: 0x003179F8 File Offset: 0x00315BF8
	private b0q(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060074B0 RID: 29872 RVA: 0x00317A00 File Offset: 0x00315C00
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060074B1 RID: 29873 RVA: 0x00317A04 File Offset: 0x00315C04
	public b0q()
	{
	}

	// Token: 0x060074B2 RID: 29874 RVA: 0x00317A0C File Offset: 0x00315C0C
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		this.mm(A_0, A_1, A_2, A_3, new bps());
	}

	// Token: 0x060074B3 RID: 29875 RVA: 0x00317A20 File Offset: 0x00315C20
	public void mm(amc A_0, amc A_1, cwt A_2, cru A_3, bps A_4)
	{
		if (A_0 == null || A_0.a8() == null || !A_0.aa().Feats.Contains<dvu>() || A_1 == null || A_1.a8() == null)
		{
			return;
		}
		if (A_4 == null)
		{
			A_4 = new bps();
		}
		if (A_4.b("shell_shock"))
		{
			return;
		}
		A_4.a("shell_shock");
		efk efk = A_1.aa();
		if (efk.Passive || efk.b(d8o.e) || !efk.b(d8o.b | d8o.c))
		{
			return;
		}
		if (efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear))
		{
			etm a_ = new etm(new ap9(A_1.aa()), "страху");
			bey.a(a_, A_0.aa(), A_1.aa(), A_1);
			a7v.a(a_);
			bmj.a(A_1.a8(), new ba0());
			return;
		}
		if (euf.m(efk))
		{
			c6f a_2 = new c6f(new ap9(efk), new ap9(A_0.aa()), "страху");
			bey.a(a_2, A_0.aa(), efk, A_1);
			a7v.a(a_2);
			bmj.a(A_1.a8(), new dym());
			return;
		}
		int num = dvu.a(A_0.aa());
		float a_3 = dvu.c(A_0.aa());
		int a_4 = dvu.b(A_0.aa());
		ahi a_5 = new ahi(num * d0u.b, a_3, a_4);
		A_1.aa().StatusEffects.a(a_5, false, false, false);
	}
}
