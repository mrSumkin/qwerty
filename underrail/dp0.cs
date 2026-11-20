using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016A8 RID: 5800
[eiz("TXSRIA")]
[Serializable]
public sealed class dp0 : a6k, ISerializable
{
	// Token: 0x06007EA9 RID: 32425 RVA: 0x00358504 File Offset: 0x00356704
	private dp0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EAA RID: 32426 RVA: 0x00358510 File Offset: 0x00356710
	public dp0()
	{
	}

	// Token: 0x06007EAB RID: 32427 RVA: 0x0035851C File Offset: 0x0035671C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null && b.aa() != null)
			{
				coh coh = base.vg().e().b8().Gear.l().Item;
				if (coh != null)
				{
					if ((int)coh.Battery <= a0k.d)
					{
						return dc4.e;
					}
					coh.Battery -= (double)a0k.d;
					IEnumerable<coh> enumerable = base.vg().e().b8().Bag.b("med.parafibroticRegenerationCatalyst");
					if (enumerable == null)
					{
						return dc4.e;
					}
					coh coh2 = Enumerable.FirstOrDefault<coh>(enumerable);
					if (coh2 == null)
					{
						return dc4.e;
					}
					if (coh2.Stacks > 1)
					{
						coh2.Stacks--;
					}
					else
					{
						base.vg().e().b8().Bag.z5(coh2);
					}
					if (!b.aa().Dead && !b.aa().c(d8o.e))
					{
						apy a_ = new apy(a0k.a(base.vg().e()), a0k.g, a0k.e * d0u.b, true);
						b.aa().StatusEffects.a(a_, false, false, false);
						return dc4.c;
					}
					vr a_2 = new vr(new ap9(b.aa()), null, "{0} не получает эффекта от парафиброзной регенеративной инъекции", new Color?(adi.m), null);
					bey.a(a_2, b.aa(), b);
					a7v.a(a_2);
					return dc4.e;
				}
			}
		}
		return dc4.e;
	}
}
