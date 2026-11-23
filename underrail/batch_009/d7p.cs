using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013A8 RID: 5032
[bs6("HFX:corrosiveAcidSplashAndSpill")]
[eiz("ACZX")]
[Serializable]
public sealed class d7p : cpl, ISerializable
{
	// Token: 0x06007190 RID: 29072 RVA: 0x002FAA08 File Offset: 0x002F8C08
	private d7p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x002FAA14 File Offset: 0x002F8C14
	public d7p()
	{
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x002FAA1C File Offset: 0x002F8C1C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		ak1 ak = Enumerable.FirstOrDefault<ak1>(base.b().a8().l);
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_ = base.b().a8();
		string a_2 = "CorrosiveAcidSplash";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(base.b().a8()), null));
		dtb.ad().Add(new amd(base.b(), new els[]
		{
			new deu(deu.c * d0u.b)
		}));
		if (ak != null)
		{
			dtb.ad().Add(new a4s(new b69(new edx(ak), new EntityAspectReference<amc, amc>(base.a())), null, null, null));
		}
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}
}
