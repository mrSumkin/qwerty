using System;
using Microsoft.Xna.Framework;

// Token: 0x0200072D RID: 1837
public sealed class dpy : km
{
	// Token: 0x06002F8D RID: 12173 RVA: 0x0011FD2C File Offset: 0x0011DF2C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		if (A_2 != null && A_2.b != null && A_2.b.b != null)
		{
			amc aspect = A_2.b.b.GetAspect<amc>();
			int num = 0;
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				if (A_2.b.a[i].a == "b")
				{
					num = i;
					break;
				}
			}
			float f = 0.5f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.2f;
			float value = 0.6f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.2f;
			am5 am;
			aspect.e.TryGetValue(aspect.af(), out am);
			string text = am.b;
			string[] array = text.Split(new string[]
			{
				"\\"
			}, StringSplitOptions.None);
			if (array != null && array.Length == 2)
			{
				text = "Creatures\\xphw_bst_scn_ovr\\" + array[1];
				Point a_ = new Point(aspect.x(), aspect.a8().ac);
				f6 f2 = eg0.a(bpo.GetServiceOrThrow<cne>(), A_0, text, a_, null, true);
				if (f2 != null)
				{
					f2.e = new Color?(new Color(255, 25, 25, 255));
					f2.h = new float?(value);
					f2.f = f;
					A_2.b.a(num + 1, f2);
				}
			}
		}
	}
}
