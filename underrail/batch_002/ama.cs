using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020010B2 RID: 4274
[eiz("TCX5")]
[Serializable]
public sealed class ama : cze
{
	// Token: 0x060059D0 RID: 22992 RVA: 0x0026C79C File Offset: 0x0026A99C
	private ama(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060059D1 RID: 22993 RVA: 0x0026C7A8 File Offset: 0x0026A9A8
	public ama()
	{
	}

	// Token: 0x060059D2 RID: 22994 RVA: 0x0026C7B4 File Offset: 0x0026A9B4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.h.b != null)
		{
			c5x.h.b.a(null, false);
			c5x c5x2 = vq.a("Creature\\Critters\\TchortTentacle", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null && c5x2.i.b != null && c5x2.h.b != null)
			{
				c5x2.h.b.ap = new CharacterState?(CharacterState.Custom1);
				c5x2.h.b.aq = new int?(0);
				dm dm = new dm(c5x2);
				dm.a(new int?(3 * d0u.b));
				List<cze> list = dm.d();
				nb nb = new nb();
				nb.a(bvl.c);
				list.Add(nb);
				c5x2.SetAspect<dm>(dm);
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				awx.ad().Add(new bm3(dz6.b(200)));
				awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom1, dz6.b(120), 0, null, 1));
				List<auv> list2 = awx.ad();
				a4s a4s = new a4s(new epw(null), null, null, null);
				a4s.b(new ar7(c5x2));
				list2.Add(a4s);
				List<auv> list3 = awx.ad();
				a4s a4s2 = new a4s(new b16(null), null, null, null);
				a4s2.b(new ar7(c5x2));
				list3.Add(a4s2);
				c5x2.i.b.b(awx, atp.a);
				dz6.a(awx);
			}
		}
	}
}
