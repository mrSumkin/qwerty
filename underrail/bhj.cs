using System;
using Microsoft.Xna.Framework;

// Token: 0x02000741 RID: 1857
public sealed class bhj : km
{
	// Token: 0x06002FB9 RID: 12217 RVA: 0x00121034 File Offset: 0x0011F234
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
			bd9 bd = A_3 as bd9;
			float num2 = 0f;
			if (bd != null && bd.b != TimeSpan.Zero && A_0 != null && A_0.anz() != null && A_0.anz().Zone != null)
			{
				double totalMilliseconds = (A_0.anz().Zone.ElapsedZoneTime - bd.b).TotalMilliseconds;
				if (totalMilliseconds < 300.0)
				{
					if (totalMilliseconds < 100.0)
					{
						num2 = Convert.ToSingle(totalMilliseconds / 150.0);
					}
					else if (totalMilliseconds > 200.0)
					{
						num2 = 1f - Convert.ToSingle((totalMilliseconds - 200.0) / 100.0);
					}
					else
					{
						num2 = 1f;
					}
				}
			}
			float num3 = 0.5f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.3f;
			float num4 = 0.7f + (float)Math.Abs(10 - A_0.d() % 20) / 10f * 0.3f;
			num3 *= num2;
			num4 *= num2;
			am5 am;
			aspect.e.TryGetValue(aspect.af(), out am);
			string text = am.b;
			string[] array = text.Split(new string[]
			{
				"\\"
			}, StringSplitOptions.None);
			if (array != null && array.Length == 2)
			{
				text = "Creatures\\xphw_bst_frz_ovr\\" + array[1];
				Point a_ = new Point(aspect.x(), aspect.a8().ac);
				f6 f = eg0.a(bpo.GetServiceOrThrow<cne>(), A_0, text, a_, null, true);
				if (f != null)
				{
					f.e = new Color?(new Color(50, 255, 205, 255));
					f.h = new float?(num4);
					f.f = num3;
					A_2.b.a(num + 1, f);
				}
			}
		}
	}
}
