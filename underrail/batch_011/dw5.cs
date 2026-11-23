using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000A4A RID: 2634
[eiz("XPBLDNDILJ")]
[Serializable]
public sealed class dw5 : cze, ISerializable
{
	// Token: 0x06003E5C RID: 15964 RVA: 0x00178610 File Offset: 0x00176810
	private dw5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E5D RID: 15965 RVA: 0x0017861C File Offset: 0x0017681C
	public dw5()
	{
	}

	// Token: 0x06003E5E RID: 15966 RVA: 0x00178628 File Offset: 0x00176828
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c1a c1a = serviceOrThrow.aqw();
			if (c1a != null)
			{
				ah7 ah = c1a.i("DynamicLight1");
				c5x c5x = new ar7(new Guid("716a77d4-7bed-4ff6-aa19-0269d33b69dd"), c1a.n("xpbl_ww_dragNDrop")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("eaaf4f28-9980-43d6-83aa-f2f166680365"), c1a.n("xpbl_ww_dragNDrop")).ao() as c5x;
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(4)).Value;
				if (ah != null && c5x != null && c5x2 != null && value != 0)
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_dragNDrop_lightingChangeInterval", null);
					if (primitivePropertyValue == null || primitivePropertyValue < serviceOrThrow.aqu().p())
					{
						switch (value)
						{
						case 2:
							this.a(c5x, new Color(255, 100, 255, 255));
							this.a(c5x2, new Color(255, 100, 255, 255));
							this.a(ah, new Color(255, 100, 255, 255));
							break;
						case 3:
							this.a(c5x, c5x2, ah);
							break;
						case 4:
							this.a(c5x, new Color(255, 255, 0, 255));
							this.a(c5x2, new Color(255, 255, 0, 255));
							this.a(ah, new Color(255, 255, 0, 255));
							break;
						case 5:
							this.a(c5x, c5x2, ah);
							break;
						case 6:
							this.a(c5x, c5x2, ah);
							break;
						default:
							this.a(c5x, c5x2, ah);
							break;
						}
						primitivePropertyValue = new TimeSpan?(TimeSpan.FromMilliseconds(5500.0));
						serviceOrThrow.aqu().r()["loc_xpbl_dragNDrop_lightingChangeInterval"] = primitivePropertyValue;
					}
				}
			}
		}
	}

	// Token: 0x06003E5F RID: 15967 RVA: 0x00178890 File Offset: 0x00176A90
	private void a(c5x A_0, Color A_1)
	{
		A_0.p.b.a[1].c = new Color?(A_1);
	}

	// Token: 0x06003E60 RID: 15968 RVA: 0x001788B8 File Offset: 0x00176AB8
	private void a(ah7 A_0, Color A_1)
	{
		A_0.Layer = aju.x;
		A_0.Light = new ae8(A_1, 1f, LightType.Increment);
		A_0.Range = 6f;
		A_0.LightFadeRate = 0.16f;
		A_0.Enabled = true;
		A_0.d();
	}

	// Token: 0x06003E61 RID: 15969 RVA: 0x00178908 File Offset: 0x00176B08
	private void a(c5x A_0, c5x A_1, ah7 A_2)
	{
		int num = cuo.a.Next(0, 10);
		Color a_ = new Color(255, 100, 255, 255);
		switch (num)
		{
		case 1:
			a_ = new Color(100, 255, 0, 255);
			break;
		case 2:
			a_ = new Color(200, 125, 0, 255);
			break;
		case 3:
			a_ = new Color(0, 255, 155, 255);
			break;
		case 4:
			a_ = new Color(100, 255, 255, 255);
			break;
		case 5:
			a_ = new Color(0, 0, 200, 255);
			break;
		case 6:
			a_ = new Color(255, 0, 0, 255);
			break;
		case 7:
			a_ = new Color(55, 200, 100, 255);
			break;
		case 8:
			a_ = new Color(155, 25, 155, 255);
			break;
		case 9:
			a_ = new Color(55, 55, 220, 255);
			break;
		default:
			a_ = new Color(cuo.a.Next(100, 255), cuo.a.Next(100, 255), cuo.a.Next(100, 255), 255);
			break;
		}
		this.a(A_0, a_);
		this.a(A_1, a_);
		this.a(A_2, a_);
	}
}
