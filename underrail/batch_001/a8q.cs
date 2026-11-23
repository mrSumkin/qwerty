using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000B0B RID: 2827
[eiz("XPBLPIRTMG")]
[Serializable]
public sealed class a8q : cze, ISerializable
{
	// Token: 0x0600416A RID: 16746 RVA: 0x00190844 File Offset: 0x0018EA44
	private a8q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x00190850 File Offset: 0x0018EA50
	public a8q()
	{
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x0019085C File Offset: 0x0018EA5C
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
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g3_gateOpen", new bool?(false)).Value;
				c5x a_ = new ar7(new Guid("c761478d-2a9e-4752-b176-48d863f6d30c"), aud).ao() as c5x;
				c5x a_2 = new ar7(new Guid("1fbcb996-ce62-473d-8c0f-fdb6b498402a"), aud).ao() as c5x;
				c5x c5x = new ar7(new Guid("df9a03bc-c39e-47c9-b7b2-8b46ed9aadaf"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("28c3efd3-ed3c-4d73-b2fa-8787efdfc59f"), aud).ao() as c5x;
				aru aru = (new ar7(new Guid("a352da82-f0d5-45ca-be88-c556c94cf8c4"), aud).ao() as c5x).c();
				if (value)
				{
					this.b(a_);
					this.b(a_2);
					this.a(c5x);
					this.a(c5x2);
					this.a(aud, Axis.Y, c5x, c5x2);
					if (aru != null)
					{
						aru.a("open_close", false);
						aru.a("open_close", "Xpbl_PirateBaseMainGateClose", 1f, c9z.a, false, false);
					}
					serviceOrThrow.aqu().r()["loc_xpbl_g3_gateOpen"] = false;
					return;
				}
				this.a(a_);
				this.a(a_2);
				this.b(c5x);
				this.b(c5x2);
				this.a(aud);
				if (aru != null)
				{
					aru.a("open_close", false);
					aru.a("open_close", "Xpbl_PirateBaseMainGateOpen", 1f, c9z.a, false, false);
				}
				serviceOrThrow.aqu().r()["loc_xpbl_g3_gateOpen"] = true;
			}
		}
	}

	// Token: 0x0600416D RID: 16749 RVA: 0x00190A40 File Offset: 0x0018EC40
	public void b(c5x A_0)
	{
		if (A_0 != null)
		{
			A_0.ae = new float?(0f);
			A_0.TileFormationModifiers.c();
			A_0.z();
		}
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x00190A6C File Offset: 0x0018EC6C
	public void a(c5x A_0)
	{
		if (A_0 != null)
		{
			A_0.ae = new float?((float)1);
			A_0.TileFormationModifiers = new bjp(new byte[]
			{
				0,
				1,
				2,
				18
			});
			A_0.z();
		}
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x00190AA4 File Offset: 0x0018ECA4
	public void a(bool A_0, aud A_1)
	{
		c5x c5x = new ar7(new Guid("9cae7c03-e2b8-4a5f-91f9-72e989b8b996"), A_1).ao() as c5x;
		if (c5x != null && c5x.o.b != null)
		{
			if (A_0)
			{
				c5x.o.b.b.X = 1;
				return;
			}
			c5x.o.b.b.X = 0;
		}
	}

	// Token: 0x06004170 RID: 16752 RVA: 0x00190B18 File Offset: 0x0018ED18
	public void a(aud A_0, Axis A_1, c5x A_2, c5x A_3)
	{
		clw clw = new clw();
		clw.a(new e6z(A_0));
		clw.a(false);
		clw.a(A_1);
		if (A_1 == Axis.X)
		{
			clw.a().Add(d05.a(A_2.Location.a(), new Point(0, 1), false));
			clw.a().Add(d05.a(A_3.Location.a(), new Point(0, 2), false));
		}
		else
		{
			clw.a().Add(d05.a(A_2.Location.a(), new Point(1, 0), false));
			clw.a().Add(d05.a(A_3.Location.a(), new Point(2, 0), false));
		}
		clw.e().Add(A_2.qe());
		clw.e().Add(A_3.qe());
		A_0.Zone.ActionManager.g9(clw, atp.a);
	}

	// Token: 0x06004171 RID: 16753 RVA: 0x00190C14 File Offset: 0x0018EE14
	public void a(aud A_0)
	{
		List<c5x> list = new List<c5x>();
		foreach (ak1 ak in new List<ak1>
		{
			A_0.b(20, 18),
			A_0.b(20, 17),
			A_0.b(20, 16),
			A_0.b(24, 18),
			A_0.b(24, 17),
			A_0.b(24, 16)
		})
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null)
				{
					list.Add(c5x);
				}
			}
		}
		foreach (c5x c5x2 in list)
		{
			cwt cwt = new cwt();
			cwt.c = new bool?(true);
			cwt.b = true;
			cwt.l = true;
			cwt.f.Add(new csk(DamageType.Mechanical, 100000));
			cwt.v = "большие ворота";
			akg a_ = new akg(null, c5x2.h.b, cwt, null, false);
			A_0.Zone.ActionManager.g9(a_, atp.a);
		}
	}
}
