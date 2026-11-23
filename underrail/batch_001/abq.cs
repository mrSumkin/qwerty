using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A4D RID: 2637
[eiz("S11")]
[Serializable]
public sealed class abq : cze, ISerializable
{
	// Token: 0x06003E6D RID: 15981 RVA: 0x00178E44 File Offset: 0x00177044
	private abq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S11:S");
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x00178E60 File Offset: 0x00177060
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S11:S", this.a);
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x00178E7C File Offset: 0x0017707C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x00178E84 File Offset: 0x00177084
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x00178E90 File Offset: 0x00177090
	public abq()
	{
	}

	// Token: 0x06003E72 RID: 15986 RVA: 0x00178E9C File Offset: 0x0017709C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null)
		{
			axh aspect = c5x.GetAspect<axh>();
			a3f a3f = c5x.GetAspect<a3f>();
			if (a3f == null)
			{
				a3f = new a3f(c5x);
				c5x.SetAspect<a3f>(a3f);
			}
			if (this.a)
			{
				bool flag = false;
				if (aspect != null)
				{
					flag = aspect.f();
				}
				c5x c5x2 = new c5x();
				c5x2.q("Рубильник");
				c5x2.Layer = c5x.Layer;
				alv alv = new alv(c5x2);
				string text;
				if (c5x.o.b != null && c5x.o.b.a == "Objects\\Devices\\BotShieldGeneratorDoor")
				{
					text = "Objects\\Devices\\BotShieldGeneratorLever";
				}
				else if (c5x.p.b != null && c5x.p.b.a[0].a == "Objects\\Obstacles\\xpbl_LemuriaPowerBoxX")
				{
					text = "Objects\\Obstacles\\xpbl_LemuriaPowerBoxX_Switch";
				}
				else if (c5x.p.b != null && c5x.p.b.a[0].a == "Objects\\Obstacles\\xpbl_LemuriaPowerBoxY")
				{
					text = "Objects\\Obstacles\\xpbl_LemuriaPowerBoxY_Switch";
				}
				else
				{
					text = "Objects\\Containers\\PowerBoxSwitch";
				}
				cd0 cd = new cd0(c5x2);
				cd.a = text;
				cd.b = new Point((flag > false) ? 1 : 0, 0);
				alv.a.Add(cd);
				cd0 cd2 = new cd0(c5x2);
				cd2.a = text;
				cd2.b = new Point((flag > false) ? 1 : 0, 1);
				cd2.d = new float?(0f);
				alv.a.Add(cd2);
				c5x2.SetAspect<alv>(alv);
				a3f a3f2 = new a3f(c5x2);
				a3f2.a().SetPropertyValue("parentPowerBoxId", c5x.qe());
				c5x2.SetAspect<a3f>(a3f2);
				bsl bsl = new bsl(c5x2);
				bsl.af2(true);
				bsl.a(new Point?(new Point(0, 0)));
				bsl.b(new eb7(new Guid?(c5x.qe()), false));
				bsl.b(new Point?(new Point(1, 0)));
				bsl.a(new eb7(new Guid?(c5x.qe()), true));
				List<cze> list = bsl.s();
				bfq bfq = new bfq("switch", "LeverSwitchPull");
				bfq.a(true);
				list.Add(bfq);
				if (c5x.s.b != null)
				{
					bsl.a(new List<HorizontalDirection>(c5x.s.b.t()));
				}
				c5x2.SetAspect<bim>(bsl);
				if (aspect != null)
				{
					axh axh = new axh(c5x2);
					axh.a(aspect.h());
					axh.a(null, aspect.i(), null);
					c5x2.SetAspect<axh>(axh);
				}
				c5x2.Size = c5x.Size;
				c5x2.Location = c5x.Location;
				c5x2.Layer = c5x.Layer;
				c5x2.VisualPriority = c5x.VisualPriority + 1;
				c3g aspect2 = c5x.GetAspect<c3g>();
				if (aspect2 != null)
				{
					c3g c3g = new c3g(c5x2);
					aspect2.a(c3g);
					c5x2.SetAspect<c3g>(c3g);
				}
				c5x.Area.a(c5x2);
				a3f.a().SetPropertyValue("childSwitchId", c5x2.qe());
				return;
			}
			Guid? primitivePropertyValue = a3f.a().GetPrimitivePropertyValue<Guid>("childSwitchId", null);
			if (primitivePropertyValue != null)
			{
				ar7 ar = new ar7(primitivePropertyValue.Value, c5x.Area);
				if (ar.ao() != null)
				{
					ar.ao().an();
				}
				a3f.a().SetPropertyValue("childSwitchId", null);
			}
		}
	}

	// Token: 0x04001BBA RID: 7098
	private new bool a;
}
