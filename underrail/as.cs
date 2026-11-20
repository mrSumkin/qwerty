using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200073E RID: 1854
public sealed class @as : km
{
	// Token: 0x06002FB1 RID: 12209 RVA: 0x00120B24 File Offset: 0x0011ED24
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
				text = ((aspect.aa().Gender == Gender.Female) ? "pl_f_exodrfx" : "pl_exodrfx") + "\\" + array[1];
				Point a_ = new Point(aspect.x(), aspect.a8().ac);
				f6 f2 = eg0.a(bpo.GetServiceOrThrow<cne>(), A_0, "Creatures\\" + text, a_, null, true);
				float num4;
				if (aspect.aa().Gear.l().Item != null)
				{
					int? num2 = aspect.aa().Gear.l().Item.Definition.ba();
					int num3 = 0;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						num4 = Convert.ToSingle(aspect.aa().Gear.l().Item.Battery / (double)aspect.aa().Gear.l().Item.Definition.ba().Value);
						goto IL_225;
					}
				}
				num4 = 1f;
				IL_225:
				if (f2 != null)
				{
					f2.e = new Color?(new Color(255, (int)((byte)(200f * num4)), (int)((byte)(200f * num4)), 255));
					f2.h = new float?(value);
					f2.f = f;
					A_2.b.a(num + 1, f2);
				}
			}
		}
	}
}
