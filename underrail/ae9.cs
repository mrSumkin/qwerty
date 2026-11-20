using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B92 RID: 2962
[eiz("CCWHU3CDJ")]
[Serializable]
public sealed class ae9 : cze, ISerializable
{
	// Token: 0x06004377 RID: 17271 RVA: 0x001A6534 File Offset: 0x001A4734
	private ae9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004378 RID: 17272 RVA: 0x001A653C File Offset: 0x001A473C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004379 RID: 17273 RVA: 0x001A6540 File Offset: 0x001A4740
	public ae9()
	{
	}

	// Token: 0x0600437A RID: 17274 RVA: 0x001A654C File Offset: 0x001A474C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("9308d3f7-1a7a-41bc-95c6-b155edd11f99"), aud).ao() as c5x;
			if (c5x != null)
			{
				if (c5x.GetAspect<dt5>() != null)
				{
					c5x.RemoveAspect<dt5>();
				}
				eh1 eh = new eh1();
				eh.a(false);
				eh.ym(A_0, A_1, null);
				alv aspect = c5x.GetAspect<alv>();
				if (aspect != null)
				{
					aspect.a[0].a = "Objects\\Devices\\StandingConsoleOrientation";
					aspect.a[0].b.X = 3;
					aspect.a[0].b.Y = 1;
				}
				if (c5x.GetAspect<bim>() != null)
				{
					c5x.RemoveAspect<bim>();
				}
				d85 d = c5x.GetAspect<bim>() as d85;
				if (d == null)
				{
					d = new d85(c5x);
					c5x.SetAspect<bim>(d);
				}
				if (d.a().Count == 0)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_cc_jkk_disableWarehouseSecurityStarted", new bool?(false)).Value)
					{
						d.a().Add("Панель разбита и не работает.");
					}
					else
					{
						d.a().Add("Панель разбита и не работает. До сих пор чувствуется слабый запах сгоревшей электроники.");
					}
					c4f c4f = new c4f();
					c4f.Properties["quest_cc_ps_clearWarehouse_findConsole"] = true;
					d.s().Add(c4f);
					d.h(true);
				}
			}
		}
	}
}
