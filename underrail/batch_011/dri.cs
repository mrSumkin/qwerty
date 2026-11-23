using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02000F87 RID: 3975
[eiz("YSBEA")]
[Serializable]
public sealed class dri : Aspect<c5x>, c98, chb
{
	// Token: 0x060050EF RID: 20719 RVA: 0x00246E64 File Offset: 0x00245064
	private dri(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("YSBEA:C");
	}

	// Token: 0x060050F0 RID: 20720 RVA: 0x00246E80 File Offset: 0x00245080
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YSBEA:C", this.b);
	}

	// Token: 0x060050F1 RID: 20721 RVA: 0x00246E9C File Offset: 0x0024509C
	public dri(c5x A_0) : base(A_0)
	{
		this.b = (double)cuo.a.Next(dri.a);
	}

	// Token: 0x060050F2 RID: 20722 RVA: 0x00246EBC File Offset: 0x002450BC
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if (base.a8().i.b == null || base.a8().i.b.a() != null)
			{
				this.b = (double)dri.a;
				return;
			}
			if ((this.b -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.b += (double)dri.a;
				this.a(false);
				return;
			}
		}
		else
		{
			this.b = (double)(dri.a / 2 + cuo.a.Next(dri.a / 2));
		}
	}

	// Token: 0x060050F3 RID: 20723 RVA: 0x00246F74 File Offset: 0x00245174
	public void c()
	{
		if (base.a8().i.b != null && base.a8().i.b.a() == null)
		{
			this.a(true);
		}
	}

	// Token: 0x060050F4 RID: 20724 RVA: 0x00246FB0 File Offset: 0x002451B0
	private void a(bool A_0 = false)
	{
		cd0 cd = base.a8().o.b;
		if (cd != null)
		{
			int num = cd.b.X + 1;
			if (num > 8 || num < 3 || A_0)
			{
				num = 0;
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | m7.b);
				awx.ad().Add(new a4s(new bfq("SporeBreatherExhaust"), null, new ar7(base.a8()), null));
				List<auv> list = awx.ad();
				aud a_ = base.a8().Area;
				Vector3 a_2 = base.a8().Location;
				string a_3 = "SporeExhault";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? a_5 = dz6.b();
				list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
				dqm dqm = new dqm(cd);
				dqm.b(0);
				if (A_0)
				{
					dqm.c(8);
					dqm.a((double)dz6.b(50));
				}
				else
				{
					dqm.c(3);
					dqm.a(100.0);
				}
				awx.ad().Add(new a4s(new co3("spores", 3.0, Enumerable.FirstOrDefault<ak1>(base.a8().l), null), null, null, null));
				awx.ad().Add(dqm);
				base.a8().i.b.b(awx, atp.a);
				dz6.a(awx);
			}
			cd.b = new Point(num, cd.b.Y);
		}
	}

	// Token: 0x0400212C RID: 8492
	private static readonly int a = 1000;

	// Token: 0x0400212D RID: 8493
	private double b;
}
