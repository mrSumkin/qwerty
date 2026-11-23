using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x020012A5 RID: 4773
[eiz("WWCEA")]
[Serializable]
public sealed class a99 : Aspect<c5x>, ISerializable, c98, bp1
{
	// Token: 0x06006869 RID: 26729 RVA: 0x002C2434 File Offset: 0x002C0634
	private a99(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetDouble("WWCEA:C");
	}

	// Token: 0x0600686A RID: 26730 RVA: 0x002C2450 File Offset: 0x002C0650
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WWCEA:C", this.d);
	}

	// Token: 0x0600686B RID: 26731 RVA: 0x002C246C File Offset: 0x002C066C
	public a99(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600686C RID: 26732 RVA: 0x002C2478 File Offset: 0x002C0678
	public void mx()
	{
		this.a();
	}

	// Token: 0x0600686D RID: 26733 RVA: 0x002C2480 File Offset: 0x002C0680
	public void my()
	{
	}

	// Token: 0x0600686E RID: 26734 RVA: 0x002C2484 File Offset: 0x002C0684
	public void r7(eds A_0)
	{
		this.a();
		if ((this.d += A_0.b.TotalMilliseconds) >= (double)this.f)
		{
			this.d -= (double)this.f;
			if (this.e.Count > 0)
			{
				Point a_ = this.e[cuo.a.Next(this.e.Count)];
				ak1 ak = base.a8().Area.a(a_);
				if (ak != null && boj.b(ak))
				{
					List<KeyValuePair<string, float>> list = boj.a(ak, false);
					string str = "WaterWave" + cuo.a.Next(2, 4).ToString();
					foreach (KeyValuePair<string, float> keyValuePair in list)
					{
						if (keyValuePair.Value > 0f)
						{
							if (keyValuePair.Value != 1f)
							{
								aud a_2 = base.a8().Area;
								Vector3 a_3 = a_.a();
								HorizontalDirection? a_4 = null;
								string a_5 = keyValuePair.Key + str;
								int a_6 = 1;
								double maxValue = double.MaxValue;
								float? a_7 = new float?(keyValuePair.Value);
								boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, a_7, null, null);
							}
							else
							{
								boj.a(base.a8().Area, a_.a(), null, keyValuePair.Key + str, 1, double.MaxValue, null, null, null, null);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600686F RID: 26735 RVA: 0x002C2690 File Offset: 0x002C0890
	private void a()
	{
		if (this.e == null)
		{
			this.e = new List<Point>();
			if (base.a8() != null && base.a8().Area != null)
			{
				bool flag = false;
				foreach (ya ya in base.a8().Area.Triggers)
				{
					a4u a4u = ya as a4u;
					if (a4u != null)
					{
						flag = true;
						this.a(a4u.Location.X, a4u.Location.Y, a4u.Size.c, a4u.Size.d);
					}
				}
				if (!flag)
				{
					this.a(0, 0, base.a8().Area.Size.c, base.a8().Area.Size.d);
				}
			}
			if (this.e.Count == 0)
			{
				this.f = int.MaxValue;
				return;
			}
			this.f = d05.a(a99.a, a99.c / this.e.Count, a99.b);
		}
	}

	// Token: 0x06006870 RID: 26736 RVA: 0x002C27D8 File Offset: 0x002C09D8
	private void a(int A_0, int A_1, int A_2, int A_3)
	{
		for (int i = A_0; i < A_0 + A_2; i++)
		{
			for (int j = A_1; j < A_1 + A_3; j++)
			{
				ak1 ak = base.a8().Area.b(i, j);
				if (ak != null && boj.b(ak))
				{
					this.e.Add(new Point(i, j));
				}
			}
		}
	}

	// Token: 0x04002B21 RID: 11041
	private static readonly int a = 100;

	// Token: 0x04002B22 RID: 11042
	private static readonly int b = 3000;

	// Token: 0x04002B23 RID: 11043
	private static readonly int c = 100000;

	// Token: 0x04002B24 RID: 11044
	private double d;

	// Token: 0x04002B25 RID: 11045
	[NonSerialized]
	private List<Point> e;

	// Token: 0x04002B26 RID: 11046
	[NonSerialized]
	private int f;
}
