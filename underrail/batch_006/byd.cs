using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001207 RID: 4615
[eiz("FDT")]
[Serializable]
public sealed class byd : cos, ISerializable
{
	// Token: 0x0600631C RID: 25372 RVA: 0x002AD564 File Offset: 0x002AB764
	private byd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("FDT:D");
	}

	// Token: 0x0600631D RID: 25373 RVA: 0x002AD580 File Offset: 0x002AB780
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FDT:D", this.a);
	}

	// Token: 0x0600631E RID: 25374 RVA: 0x002AD59C File Offset: 0x002AB79C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600631F RID: 25375 RVA: 0x002AD5A4 File Offset: 0x002AB7A4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x002AD5B0 File Offset: 0x002AB7B0
	public byd(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x002AD5BC File Offset: 0x002AB7BC
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (A_0 != null && base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0 && !string.IsNullOrEmpty(this.a))
		{
			if (A_0.i.b != null)
			{
				A_0.i.b.a(m7.b, true, false);
			}
			if (A_1.r.b != null)
			{
				A_1.r.b.a(true);
			}
			A_1.TileFormationModifiers.s4(10);
			A_1.z();
			foreach (b0b b0b in Enumerable.First<ak1>(A_1.l).c.Values)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.IsFloor && c5x.y8() == "placeholderFloor" && c5x.Layer == aju.x && c5x.o.b != null)
				{
					c5x.o.b.d = new float?(0f);
					c5x.TileFormationModifiers.c();
					c5x.TileFormationModifiers.s3(1);
					c5x.z();
					break;
				}
			}
			qy qy = new qy();
			List<auv> list = qy.ad();
			aud a_ = base.Area;
			Vector3 a_2 = base.Location.a();
			string a_3 = "Smoke";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
			qy.ad().Add(new a4s(new bfq("FallThroughGrate"), null, new ar7(A_0), null));
			qy.ad().Add(new bm3(dz6.b(250)));
			qy.ad().Add(new c7(A_1, false, false, true, false));
			qy.ad().Add(new bm3(dz6.b(250)));
			List<auv> list2 = qy.ad();
			a4s a4s = new a4s(new be6
			{
				DestinationWaypoint = this.a
			}, null, null, null);
			a4s.a(new ar7(A_0));
			list2.Add(a4s);
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
		return false;
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x002AD848 File Offset: 0x002ABA48
	protected override bool yl(c5x A_0)
	{
		return (A_0 == null || A_0.h.b == null || !(A_0.h.b.aa().FactionId == asp.a0)) && base.yl(A_0);
	}

	// Token: 0x040029D2 RID: 10706
	private new string a;
}
