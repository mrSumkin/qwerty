using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013C7 RID: 5063
[eiz("F24")]
[bs6("HFX:ForceEmission")]
[Serializable]
public sealed class a91 : cpl, ISerializable
{
	// Token: 0x06007204 RID: 29188 RVA: 0x002FE700 File Offset: 0x002FC900
	private a91(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007205 RID: 29189 RVA: 0x002FE70C File Offset: 0x002FC90C
	public a91()
	{
	}

	// Token: 0x06007206 RID: 29190 RVA: 0x002FE718 File Offset: 0x002FC918
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead || base.a() == null || base.a().aa().Dead)
		{
			return dc4.e;
		}
		int num = new e5o().a(new eoj(base.a().aa(), null, null));
		if (num == 0 || base.a().aa().i(num))
		{
			if (num != 0)
			{
				base.a().aa().j(num);
			}
			if (base.agw().b)
			{
				c5x a_ = base.b().a8();
				string a_2 = "Psi";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				base.b().a8().c().a(Guid.NewGuid().ToString(), "ForceEmissionHit", 1f, c9z.a, false, false);
				csk item = euf.a(e5o.a(base.agu().Power, 1.0), 1.0);
				cwt cwt = new cwt();
				cwt.i = base.agw().i;
				cwt.f.Add(item);
				cwt.v = "силовая волна";
				cwt.b = true;
				cwt.c = base.agw().c;
				cwt.h = ImpactSpeed.Low;
				cwt.j = base.agw().j;
				cwt.w = true;
				base.b().aa().Defense.a(cwt);
			}
		}
		return dc4.c;
	}
}
