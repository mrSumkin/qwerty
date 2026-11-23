using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200172E RID: 5934
[eiz("PC4E")]
[Serializable]
public sealed class ave : a6k
{
	// Token: 0x0600801F RID: 32799 RVA: 0x00361AD8 File Offset: 0x0035FCD8
	private ave(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008020 RID: 32800 RVA: 0x00361AE4 File Offset: 0x0035FCE4
	public ave()
	{
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x00361AF0 File Offset: 0x0035FCF0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				a3f aspect = c5x.GetAspect<a3f>();
				if (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("isLoadBearingColumn", new bool?(false)).Value && !aspect.a().GetPrimitivePropertyValue<bool>("rigged", new bool?(false)).Value)
				{
					c5x.c().a("ArmTntCharge");
					aspect.a()["rigged"] = true;
					c5x c5x2 = new c5x();
					c5x2.Layer = aju.x;
					c5x2.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x2.VisualPriority = 1;
					alv alv = new alv(c5x2);
					c5x2.SetAspect<alv>(alv);
					string a;
					if (c5x.VisualDirection == HorizontalDirection.South)
					{
						a = "Objects\\Items\\C4ChargeX";
						c5x2.Location = new Vector3(c5x.Location.X + 0.3f, c5x.Location.Y + 0.9f, 1f);
					}
					else
					{
						a = "Objects\\Items\\C4ChargeY";
						c5x2.Location = new Vector3(c5x.Location.X + 0.9f, c5x.Location.Y + 0.3f, 1f);
					}
					alv.a.Add(new cd0(c5x2)
					{
						a = a,
						b = new Point(0, 0)
					});
					List<cd0> a2 = alv.a;
					etz etz = new etz(c5x2);
					etz.a = a;
					etz.b = new Point(1, 0);
					etz.a(1);
					etz.c(2);
					etz.d(500);
					etz.c = new Color?(Color.White);
					a2.Add(etz);
					c5x.Area.a(c5x2);
					int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up-lw_chargesSet", new int?(0)).Value;
					num++;
					serviceOrThrow.aqu().r()["loc_up-lw_chargesSet"] = num;
					base.vg().e().a(true);
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}
}
