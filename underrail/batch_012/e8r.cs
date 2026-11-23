using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016AE RID: 5806
[eiz("EXRA")]
[Serializable]
public sealed class e8r : a6k, ISerializable
{
	// Token: 0x06007EB8 RID: 32440 RVA: 0x00358B8C File Offset: 0x00356D8C
	private e8r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EB9 RID: 32441 RVA: 0x00358B98 File Offset: 0x00356D98
	public e8r()
	{
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x00358BA4 File Offset: 0x00356DA4
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
					if (els is cjy || els is am0)
					{
						b.aa().StatusEffects.d(els);
						flag = true;
					}
				}
				if (flag)
				{
					c5x a_ = c5x;
					string a_2 = "YellowSparkExpiration";
					int a_3 = 2;
					double maxValue = double.MaxValue;
					bool a_4 = false;
					bool a_5 = true;
					Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z));
					float? a_7 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false);
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
