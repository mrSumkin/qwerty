using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001534 RID: 5428
[eiz("IA1")]
[Serializable]
public sealed class em4 : d64, ISerializable
{
	// Token: 0x0600793F RID: 31039 RVA: 0x0032C378 File Offset: 0x0032A578
	private em4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x0032C384 File Offset: 0x0032A584
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x0032C38C File Offset: 0x0032A58C
	public em4()
	{
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x0032C394 File Offset: 0x0032A594
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cmn.d += (double)base.c().aa().GetSpecializationValue<b1n>(true) * b1n.a;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 1000.0, null, 1.0, null, true);
			cwt.k = "Пронзение";
			awq.a(base.c(), base.b(), cwt, cd, null);
			if (cwt.b)
			{
				c5x a_ = base.b().a8();
				string a_2 = "Impale";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			}
		}
	}
}
