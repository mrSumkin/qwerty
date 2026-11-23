using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002D5 RID: 725
public static class e3i
{
	// Token: 0x0600157F RID: 5503 RVA: 0x00064CF8 File Offset: 0x00062EF8
	public static void a(ej0 A_0, amc A_1, ak1 A_2)
	{
		c5x c5x = A_0.b().g().a8();
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | (m7.b | m7.k));
		List<auv> list = awx.ad();
		dyg dyg = new dyg();
		dyg.a(A_2);
		a4s a4s = new a4s(dyg, null, null, null);
		a4s.a(new ar7(A_0.b().g().a8()));
		list.Add(a4s);
		if (A_0.b().g().ap != null)
		{
			awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentSubmerge"), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(80), 0, null, 1));
		}
		else
		{
			awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveIn"), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new a7j(A_0.b().g().a8(), bu3.b(A_0.b().g()), 1, double.MaxValue, false, false, null, null, null, null, false, null));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom4, dz6.b(80), 0, null, 1));
		}
		List<auv> list2 = awx.ad();
		ch3 ch = new ch3();
		ch.a(new float?(0f));
		list2.Add(new a4s(ch, null, new ar7(A_0.b().g().a8()), null));
		awx.ad().Add(new duh(A_0.b().g(), new string[]
		{
			bk9.a
		}));
		awx.ad().Add(new bm3(dz6.b(500)));
		awx.ad().Add(new a8v(A_0.b().g().a8(), A_2.Location.a()));
		if (A_1 != null)
		{
			List<auv> list3 = awx.ad();
			a4s a4s2 = new a4s(new akw(), null, null, null);
			a4s2.a(new ar7(A_0.b().g().a8()));
			a4s2.b(new ar7(A_1.a8()));
			list3.Add(a4s2);
		}
		List<auv> list4 = awx.ad();
		ch3 ch2 = new ch3();
		ch2.a(null);
		list4.Add(new a4s(ch2, null, new ar7(A_0.b().g().a8()), null));
		awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveOut"), null, new ar7(A_0.b().g().a8()), null));
		awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom5, dz6.b(80), 0, null, 1));
		awx.ad().Add(new a4s(new epw(null), null, new ar7(A_0.b().g().a8()), null));
		awx.ad().Add(new a4s(new dr5(new Vector3(c5x.Size.X, c5x.Size.Y, bu3.a(A_0.b().g()))), null, new ar7(c5x), null));
		awx.ad().Add(new duh(A_0.b().g(), new string[]
		{
			ewc.a
		}));
		awx.ad().Add(new amd(A_0.b().g(), new els[]
		{
			new aw3(0)
		}));
		A_0.b().i().b(awx, atp.a);
	}
}
