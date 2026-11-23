using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016E4 RID: 5860
[eiz("A61")]
[Serializable]
public sealed class b6z : a6k, ISerializable
{
	// Token: 0x06007F6F RID: 32623 RVA: 0x0035F6D8 File Offset: 0x0035D8D8
	private b6z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F70 RID: 32624 RVA: 0x0035F6E4 File Offset: 0x0035D8E4
	public b6z()
	{
	}

	// Token: 0x06007F71 RID: 32625 RVA: 0x0035F6F0 File Offset: 0x0035D8F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				bool flag = false;
				for (int i = b.aa().StatusEffects.d().Count - 1; i >= 0; i--)
				{
					els els = b.aa().StatusEffects.d()[i];
					for (int j = els.StaticEffects.Count - 1; j >= 0; j--)
					{
						d3e d3e = els.StaticEffects[j];
						if (d3e is a1s || d3e is ax2 || d3e is bdx)
						{
							b.aa().StatusEffects.d(els);
							flag = true;
							break;
						}
					}
				}
				bgo a_ = new bgo(djj.a(base.vg().e()));
				b.aa().StatusEffects.a(a_, false, false, false);
				if (flag)
				{
					c5x a_2 = c5x;
					string a_3 = "BlueSparkExpiration";
					int a_4 = 2;
					double maxValue = double.MaxValue;
					bool a_5 = false;
					bool a_6 = true;
					Vector3? a_7 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z));
					float? a_8 = dz6.b();
					boj.a(a_2, a_3, a_4, maxValue, a_5, a_6, a_7, null, null, a_8, false);
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
