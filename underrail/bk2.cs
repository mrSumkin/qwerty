using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000F67 RID: 3943
[eiz("ETHBREA")]
[Serializable]
public sealed class bk2 : Aspect<c5x>, c98
{
	// Token: 0x06004FEF RID: 20463 RVA: 0x0023E058 File Offset: 0x0023C258
	private bk2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("ETHBREA:O");
		this.b = A_0.GetDouble("ETHBREA:T");
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x0023E084 File Offset: 0x0023C284
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ETHBREA:O", this.a);
		info.AddValue("ETHBREA:T", this.b);
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x0023E0B0 File Offset: 0x0023C2B0
	public bk2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x0023E0BC File Offset: 0x0023C2BC
	public void a()
	{
		base.a8().c().a("xphw_brazierActivation");
		this.a = true;
		this.b = 0.0;
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x0023E0EC File Offset: 0x0023C2EC
	public void r7(eds A_0)
	{
		if (base.a8().p.b == null)
		{
			return;
		}
		if (base.a8().p.b.a.Count != 4)
		{
			return;
		}
		if (this.a)
		{
			cd0 cd = base.a8().p.b.a[3];
			cd0 cd2 = base.a8().p.b.a[2];
			this.b += A_0.b.TotalMilliseconds;
			if (this.b < 1400.0)
			{
				int num = Convert.ToInt32(this.b / 66.0);
				int x = num % 7;
				int y = num / 7;
				cd.b = new Point(x, y);
				cd.d = null;
				if (this.b > 1050.0)
				{
					float value = Convert.ToSingle((1400.0 - this.b) / 330.0);
					cd.d = new float?(value);
				}
			}
			else
			{
				cd.d = new float?(0f);
			}
			if (this.b > 950.0)
			{
				float? num2 = new float?(Convert.ToSingle((this.b - 500.0) / 500.0));
				float? num3 = num2;
				float num4 = (float)1;
				if (num3.GetValueOrDefault() >= num4 & num3 != null)
				{
					num2 = null;
				}
				cd2.d = num2;
			}
			else
			{
				cd2.d = new float?(0f);
			}
			int num5 = Math.Min(Convert.ToInt32(this.b / 100.0), 23);
			int x2 = num5 % 8;
			int y2 = num5 / 8;
			Point point = new Point(x2, y2);
			base.a8().p.b.a[0].b = point;
			base.a8().p.b.a[1].b = point;
			bsf bsf = base.a8().a("brazier");
			if (bsf == null)
			{
				bsf = new ah7("brazier", null)
				{
					Light = new ae8(new Color(165, 255, 255), 0f, LightType.Increment),
					Range = 8f,
					LightFadeRate = 0.125f
				}.g();
				bsf.be(base.a8());
			}
			float a_ = Convert.ToSingle(Math.Min(1.0, this.b / 800.0));
			bsf.Definition.Light = new ae8(new Color(165, 255, 255), a_, LightType.Increment);
			bsf.b();
		}
	}

	// Token: 0x0400209D RID: 8349
	private bool a;

	// Token: 0x0400209E RID: 8350
	private double b;
}
