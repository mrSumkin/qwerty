using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000A46 RID: 2630
[eiz("FWHAJ")]
[Serializable]
public sealed class ch2 : cze, ISerializable
{
	// Token: 0x06003E4F RID: 15951 RVA: 0x0017819C File Offset: 0x0017639C
	private ch2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E50 RID: 15952 RVA: 0x001781A8 File Offset: 0x001763A8
	public ch2()
	{
	}

	// Token: 0x06003E51 RID: 15953 RVA: 0x001781B4 File Offset: 0x001763B4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<bu6>();
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
		{
			cwt cwt = (cwt)A_2["attackResult"];
			if (cwt != null)
			{
				if (Enumerable.Any<csk>(cwt.f, new Func<csk, bool>(ch2.a.a.a)))
				{
					float num = euf.f(c5x.h.b.aa());
					if (num < 0.4f)
					{
						c5x.h.b.aa().StatusEffects.a(new awz(0, 0.5), false, false, false);
						c5x.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.3f, 0, 0, 35, 4), false, false, false);
						c5x.h.b.aa().ImmunitiesBase |= CharacterImmunities.Root;
					}
					else if (num < 0.6f)
					{
						c5x.h.b.aa().StatusEffects.a(new awz(0, 0.35), false, false, false);
						c5x.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.2f, 0, 0, 25, 3), false, false, false);
					}
					else if (num < 0.8f)
					{
						c5x.h.b.aa().StatusEffects.a(new awz(0, 0.2), false, false, false);
						c5x.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 2), false, false, false);
					}
					if (c5x.h.b.aa().BaseSightRange != 13f)
					{
						c5x.h.b.aa().BaseSightRange = 13f;
					}
				}
			}
		}
	}

	// Token: 0x02000A47 RID: 2631
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x00178424 File Offset: 0x00176624
		internal bool a(csk A_0)
		{
			return A_0.Amount > 0;
		}

		// Token: 0x04001BB6 RID: 7094
		public static readonly ch2.a a = new ch2.a();

		// Token: 0x04001BB7 RID: 7095
		public static Func<csk, bool> b;
	}
}
