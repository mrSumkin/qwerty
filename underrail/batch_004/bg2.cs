using System;
using System.Runtime.Serialization;

// Token: 0x020008EE RID: 2286
[eiz("LUXLVRPC")]
[Serializable]
public sealed class bg2 : bdw, ISerializable
{
	// Token: 0x060038A5 RID: 14501 RVA: 0x0014F80C File Offset: 0x0014DA0C
	private bg2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x0014F814 File Offset: 0x0014DA14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x0014F818 File Offset: 0x0014DA18
	public bg2()
	{
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x0014F824 File Offset: 0x0014DA24
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lux-b9_pigEscapedPen", new bool?(false)).Value)
		{
			aud aud = A_0.n("lux-b9");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("18664827-9060-4e29-a972-1269aae33708"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("4fbe0d0f-a35a-4452-8868-cf5ec9427b7a"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("0fa0961c-fdb2-4c1d-a18e-b84183d9276f"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("3996a11f-b377-4cd9-8142-8da798ae26a7"), aud).ao() as c5x;
				if (c5x3 != null || c5x4 != null)
				{
					if (c5x != null)
					{
						a0l.a(c5x, "RunawayPigReturn", true);
						if (c5x.h.b != null)
						{
							c5x.h.b.aa().StatusEffects.a(new aw3(0), false, false, false);
						}
						if (c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.ay] = new bt4("RunawayPigReturn");
						}
						c5x c5x5 = new ar7(new Guid("8f13d7b0-c449-405f-b4be-f7f634b51db3"), aud).ao() as c5x;
						c5x c5x6 = new ar7(new Guid("e1027f6a-bd76-47be-8804-5f1936b42b79"), aud).ao() as c5x;
						if (c5x5 != null)
						{
							c5x5.ae = null;
						}
						if (c5x6 != null)
						{
							c5x6.ae = null;
						}
					}
					if (c5x2 != null)
					{
						a0l.a(c5x2, "CalmPigReturn", true);
					}
					c5x c5x7 = new ar7(new Guid("1d3d4b99-0429-457a-95cd-dcdaf29ad78b"), aud).ao() as c5x;
					if (c5x7 != null)
					{
						cnb cnb = c5x7.GetAspect<bim>() as cnb;
						if (cnb != null)
						{
							cnb.d(false);
						}
					}
					if (c5x3 != null && c5x3.t.b != null)
					{
						a0l.a(c5x3, "TraderWp", true);
						c5x3.t.b.y6()[ddq.ay] = new bt4("TraderWp");
						c5x3.t.b.y6().RemoveProperty(ddq.w);
						bn5 bn = c5x3.GetAspect<j7>() as bn5;
						if (bn != null)
						{
							bn.a(true);
						}
					}
					if (c5x4 != null && c5x4.t.b != null)
					{
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lux_Lostvault_Bodygard_allowTrading", new bool?(false)).Value)
						{
							a0l.a(c5x4, "GuardMoved", true);
							c5x4.t.b.y6()[ddq.ay] = new bt4("GuardMoved");
						}
						else
						{
							a0l.a(c5x4, "GuardWp", true);
							c5x4.t.b.y6()[ddq.ay] = new bt4("GuardWp");
						}
						c5x4.t.b.y6().RemoveProperty(ddq.ba);
					}
				}
				else
				{
					if (c5x != null)
					{
						c5x.an();
					}
					if (c5x2 != null)
					{
						c5x2.an();
					}
				}
				serviceOrThrow.aqu().r()["loc_lux-b9_pigEscapedPen"] = false;
			}
		}
	}
}
