using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AD4 RID: 2772
[eiz("XPBLKL3FJ")]
[Serializable]
public sealed class bi7 : cze, ISerializable
{
	// Token: 0x060040A4 RID: 16548 RVA: 0x001899E4 File Offset: 0x00187BE4
	private bi7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x001899F0 File Offset: 0x00187BF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x001899FC File Offset: 0x00187BFC
	public bi7()
	{
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x00189A04 File Offset: 0x00187C04
	public bi7(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x00189A14 File Offset: 0x00187C14
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x00189A1C File Offset: 0x00187C1C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040AA RID: 16554 RVA: 0x00189A28 File Offset: 0x00187C28
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && serviceOrThrow.aqw().y8().StartsWith("xpbl_kirillLab", StringComparison.OrdinalIgnoreCase))
			{
				d60 d = c5x.Zone.a();
				if (d != null)
				{
					if (this.a())
					{
						c5x c5x2 = new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), c5x.Area).ao() as c5x;
						if (c5x2 != null)
						{
							c5x2.Area.b((int)c5x2.Location.X, (int)c5x2.Location.Y);
							c5x.Area.Divinations.a("KirillStrongFire");
							this.a(c5x2, (double)cuo.a.Next(3, 4), 1, 2, 16, 18);
							this.a(c5x2, (double)cuo.a.Next(1, 2), 3, 3, 16, 18);
							return;
						}
					}
					else
					{
						bi7.a(d);
					}
				}
			}
		}
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x00189B3C File Offset: 0x00187D3C
	public void a(c5x A_0, double A_1, int A_2, int A_3, int A_4, int A_5)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			for (int i = A_2; i <= A_3; i++)
			{
				for (int j = A_4; j <= A_5; j++)
				{
					ak1 ak = A_0.Area.b(i, j);
					if (ak != null)
					{
						c5x c5x = dd5.a(A_0.h.b, ak, A_1, 2000, true);
						c5x.SetAspect<e3l>(new e3l(c5x)
						{
							a = 
							{
								"xpbl_kirill_flames"
							}
						});
					}
				}
			}
		}
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x00189BCC File Offset: 0x00187DCC
	public static void a(d60 A_0)
	{
		List<b0b> list = A_0.ab4(new string[]
		{
			"xpbl_kirill_flames"
		});
		if (list != null)
		{
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				c5x.Area.b((int)c5x.Location.X, (int)c5x.Location.Y);
				dd5.a(Enumerable.FirstOrDefault<ak1>(c5x.l), 0.5);
			}
		}
	}

	// Token: 0x04001C04 RID: 7172
	private new bool a;
}
