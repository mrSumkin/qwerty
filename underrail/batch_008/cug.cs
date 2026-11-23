using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02000A80 RID: 2688
[eiz("TCHSRHCS")]
[Serializable]
public sealed class cug : cze, ISerializable
{
	// Token: 0x06003F3F RID: 16191 RVA: 0x0017EFE0 File Offset: 0x0017D1E0
	private cug(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("TCHSRHCS:O");
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x0017EFFC File Offset: 0x0017D1FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCHSRHCS:O", this.a);
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x0017F018 File Offset: 0x0017D218
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x0017F020 File Offset: 0x0017D220
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x0017F02C File Offset: 0x0017D22C
	public cug()
	{
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x0017F038 File Offset: 0x0017D238
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			string[] array = new string[]
			{
				"ce39cc58-3a82-4411-b7c3-bdac954044ba",
				"936f317c-bfb4-476f-81a5-9b007ceca798",
				"ddfdf6c9-8d99-4261-84c3-f92f53908112",
				"5a063577-efd4-4258-a50e-f224b96391fe",
				"be34ee44-976f-44cb-9134-5cdb9fb44c0a",
				"918b871e-e899-409a-9b2d-304959c9bc42"
			};
			for (int i = 0; i < array.Length; i++)
			{
				c5x c5x = new ar7(new Guid(array[i]), A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					if (aspect != null && cnb != null)
					{
						ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
						if (ak != null)
						{
							if (!this.a)
							{
								if (cnb.q())
								{
									cnb.a(null, null, true, false);
									clw clw = new clw();
									clw.a(new e6z(A_0.Area));
									clw.a(false);
									clw.a(Axis.Y);
									clw.a().Add(ak.Location);
									clw.e().Add(c5x.qe());
									A_0.Zone.ActionManager.g9(clw, atp.a);
								}
								if (!aspect.n())
								{
									aspect.b(true, true);
								}
							}
							else
							{
								if (aspect.n())
								{
									aspect.a(true, true);
								}
								if (!cnb.q())
								{
									cnb.a(null, null, true, false);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001BD5 RID: 7125
	private new bool a;
}
