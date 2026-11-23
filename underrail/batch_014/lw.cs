using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000742 RID: 1858
public sealed class lw : km
{
	// Token: 0x06002FBB RID: 12219 RVA: 0x001212E4 File Offset: 0x0011F4E4
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
			float f = 0.5f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.3f;
			float value = 0.7f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.3f;
			am5 am;
			aspect.e.TryGetValue(aspect.af(), out am);
			string text = am.b;
			string[] array = text.Split(new string[]
			{
				"\\"
			}, StringSplitOptions.None);
			if (array != null && array.Length == 2)
			{
				text = ((aspect.aa().Gender == Gender.Female) ? "pl_f_crtecfx" : "pl_crtecfx") + "\\" + array[1];
				Point a_ = new Point(aspect.x(), aspect.a8().ac);
				f6 f2 = eg0.a(bpo.GetServiceOrThrow<cne>(), A_0, "Creatures\\" + text, a_, null, true);
				if (f2 != null)
				{
					f2.e = new Color?(new Color(50, 255, 205, 255));
					f2.h = new float?(value);
					f2.f = f;
					A_2.b.a(num + 1, f2);
				}
			}
		}
	}
}
