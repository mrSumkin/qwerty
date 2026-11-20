using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200152D RID: 5421
[eiz("RPSX")]
[Serializable]
public sealed class dcb : d64, ISerializable
{
	// Token: 0x06007924 RID: 31012 RVA: 0x0032B894 File Offset: 0x00329A94
	private dcb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007925 RID: 31013 RVA: 0x0032B8A0 File Offset: 0x00329AA0
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x06007926 RID: 31014 RVA: 0x0032B8AC File Offset: 0x00329AAC
	public dcb()
	{
	}

	// Token: 0x06007927 RID: 31015 RVA: 0x0032B8B8 File Offset: 0x00329AB8
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cmn.c += (double)base.c().aa().GetSpecializationValue<dk9>(true) * dk9.a;
			double num = awq.a(base.vg().e(), base.b(), 0.0);
			efk a_ = base.c().aa();
			efk a_2 = base.b().aa();
			cmn a_3 = cmn;
			double a_4 = 0.0;
			double a_5 = num;
			cwt cwt = euf.a(a_, a_2, a_3, a_4, null, a_5, null, true);
			cwt.k = "Ответный удар";
			awq.a(base.c(), base.b(), cwt, cd, null);
			edz edz = Enumerable.FirstOrDefault<edz>(base.c().aa().StatusEffects.Get<edz>());
			if (edz != null)
			{
				if (edz.Stacks > 1)
				{
					edz edz2 = edz;
					int num2 = edz2.Stacks;
					edz2.Stacks = num2 - 1;
					return;
				}
				base.c().aa().StatusEffects.d(edz);
			}
		}
	}
}
