using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x02000F78 RID: 3960
[eiz("SWEA0")]
[Serializable]
public sealed class d68 : Aspect<c5x>, c98
{
	// Token: 0x0600508A RID: 20618 RVA: 0x00243330 File Offset: 0x00241530
	private d68(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetDouble("SWEA0:C");
		this.c = (double)A_0.GetInt32("SWEA0:W");
		this.d = (Vector3)A_0.GetValue("SWEA0:A", typeof(Vector3));
	}

	// Token: 0x0600508B RID: 20619 RVA: 0x00243388 File Offset: 0x00241588
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SWEA0:C", this.c);
		info.AddValue("SWEA0:W", this.b);
		info.AddValue("SWEA0:A", this.d);
	}

	// Token: 0x0600508C RID: 20620 RVA: 0x002433D8 File Offset: 0x002415D8
	public Vector3 d()
	{
		return this.d;
	}

	// Token: 0x0600508D RID: 20621 RVA: 0x002433E0 File Offset: 0x002415E0
	public void a(Vector3 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600508E RID: 20622 RVA: 0x002433EC File Offset: 0x002415EC
	public int b()
	{
		return this.b;
	}

	// Token: 0x0600508F RID: 20623 RVA: 0x002433F4 File Offset: 0x002415F4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005090 RID: 20624 RVA: 0x00243400 File Offset: 0x00241600
	public d68(c5x A_0) : base(A_0)
	{
		this.c = (double)cuo.a.Next(d68.a);
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x00243424 File Offset: 0x00241624
	public void r7(eds A_0)
	{
		if ((this.c -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			double num = this.a();
			this.c = num / 2.0 * (1.0 + cuo.a.NextDouble());
			Vector3 value = new Vector3((float)((double)this.d.X * cuo.a.NextDouble()), (float)((double)this.d.Y * cuo.a.NextDouble()) + 3f, (float)((double)this.d.Z * cuo.a.NextDouble()));
			Vector3 vector = base.a8().Location + value;
			int num2 = 1 + cuo.a.Next(2);
			float value2 = Convert.ToSingle(0.5 * (1.0 + cuo.a.NextDouble()));
			value2 = 1f;
			aud a_ = base.a8().Area;
			Vector3 a_2 = vector;
			HorizontalDirection? a_3 = null;
			string a_4 = "WindySnow" + num2.ToString();
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = new float?(value2);
			c5x c5x = boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, a_6, null, null);
			if (c5x != null && c5x.o.b != null)
			{
				float num3 = 0.5f + (float)cuo.a.NextDouble();
				if (num3 < 1f)
				{
					c5x.o.b.i = num3 * Vector2.One;
				}
				bpu bpu = new bpu(c5x);
				bpu.b(2f);
				bpu.a(bpu.h9());
				c5x.SetAspect<bpu>(bpu);
				mj mj = new mj(c5x, bpu);
				c5x.SetAspect<mj>(mj);
				Vector3 a_7 = c5x.Location + new Vector3(0f, -3f, 0f);
				bpr a_8 = new bpr(mj, a_7);
				base.a8().Zone.ActionManager.g9(a_8, atp.a);
			}
		}
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x00243664 File Offset: 0x00241864
	private double a()
	{
		float num = Math.Abs(this.d.X * this.d.Y);
		if (this.b < 1)
		{
			this.b = 1;
		}
		double num2;
		if (this.b < 40)
		{
			num2 = 1.01 - (double)(1f / (float)this.b);
		}
		else
		{
			num2 = (double)this.b;
		}
		double a_ = 1000.0 / ((double)(num / 100f * 3f) * num2);
		return d05.b(1.0, a_, 2000.0);
	}

	// Token: 0x040020F0 RID: 8432
	private static readonly int a = 1000;

	// Token: 0x040020F1 RID: 8433
	private int b;

	// Token: 0x040020F2 RID: 8434
	private double c;

	// Token: 0x040020F3 RID: 8435
	private Vector3 d;
}
